using BmLauncherWForm.data;
using BmLauncherWForm.Properties;
using BmLauncherWForm.ui;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;

namespace BmLauncherWForm.infrastructure
{
    /// Factory that read and writes all of the accessed files.
    /// Applies various fixes and executes the NVSetter file if conditions are met.
    internal class Factory
    {
        // logger for easy debugging
        private static Logger logger = LogManager.GetCurrentClassLogger();

        // location of the BmEngine configuration file
        private static readonly string ConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                                    "\\Square Enix\\Batman Arkham Asylum GOTY\\BmGame\\Config\\BmEngine.ini";

        // location of the UserEngine configuration file
        private static readonly string UserEngineFile =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
            "\\Square Enix\\Batman Arkham Asylum GOTY\\BmGame\\Config\\UserEngine.ini";

        // location of the UserInput configuration file
        public static string InputFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                         "\\Square Enix\\Batman Arkham Asylum GOTY\\BmGame\\Config\\UserInput.ini";

        // location of the UserInput configuration file
        public static string BmInputFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                           "\\Square Enix\\Batman Arkham Asylum GOTY\\BmGame\\Config\\BmInput.ini";

        // folder containing all configuration files
        private static readonly string ConfigDirectory =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
            "\\Square Enix\\Batman Arkham Asylum GOTY\\BmGame\\Config\\";

        // form associated to the factory
        private static BmLauncherForm client;

        private static KeybindInterpreter kInterpreter;

        // FileInfo used to control the readonly properties of the BmEngine file
        public static readonly FileInfo ConfigInfo = new FileInfo(ConfigFile);

        // FileInfo used to control the readonly properties of the UserEngine file
        public static readonly FileInfo UserEngineInfo = new FileInfo(UserEngineFile);

        public static readonly FileInfo InputFileInfo = new FileInfo(InputFile);

        public static readonly FileInfo BmInputFileInfo = new FileInfo(BmInputFile);

        // contains all lines (as strings) of the BmEngine file
        private static readonly List<string> ConfigList = new List<string>();

        // contains all lines (as strings) of the UserInput file
        public static List<string> InputList = new List<string>();

        // contains all lines (as strings) of the BMInput file
        public static List<string> BMInList = new List<string>();

        // prepackaged BmEngine file, used in case file is missing
        private static readonly string BmEnginePremade = Resources.BmEngine;

        // prepackaged UserEngine file, used in case file is missing
        private static readonly string UserEnginePremade = Resources.UserEngine;

        // prepackaged UserInput file, used in case file is missing
        private static readonly string UserInputPremade = Resources.UserInput;

        // string array containing all lines that need to be changed for the GPUnity texturepack to work
        private static readonly string[] TexFixLines =
        {
            "TEXTUREGROUP_Character=(MinLODSize=512,MaxLODSize=4096,LODBias=0)",
            "TEXTUREGROUP_CharacterNormalMap=(MinLODSize=512,MaxLODSize=4096,LODBias=0)", "PoolSize=2048"
        };

        // string array containing all default texture lines
        private static readonly string[] TexFixDefaults =
        {
            "TEXTUREGROUP_Character=(MinLODSize=512,MaxLODSize=2048,LODBias=0)",
            "TEXTUREGROUP_CharacterNormalMap=(MinLODSize=512,MaxLODSize=2048,LODBias=0)", "PoolSize=512"
        };

        // string array containing all lines to disable startup movies
        private static readonly string[] StartUpMovieLines =
        {
            ";StartupMovies=baa_logo_run_v5_h264", ";StartupMovies=UTlogo", ";StartupMovies=Legal",
            ";StartupMovies=Black"
        };

        // boolean used to determine whether to launch game normally or via texmod
        public static bool TexmodDetected = false;

        private GraphicsInterpreter gInterpreter;

        // keybind form associated to the factory
        public KeybindForm Keybinds = new KeybindForm();

        // integer used for switch cases by GraphicsInterpreter
        public int LineInt = 21;

        /// <summary>
        ///     Constructor for the Factory class. Initializes the client and GPU name and extracts the NvAPIWrapper for NVIDIA
        ///     GPUs
        /// </summary>
        public Factory(BmLauncherForm form)
        {
            logger = LogManager.GetCurrentClassLogger();
            client = form;
            logger.Info("Constructor - Created Factory");
            setGPUname();
            ExtractWrapper();
            if (!TexmodDetected)
            {
                client.TexmodLabel.Text = "Texmod not found.";
                client.TexmodLabel.ForeColor = Color.Firebrick;
                client.basicToolTip.SetToolTip(client.TexmodLabel,
                    "Texmod has not been found.\r\n\r\nIf you intend to use Texmod, place or create 'texmod_autoload.exe' in the same folder as the launcher.");
            }
        }

        /// <summary>
        ///     Method that executes the other read methods.
        /// </summary>
        public void readFiles()
        {
            gInterpreter = new GraphicsInterpreter();
            readDirectory();
            readConfigFile();
            readInputFile();
            readBMInput();
            client.applyButton.Enabled = false;
            client.ChangedConfig = false;
        }

        /// <summary>
        ///     This method is especially (and probably only) useful when first launching the game.
        ///     It will create the config directory and place prepackaged configuration files in there.
        /// </summary>
        private void readDirectory()
        {
            if (Directory.Exists(ConfigDirectory))
            {
                return;
            }

            logger.Warn("Directory {0} does not exist.", ConfigDirectory);
            Directory.CreateDirectory(ConfigDirectory);
            File.Create(ConfigDirectory + "BmCamera.ini").Dispose();
            StreamWriter camFile = new StreamWriter(ConfigDirectory + "BmCamera.ini");
            File.Create(ConfigDirectory + "BmCompat.ini").Dispose();
            StreamWriter compFile = new StreamWriter(ConfigDirectory + "BmCompat.ini");
            File.Create(ConfigDirectory + "BmEditor.ini").Dispose();
            StreamWriter editFile = new StreamWriter(ConfigDirectory + "BmEditor.ini");
            File.Create(ConfigDirectory + "BmEditorUserSettings.ini").Dispose();
            StreamWriter editUserFile = new StreamWriter(ConfigDirectory + "BmEditorUserSettings.ini");
            File.Create(ConfigDirectory + "BmGame.ini").Dispose();
            StreamWriter gameFile = new StreamWriter(ConfigDirectory + "BmGame.ini");
            File.Create(ConfigDirectory + "BmInput.ini").Dispose();
            StreamWriter fakeInputFile = new StreamWriter(ConfigDirectory + "BmInput.ini");
            File.Create(ConfigDirectory + "BmUI.ini").Dispose();
            StreamWriter uiFile = new StreamWriter(ConfigDirectory + "BmUI.ini");
            File.Create(ConfigDirectory + "UserGame.ini").Dispose();
            StreamWriter uGameFile = new StreamWriter(ConfigDirectory + "UserGame.ini");
            camFile.Write(Resources.BmCamera);
            compFile.Write(Resources.BmCompat);
            editFile.Write(Resources.BmEditor);
            editUserFile.Write(Resources.BmEditorUserSettings);
            gameFile.Write(Resources.BmGame);
            fakeInputFile.Write(Resources.BmInput);
            uiFile.Write(Resources.BmUI);
            uGameFile.Write(Resources.UserGame);
            camFile.Close();
            compFile.Close();
            editFile.Close();
            editUserFile.Close();
            gameFile.Close();
            fakeInputFile.Close();
            uiFile.Close();
            uGameFile.Close();
            logger.Info("readDirectory - created {0} + all required files.", ConfigDirectory);
        }

        /// <summary>
        ///     Reads the each line of BmEngine and saves it to a string list.
        ///     Overwrites pre-existing file if it's not created by Launcher.
        ///     Initializes the GUI after every parameter has been read.
        /// </summary>
        private void readConfigFile()
        {
            // creates files if they don't exist
            if (!File.Exists(ConfigFile))
            {
                logger.Warn("readConfigFile - BmEngine not found at {0}. Generating it now.", ConfigFile);
                File.Create(ConfigFile).Dispose();
                using (StreamWriter file = new StreamWriter(ConfigFile))
                {
                    file.Write(BmEnginePremade);
                    logger.Debug("readConfigFile - generated BmEngine at: {0}", ConfigFile);
                }
            }

            if (!File.Exists(UserEngineFile))
            {
                logger.Warn("readConfigFile - UserEngine not found at {0}. Generating it now.", UserEngineFile);
                File.Create(UserEngineFile).Dispose();
                using (StreamWriter file = new StreamWriter(UserEngineFile))
                {
                    file.Write(UserEnginePremade);
                    logger.Debug("readConfigFile - generated UserEngine at: {0}", UserEngineFile);
                }
            }

            string[] confLines = File.ReadAllLines(ConfigFile);

            // if-condition only relevant if BmEngine was not created by the Launcher. Will overwrite existing file
            if (!confLines.Last().Equals("[Generated by Batman: Arkham Asylum - Advanced Launcher]"))
            {
                ConfigInfo.IsReadOnly = false;
                UserEngineInfo.IsReadOnly = false;
                File.Delete(ConfigFile);
                using (StreamWriter file = new StreamWriter(ConfigFile))
                {
                    file.Write(BmEnginePremade);
                    ConfigInfo.IsReadOnly = true;
                }

                File.Delete(UserEngineFile);
                using (StreamWriter file = new StreamWriter(UserEngineFile))
                {
                    file.Write(UserEnginePremade);
                    UserEngineInfo.IsReadOnly = true;
                }

                logger.Debug(
                    "readConfigFile - Replacing BmEngine & UserEngine with custom made Advanced Launcher files.");
            }

            for (int i = 0; i < confLines.Length; i++)
            {
                ConfigList.Add(confLines[i]);
                if (i >= 1161 && i <= 1165)
                {
                    GraphicsInterpreter.checkIntro(confLines[i]);
                }

                if (i == 663 || (i >= 1108 && i <= 1133))
                {
                    GraphicsInterpreter.checkTex(confLines[i]);
                }

                if (i == LineInt)
                {
                    gInterpreter.interpretGraphics(confLines[i], true, LineInt);
                }
            }

            logger.Info("readConfigFile - processed BmEngine & UserEngine.");

            new GuiInitializer().init();
        }

        /// <summary>
        ///     Reads the UserInput file and saves the lines to a string list.
        ///     Overwrites pre-existing file if it's not created by Launcher.
        /// </summary>
        public void readInputFile()
        {
            // creates file if it doesn't exist
            if (!File.Exists(InputFile))
            {
                logger.Warn("readInputFile - UserInput not found at {0}. Generating it now.", InputFile);
                File.Create(InputFile).Dispose();
                using (StreamWriter file = new StreamWriter(InputFile))
                {
                    file.Write(UserInputPremade);
                }

                logger.Debug("readInputFile - generated UserInput at: {0}", InputFile);
            }

            InputFileInfo.IsReadOnly = false;

            string[] inputLines = File.ReadAllLines(InputFile);

            // if-condition only relevant if UserInput was not created by the Launcher. Will overwrite existing file
            if (!inputLines.Last().Equals("[Generated by Batman: Arkham Asylum - Advanced Launcher]"))
            {
                File.Delete(InputFile);
                using (StreamWriter file = new StreamWriter(InputFile))
                {
                    file.Write(UserInputPremade);
                }

                logger.Debug("readInputFile - replaced UserInput with custom made Advanced Launcher files.");

                inputLines = File.ReadAllLines(InputFile);
            }

            logger.Debug("readInputFile - starting interpretKeys reading process.");
            kInterpreter = new KeybindInterpreter();
            for (int i = 0; i < inputLines.Length; i++)
            {
                InputList.Add(inputLines[i]);
                if (i < 51)
                {
                    kInterpreter.interpretKeys(inputLines[i], true);
                }
            }

            logger.Info("readInputFile - processed UserInput.");
        }

        private void readBMInput()
        {
            if (!File.Exists(BmInputFile))
            {
                logger.Warn("readBMInput - BMInput not found at {0}. Generating it now.", Path.Combine(BmInputFile));
                File.Create(BmInputFile).Dispose();
                StreamWriter fakeInputFile = new StreamWriter(BmInputFile);
                fakeInputFile.Write(Resources.BmInput);
                fakeInputFile.Close();
                logger.Debug("readBMInput - generated BMInput at: {0}", InputFile);
            }

            BmInputFileInfo.IsReadOnly = false;

            string[] bmlist = File.ReadAllLines(BmInputFile);
            for (int i = 0; i < bmlist.Length; i++)
            {
                BMInList.Add(bmlist[i]);
            }

            logger.Debug("readBMInput - Reading BMInput.ini.");
            kInterpreter.processBMInput(bmlist[5]);
            kInterpreter.processBMInput(bmlist[7]);
        }

        /// <summary>
        ///     Method is called when 'Apply Settings' or 'Start Game' gets pressed.
        ///     Utilizes GraphicsWriter helper class to change Parameters in Graphics class.
        ///     GraphicsInterpreter is used to write Graphics parameters to file.
        ///     This method also controls the readonly functionality.
        ///     After the writing procedure is done, file is made readonly.
        /// </summary>
        public void writeGraphFile()
        {
            ConfigInfo.IsReadOnly = false;
            new GraphicsWriter().writeAll();
            using (StreamWriter file = new StreamWriter(ConfigFile))
            {
                for (int i = 0; i < ConfigList.Count; i++)
                {
                    file.WriteLine(i != LineInt
                        ? ConfigList[i]
                        : gInterpreter.interpretGraphics(ConfigList[i], false, LineInt));
                }

                file.Close();
            }

            ConfigInfo.IsReadOnly = true;
            logger.Debug("writeGraphFile - saved graphics parameters to {0}", ConfigFile);
        }

        /// <summary>
        ///     Saves Keybinds to UserInput file. Only interprets the first 56 lines, to allow for customization by users after
        ///     that.
        /// </summary>
        public void writeInputFile()
        {
            logger.Debug("writeInputFile - starting interpretKeys writing process.");
            using (StreamWriter file = new StreamWriter(InputFile))
            {
                for (int i = 0; i < 56; i++)
                {
                    file.WriteLine(kInterpreter.interpretKeys(InputList[i], false));
                }

                for (int i = 56; i < InputList.Count; i++)
                {
                    file.WriteLine(InputList[i]);
                }

                file.Close();
            }

            logger.Debug("writeInputFile - saved input parameters to {0}", InputFile);
        }

        public void writeBmInputFile()
        {
            BmInputFileInfo.IsReadOnly = false;

            logger.Debug("writeBmInputFile - writing BmInput.ini.");
            using (StreamWriter file = new StreamWriter(BmInputFile))
            {
                for (int i = 0; i < BMInList.Count; i++)
                {
                    if (i == 5)
                    {
                        file.WriteLine("MouseSensitivity=" + Keybinds.SensitivityValueLabel.Text + ".0");
                    }
                    else if (i == 7)
                    {
                        if (Keybinds.MouseSmoothBox.SelectedIndex == 0)
                        {
                            file.WriteLine("bEnableMouseSmoothing=true");
                        }
                        else
                        {
                            file.WriteLine("bEnableMouseSmoothing=false");
                        }
                    }
                    else
                    {
                        file.WriteLine(BMInList[i]);
                    }
                }

                file.Close();
            }

            BmInputFileInfo.IsReadOnly = true;
        }

        /// <summary>
        ///     Calls texfix method to change Texturegroup parameters in BmEngine file.
        /// </summary>
        public void SetTexfix()
        {
            ConfigInfo.IsReadOnly = false;
            using (StreamWriter file = new StreamWriter(ConfigFile))
            {
                if (client.texgroupButton.Text == "Enable Texture Pack Fix")
                {
                    for (int i = 0; i < ConfigList.Count; i++)
                    {
                        ConfigList[i] = texfix(ConfigList[i]);
                        file.WriteLine(ConfigList[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < ConfigList.Count; i++)
                    {
                        ConfigList[i] = texdefault(ConfigList[i]);
                        file.WriteLine(ConfigList[i]);
                    }
                }

                file.Close();
            }

            texApplied();
            if (client.memPoolBox.SelectedIndex != 2 && client.memPoolBox.SelectedIndex != 3 &&
                client.memPoolBox.SelectedIndex != 4 && client.memPoolBox.SelectedIndex != 5)
            {
                client.memPoolBox.SelectedIndex = 2;
            }

            ConfigInfo.IsReadOnly = true;
            logger.Debug("applyTexfix - applied parameter fixes for Texture Pack support to {0}", ConfigFile);
        }

        /// <summary>
        ///     Checks string and changes it to appropriate string from array.
        ///     Used by applyTexfix() method.
        /// </summary>
        /// <param name="lineToCheck">Line that gets checked</param>
        /// <returns>Corrected line</returns>
        private string texfix(string lineToCheck)
        {
            if (lineToCheck.Contains("TEXTUREGROUP_Character=(MinLODSize="))
            {
                lineToCheck = TexFixLines[0];
                return lineToCheck;
            }

            if (lineToCheck.Contains("TEXTUREGROUP_CharacterNormalMap=(MinLODSize="))
            {
                lineToCheck = TexFixLines[1];
                return lineToCheck;
            }

            if (lineToCheck.Contains("PoolSize") && !lineToCheck.Contains("CommonAudio") &&
                !(lineToCheck.Equals("PoolSize=2048") || lineToCheck.Equals("PoolSize=3072") ||
                  lineToCheck.Equals("PoolSize=4096") || lineToCheck.Equals("PoolSize=0")))
            {
                lineToCheck = TexFixLines[2];
                return lineToCheck;
            }

            return lineToCheck;
        }

        private string texdefault(string lineToCheck)
        {
            if (lineToCheck.Contains("TEXTUREGROUP_Character=(MinLODSize="))
            {
                lineToCheck = TexFixDefaults[0];
                return lineToCheck;
            }

            if (lineToCheck.Contains("TEXTUREGROUP_CharacterNormalMap=(MinLODSize="))
            {
                lineToCheck = TexFixDefaults[1];
                return lineToCheck;
            }

            if (lineToCheck.Contains("PoolSize") && !lineToCheck.Contains("CommonAudio") &&
                (lineToCheck.Equals("PoolSize=2048") || lineToCheck.Equals("PoolSize=3072") ||
                  lineToCheck.Equals("PoolSize=4096") || lineToCheck.Equals("PoolSize=0")))
            {
                lineToCheck = TexFixDefaults[2];
                return lineToCheck;
            }

            return lineToCheck;
        }

        /// <summary>
        ///     Method that disables texgroupButton.
        ///     Used by Factory for applyTexfix() method.
        ///     Is called by GraphicsInterpreter if conditions are met.
        /// </summary>
        public void texApplied()
        {
            if (client.texgroupButton.Text.Equals("Enable Texture Pack Fix"))
            {
                client.texgroupButton.Text = "Disable Texture Pack Fix";
            }
            else
            {
                client.texgroupButton.Text = "Enable Texture Pack Fix";
            }
        }

        /// <summary>
        ///     Works exactly like applyTexfix().
        ///     Calls introFix() method to correct the input string.
        /// </summary>
        public void SetIntroFix()
        {
            ConfigInfo.IsReadOnly = false;
            using (StreamWriter file = new StreamWriter(ConfigFile))
            {
                if (client.disableIntroButton.Text == "Disable Intro Movies")
                {
                    for (int i = 0; i < ConfigList.Count; i++)
                    {
                        ConfigList[i] = introFix(ConfigList[i]);
                        file.WriteLine(ConfigList[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < ConfigList.Count; i++)
                    {
                        ConfigList[i] = introDefault(ConfigList[i]);
                        file.WriteLine(ConfigList[i]);
                    }
                }

                file.Close();
            }

            introApplied();
            ConfigInfo.IsReadOnly = true;
            logger.Debug("applyIntrofix - changed parameters to disable startup movies at: {0}", ConfigFile);
        }

        /// <summary>
        ///     Checks string and changes it to appropriate string from array.
        ///     Used by applyIntroFix() method.
        /// </summary>
        /// <param name="lineToCheck">Line that gets checked</param>
        /// <returns>Corrected line</returns>
        private string introFix(string lineToCheck)
        {
            if (lineToCheck.Contains("StartupMovies=baa_logo_run_v5_h264"))
            {
                lineToCheck = StartUpMovieLines[0];
                return lineToCheck;
            }

            if (lineToCheck.Contains("StartupMovies=UTlogo"))
            {
                lineToCheck = StartUpMovieLines[1];
                return lineToCheck;
            }

            if (lineToCheck.Contains("StartupMovies=Legal"))
            {
                lineToCheck = StartUpMovieLines[2];
                return lineToCheck;
            }

            if (lineToCheck.Contains("StartupMovies=Black"))
            {
                lineToCheck = StartUpMovieLines[3];
                return lineToCheck;
            }

            return lineToCheck;
        }

        private string introDefault(string lineToCheck)
        {
            if (lineToCheck.Contains("StartupMovies=baa_logo_run_v5_h264"))
            {
                lineToCheck = StartUpMovieLines[0].Substring(1);
                return lineToCheck;
            }

            if (lineToCheck.Contains("StartupMovies=UTlogo"))
            {
                lineToCheck = StartUpMovieLines[1].Substring(1);
                return lineToCheck;
            }

            if (lineToCheck.Contains("StartupMovies=Legal"))
            {
                lineToCheck = StartUpMovieLines[2].Substring(1);
                return lineToCheck;
            }

            if (lineToCheck.Contains("StartupMovies=Black"))
            {
                lineToCheck = StartUpMovieLines[3].Substring(1);
                return lineToCheck;
            }

            return lineToCheck;
        }

        /// <summary>
        ///     Method that disables disableIntroButton.
        ///     Used by Factory for applyIntroFix() method.
        ///     Is called by GraphicsInterpreter if conditions are met.
        /// </summary>
        public void introApplied()
        {
            if (client.disableIntroButton.Text.Equals("Disable Intro Movies"))
            {
                client.disableIntroButton.Text = "Enable Intro Movies";
            }
            else
            {
                client.disableIntroButton.Text = "Disable Intro Movies";

            }
        }

        /// <summary>
        ///     Utilizes ManagementObjectSearcher to gather GPU information.
        ///     Changes gpInfoLabel accordingly. Called in Constructor.
        /// </summary>
        private void setGPUname()
        {
            List<string> gpuList = new List<string>();
            string gpu = "";
            ManagementObjectSearcher search = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementBaseObject o in search.Get())
            {
                ManagementObject obj = (ManagementObject)o;
                foreach (PropertyData data in obj.Properties)
                {
                    if (data.Name == "Description")
                    {
                        gpuList.Add(data.Value.ToString());
                    }
                }
            }

            // this codeblock is relevant if you have more than 1 GPU
            if (gpuList.Count > 1)
            {
                // Iterates through each GPU, looking for an nvidia card.
                foreach (string s in gpuList)
                {
                    if (!s.Contains("NVIDIA"))
                    {
                        continue;
                    }

                    gpu = s;
                    break;
                }
            }
            else
            {
                gpu = gpuList[0];
            }

            if (gpu.Contains("NVIDIA"))
            {
                client.gpInfoLabel.ForeColor = Color.Green;
            }

            if (gpu.Contains("Radeon") || gpu.Contains("AMD") || gpu.Contains("Intel"))
            {
                gpu += " (PhysX not recommended)";
                if (gpu.Contains("Radeon") || gpu.Contains("AMD"))
                {
                    client.gpInfoLabel.ForeColor = Color.Red;
                }
                else
                {
                    client.gpInfoLabel.ForeColor = Color.Blue;
                }
            }

            client.gpInfoLabel.Text = gpu;
            logger.Debug("setGPUName - found {0} Graphics Card(s). GPU selected: {1}", gpuList.Count, gpu);
        }

        /// <summary>
        ///     Used to extract the NvAPIWrapper.dll resource needed for NVIDIA GPUs to modify AO settings
        /// </summary>
        private void ExtractWrapper()
        {
            if (!client.gpInfoLabel.Text.Contains("NVIDIA") || File.Exists("NvAPIWrapper.dll"))
            {
                return;
            }

            File.WriteAllBytes("NvAPIWrapper.dll", Resources.NvAPIWrapper);
            logger.Debug("ExtractWrapper - extracted NvAPIWrapper to working directory.");
        }

        /// <summary>
        ///     Executes helper application that requires admin privileges.
        ///     Application sets HBAO+ compatibility flags in NVIDIA profile.
        ///     Called by GraphicsWriter if conditions are met.
        /// </summary>
        public void ExecNvSetter()
        {
            if (!File.Exists("NVSetter.exe"))
            {
                string exeLocation = Path.Combine(Directory.GetCurrentDirectory(), "NVSetter.exe");

                using (FileStream stream = new FileStream(exeLocation, FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] bytes = Resources.NVSetter;
                    stream.Write(bytes, 0, bytes.Length);
                }

                logger.Debug("ExecNvSetter - creating NVSetter.exe in working directory.");
            }

            ProcessStartInfo nvProcess = new ProcessStartInfo("NVSetter.exe") { Verb = "runas" };
            Process.Start(nvProcess);
            logger.Debug("ExecNvSetter - Executing NVSetter.exe");
        }
    }
}