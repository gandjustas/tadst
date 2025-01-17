﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;


namespace TADST
{
    internal class FileHandler
    {
        public Profile ActiveProfile { get; set; }

        public FileHandler()
        {
            InitProgramPath();
        }

        public FileHandler(Profile profile)
        {
            ActiveProfile = profile;
            InitProgramPath();
        }

        /// <summary>
        /// Create all necessary folders and files
        /// </summary>
        private void InitProgramPath()
        {
            var path = Path.Combine(GetTADSTPath(), ActiveProfile.ProfileName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private static string GetRunPath()
        {
            return Environment.CurrentDirectory;
        }

        private static string GetTADSTPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TADST");
        }

        public bool OpenRpt()
        {
            var serverExe = ActiveProfile.ServerExePath.Trim().ToLower();
            string file = "";

            if (serverExe.EndsWith("arma2server.exe")) file = "arma2server.RPT";
            else if (serverExe.EndsWith("arma2oaserver.exe")) file = "arma2oaserver.RPT";
            else if (serverExe.EndsWith("arma3server.exe") || serverExe.EndsWith("arma3server_x64.exe"))
            {
                file = GetArma3Rpt();
            }

            if (string.IsNullOrEmpty(file)) return false;

            file = Path.Combine(GetTADSTPath(), ActiveProfile.ProfileName, file);

            if (File.Exists(file))
            {
                //Process.Start("notepad.exe", file);
                Process.Start(file);
                return true;
            }
            return false;
        }

        public void DeleteRpt()
        {
            var file = GetRptFile();
            if (string.IsNullOrEmpty(file)) return;

            file = Path.Combine(GetTADSTPath(), ActiveProfile.ProfileName, file);
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        public bool OpenNetlog()
        {
            var file = Path.Combine(Path.GetDirectoryName(ActiveProfile.ServerExePath), "net.log");

            if (File.Exists(file))
            {
                Process.Start("notepad.exe", file);
                return true;
            }
            return false;
        }

        public void DeleteNetLog()
        {
            var file = Path.Combine(Path.GetDirectoryName(ActiveProfile.ServerExePath), "net.log");

            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        public void RotateNetLog(string newName)
        {
            var file = Path.Combine(Path.GetDirectoryName(ActiveProfile.ServerExePath), "net.log");
            var newFile = Path.Combine(Path.GetDirectoryName(ActiveProfile.ServerExePath), newName);

            if (File.Exists(file))
            {
                File.Move(file, newFile);
            }
        }

        internal bool OpenLogFile()
        {
            var file = Path.Combine(GetTADSTPath(), ActiveProfile.ProfileName, ActiveProfile.ConsoleLogfile);
            if (File.Exists(file))
            {
                Process.Start("notepad.exe", file);
                return true;
            }
            return false;
        }

        internal bool OpenRankingFile()
        {
            var file = Path.Combine(GetTADSTPath(), ActiveProfile.ProfileName, ActiveProfile.RankingFile);
            if (File.Exists(file))
            {
                Process.Start("notepad.exe", file);
                return true;
            }
            return false;
        }

        internal bool OpenPidFile()
        {
            var file = Path.Combine(GetTADSTPath(), ActiveProfile.ProfileName, ActiveProfile.PidFile);
            if (File.Exists(file))
            {
                Process.Start("notepad.exe", file);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Create server config file 
        /// </summary>
        public void CreateConfigFile()
        {
            var path = Path.Combine(GetTADSTPath(), ActiveProfile.ProfileName);
            var file = Path.Combine(path, "TADST_config.cfg");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            File.WriteAllText(file, GetConfigString());
        }

        /// <summary>
        /// Create string
        /// </summary>
        /// <returns></returns>
        private string GetConfigString()
        {
            var configString = "";
            var voteThreshold = ActiveProfile.VotingEnabled ? ActiveProfile.VoteThreshold : 1.5m;

            configString +=
                "// Config file generated " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() +
                " with TADST." + NewLine(2) +
                "hostName = \"" + ActiveProfile.ServerName + "\";" + NewLine() +
                "password = \"" + ActiveProfile.Password + "\";" + NewLine() +
                "passwordAdmin = \"" + ActiveProfile.AdminPassword + "\";" + NewLine() +
                "serverCommandPassword = \"" + ActiveProfile.ServerCommandPassword + "\";" + NewLine() +
                "logFile = \"" + ActiveProfile.ConsoleLogfile + "\";" + NewLine(2) +
                "motd[] = {" + NewLine() + GetMotd() + "};" + NewLine() +
                "motdInterval = " + ActiveProfile.MotdInterval + ";" + NewLine(2) +
                "maxPlayers = " + ActiveProfile.MaxPlayers + ";" + NewLine() +
                "kickduplicate = " + Convert.ToInt32(ActiveProfile.KickDuplicates) + ";" + NewLine() +
                "verifySignatures = " + ActiveProfile.VerifySignatures + ";" + NewLine() +
                "allowedFilePatching = " + ActiveProfile.AllowFilePatching + ";" + NewLine() +
                "requiredSecureId = " + ActiveProfile.RequiredSecureId + ";" + NewLine();

            if (ActiveProfile.Upnp)
            {
                configString += "upnp = 1;" + NewLine();

            }

            if (ActiveProfile.Loopback)
            {
                configString += "loopback = true;" + NewLine();
            }

            if (ActiveProfile.RequiredBuildEnabled && ActiveProfile.RequiredBuild > 0)
            {
                configString += "requiredBuild = " + ActiveProfile.RequiredBuild + ";" + NewLine();
            }

            if (ActiveProfile.HeadlessEnabled)
            {
                configString += "headlessClients[]={" + string.Join(",", ActiveProfile.HeadlessIps) + "};" + NewLine();
                configString += "localClient[]={" + string.Join(",", ActiveProfile.LocalIps) + "};" + NewLine(2);
            }

            if (!ActiveProfile.VotingEnabled)
            {
                configString += NewLine() + "allowedVoteCmds[] = {};";
            }

            configString += NewLine() +
                            "voteMissionPlayers = " + ActiveProfile.VoteMissionPlayers + ";" + NewLine() +
                            "voteThreshold = " + voteThreshold.ToString(CultureInfo.InvariantCulture) + ";" + NewLine(2) +
                            "disableVoN = " + Convert.ToInt32(ActiveProfile.DisableVon) + ";" + NewLine() +
                            "vonCodecQuality = " + ActiveProfile.VonQuality + ";" + NewLine() +
                            "persistent = " + Convert.ToInt32(ActiveProfile.PersistantBattlefield) + ";" + NewLine() +
                            "timeStampFormat = \"" + ActiveProfile.RptTimeStamps[ActiveProfile.RptTimeStampIndex] +
                            "\";" + NewLine() +
                            "BattlEye = " + Convert.ToInt32(ActiveProfile.BattlEye) + ";" + NewLine();
            if (ActiveProfile.HeadlessEnabled)
            {
                configString += "battleyeLicense = 1;" + NewLine();
            }

            if (ActiveProfile.MaxPingEnabled)
            {
                configString += "maxPing = " + ActiveProfile.MaxPing + ";" + NewLine();
            }

            if (ActiveProfile.MaxDesyncEnabled)
            {
                configString += "maxDesync = " + ActiveProfile.MaxDesync + ";" + NewLine();
            }

            if (ActiveProfile.MaxPacketLossEnabled)
            {
                configString += "maxPacketloss = " + ActiveProfile.MaxPacketLoss + ";" + NewLine();
            }

            if (ActiveProfile.DisconnectTimeoutEnabled)
            {
                configString += "disconnectTimeout = " + ActiveProfile.DisconnectTimeout + ";" + NewLine();
            }

            if (ActiveProfile.KickClientsOnSlowNetworkEnabled)
            {
                configString += "kickClientsOnSlowNetwork = " + ActiveProfile.KickClientsOnSlowNetwork + ";" + NewLine();
            }



            configString += NewLine() + "doubleIdDetected = \"" + ActiveProfile.DoubleIdDetected + "\";" + NewLine() +
                            "onUserConnected = \"" + ActiveProfile.OnUserConnected + "\";" + NewLine() +
                            "onUserDisconnected = \"" + ActiveProfile.OnUserDisconnected + "\";" + NewLine() +
                            "onHackedData = \"" + ActiveProfile.OnHackedData + "\";" + NewLine() +
                            "onDifferentData = \"" + ActiveProfile.OnDifferentData + "\";" + NewLine() +
                            "onUnsignedData = \"" + ActiveProfile.OnUnsignedData + "\";" + NewLine() +
                            "regularCheck = \"" + ActiveProfile.RegularCheck + "\";" + NewLine(2) +
                            "class Missions" + NewLine() + "{" + NewLine() + GetMissions() + NewLine() + "};";


            return configString;
        }


        private string GetMotd()
        {
            var motd = "";
            for (var i = 0; i < ActiveProfile.Motd.Count; i++)
            {
                motd += "\t\"" + ActiveProfile.Motd[i] + "\"";
                motd += i < ActiveProfile.Motd.Count - 1 ? "," + Environment.NewLine : Environment.NewLine;
            }
            return motd;
        }


        /// <summary>
        /// Return string with mission classes
        /// </summary>
        /// <returns>All checked missions</returns>
        private string GetMissions()
        {
            var missionString = "";
            //var difficulty = GetDifficulty();
            var index = 0;

            foreach (var mission in ActiveProfile.Missions)
            {
                if (mission.IsChecked)
                {
                    index++;
                    missionString = missionString +
                                    "\tclass Mission_" + index + Environment.NewLine +
                                    "\t{" + Environment.NewLine +
                                    "\t\ttemplate = \"" + mission.Name.Replace(".pbo", "").Trim() + "\";" +
                                    Environment.NewLine +
                                    "\t\tdifficulty = \"" + GetDifficulty(mission.Difficulty) + "\";" +
                                    Environment.NewLine +
                                    "\t};" + Environment.NewLine + Environment.NewLine;
                }
            }
            return missionString;
        }


        private string GetDifficulty(int diff)
        {
            string difficulty;

            //switch (ActiveProfile.MissionDifficulty)
            switch (diff)
            {
                case 0:
                    difficulty = "recruit";
                    break;
                case 1:
                    difficulty = "regular";
                    break;
                case 2:
                    difficulty = "veteran";
                    break;
                case 3:
                    difficulty = "custom";
                    break;
                default:
                    difficulty = "";
                    break;
            }

            return difficulty;
        }


        public void CreateBasicConfigFile()
        {
            var path = Path.Combine(GetTADSTPath(), ActiveProfile.ProfileName);
            var file = Path.Combine(path, "TADST_basic.cfg");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            File.WriteAllText(file, GetBasicConfigString());
        }

        /// <summary>
        /// Create string to write to basic config file
        /// </summary>
        /// <returns></returns>
        private string GetBasicConfigString()
        {
            var basicConfig = "";

            basicConfig +=
                "// Basic config file generated " + DateTime.Now.ToShortDateString() + " " +
                DateTime.Now.ToShortTimeString() +
                " with TADST." + NewLine(2) +
                "MaxMsgSend = " + ActiveProfile.MaxMsgSend + ";" + NewLine() +
                "MaxSizeGuaranteed = " + ActiveProfile.MaxSizeGuaranteed + ";" + NewLine() +
                "MaxSizeNonguaranteed = " + ActiveProfile.MaxSizeNonGuaranteed + ";" + NewLine() +
                "MinBandwidth = " + ActiveProfile.MinBandWidth + ";" + NewLine() +
                "MaxBandwidth = " + ActiveProfile.MaxBandwidth + ";" + NewLine() +
                "MinErrorToSend = " + ActiveProfile.MinErrorToSend.ToString(CultureInfo.InvariantCulture) + ";" +
                NewLine() +
                "MinErrorToSendNear = " + ActiveProfile.MinErrorToSendNear.ToString(CultureInfo.InvariantCulture) + ";" +
                NewLine() +
                "MaxCustomFileSize = " + ActiveProfile.MaxCustomFileSize + ";" + NewLine() +
                "class sockets{maxPacketSize = " + ActiveProfile.MaxPacketSize + ";};" + NewLine() +
                "adapter=-1;" + NewLine() +
                "3D_Performance=1;" + NewLine() +
                "Resolution_W=0;" + NewLine() +
                "Resolution_H=0;" + NewLine() +
                "Resolution_Bpp=32;" + NewLine() +
                "terrainGrid=" + ActiveProfile.TerrainGrid.ToString(CultureInfo.InvariantCulture) + ";" + NewLine() +
                "viewDistance=" + ActiveProfile.ViewDistance + ";" + NewLine() +
                "Windowed=0;";

            return basicConfig;
        }


        private void CreateProfileFile()
        {
            var path = Path.Combine(GetTADSTPath(), ActiveProfile.ProfileName, "Users", ActiveProfile.ProfileName);
            var fileOA = Path.Combine(path, ActiveProfile.ProfileName + ".ArmA2OAProfile");
            var fileA = Path.Combine(path, ActiveProfile.ProfileName + ".ArmA2Profile");
            var fileA3 = Path.Combine(path, ActiveProfile.ProfileName + ".Arma3Profile");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            File.WriteAllText(fileOA, GetProfileString("oa"));
            File.WriteAllText(fileA, GetProfileString("a2"));
            File.WriteAllText(fileA3, GetProfileString("a3"));
        }

        private string GetProfileString(string game)
        {
            var profileString = "";

            string defaultDiff = "";

            switch (ActiveProfile.DefaultDifficulty)
            {
                case 0:
                    defaultDiff = "recruit";
                    break;
                case 1:
                    defaultDiff = "regular";
                    break;
                case 2:
                    defaultDiff = "veteran";
                    break;
                case 3:
                    defaultDiff = "custom";
                    break;
                default:
                    defaultDiff = "regular";
                    break;
            }

            profileString +=
                "difficulty=\"" + defaultDiff + "\";" + NewLine() +
                "class DifficultyPresets" + NewLine() +
                "{" + NewLine() +
                "\tclass CustomDifficulty" + NewLine() +
                "\t{" + NewLine() +
                GetProfileOptions(ActiveProfile.DiffCustom, game) +
                GetProfileSkills(ActiveProfile.DiffCustom) +
                "\t};" + NewLine(2) +
                "};";

            return profileString;
        }

        private static string GetProfileSkills(DifficultySetting difficultySetting)
        {
            var profileSkills = "";

            profileSkills +=
                "\t\taiLevelPreset=" +
                difficultySetting.AILevelPreset.ToString(CultureInfo.InvariantCulture) +
                ";" + NewLine() + NewLine() +
                "\t\tclass CustomAILevel" + NewLine() +
                "\t\t{" + NewLine() +
                "\t\t\tskillAI=" + difficultySetting.SkillAI.ToString(CultureInfo.InvariantCulture) + ";" + NewLine() +
                "\t\t\tprecisionAI=" + difficultySetting.PrecisionAI.ToString(CultureInfo.InvariantCulture) + ";" +
                NewLine() +
                "\t\t};" + NewLine();

            return profileSkills;
        }

        /// <summary>
        /// Get difficulty flags string. Formatted for A2 or A3
        /// </summary>
        /// <param name="diff">The difficulty settings object that contains the items</param>
        /// <param name="game">If this is "a3" special Arma3 settings will be added </param>
        /// <returns></returns>
        private static string GetProfileOptions(DifficultySetting diff, string game)
        {
            var profileOptions = "";

            profileOptions += "\t\tclass Options" + NewLine() + "\t\t{" + NewLine();
            foreach (var diffItem in diff.DifficultyItems)
            {
                if (diffItem.Name.Contains("(A3)") && game != "a3") continue;
                profileOptions += "\t\t\t" + diffItem.GetConfigString() + NewLine();
            }
            profileOptions += "\t\t};" + NewLine();

            return profileOptions;
        }

        /// <summary>
        /// Add newline characters
        /// </summary>
        /// <param name="numOfLines">Number of newlines to add. Default is 1</param>
        /// <returns>String of newlines</returns>
        private static string NewLine(int numOfLines = 1)
        {
            var newLines = "";
            for (var i = 0; i < numOfLines; i++)
            {
                newLines += Environment.NewLine;
            }
            return newLines;
        }

        /// <summary>
        /// Create all config files
        /// </summary>
        internal void CreateConfigFiles()
        {
            CreateConfigFile();
            CreateBasicConfigFile();
            CreateProfileFile();
        }

        internal void ExportFiles(string targetPath)
        {
            CreateConfigFiles();
            CopyFiles(targetPath);
            CreateParametersFile(targetPath);
        }

        private void CreateParametersFile(string targetPath)
        {
            var textFile = Path.Combine(targetPath, "Startup Parameters.txt");
            var startupParameters = "Startup parameters for copy/paste:" + NewLine(2) +
                                    ActiveProfile.GetStartupParameters();

            File.WriteAllText(textFile, startupParameters);
        }

        private void CopyFiles(string targetPath)
        {
            var fileArray = GetFileArray();

            foreach (var file in fileArray)
            {
                if (!File.Exists(file)) continue;
                var target = Path.Combine(targetPath,
                                          file.Substring(file.LastIndexOf("\\", StringComparison.Ordinal) + 1));
                File.Copy(file, target, true);
            }
        }

        private IEnumerable<string> GetFileArray()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TADST", ActiveProfile.ProfileName);
            var configFile = Path.Combine(path, "TADST_config.cfg");
            var basicConfigFile = Path.Combine(path, "TADST_basic.cfg");
            var arma2Profile = Path.Combine(path, "Users", ActiveProfile.ProfileName,
                                            ActiveProfile.ProfileName + ".ArmA2Profile");
            var arma2OAProfile = Path.Combine(path, "Users", ActiveProfile.ProfileName,
                                              ActiveProfile.ProfileName + ".ArmA2OAProfile");

            var fileArray = new string[] {configFile, basicConfigFile, arma2Profile, arma2OAProfile};

            return fileArray;
        }

        public bool LaunchServer(bool asIs)
        {
            var file = ActiveProfile.ServerExePath;

            if (!File.Exists(file))
            {
                return false;
            }

            if (asIs) CreateConfigFiles();
            StartServerProcess(file);

            return true;
        }

        private void StartServerProcess(string file)
        {
            /*var serverProcessStartInfo = new ProcessStartInfo {FileName = file};

            var serverProcess = new Process
                                        {
                                            StartInfo = serverProcessStartInfo, 
                                            EnableRaisingEvents = true
                                        };
            serverProcess.Exited += ReLaunch;
            serverProcess.Start();*/


            var serverProcess = new ProcessStartInfo(file)
                                    {
                                        WorkingDirectory = Path.GetDirectoryName(ActiveProfile.ServerExePath),
                                        Arguments = ActiveProfile.GetStartupParameters()
                                    };

            Process.Start(serverProcess);
        }

        private void ReLaunch(object sender, EventArgs e)
        {
            LaunchServer(true);
        }

        internal void DeleteProfile(string profileName)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TADST", profileName);

            if (Directory.Exists(path))
            {
                try
                {
                    Directory.Delete(path, true);
                }
                catch (Exception)
                {
                }
            }

            File.Delete(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TADST"), profileName + ".json"));
        }


        public string GetRptFile()
        {
            var serverExe = ActiveProfile.ServerExePath.Trim().ToLower();
            string file;

            if (serverExe.EndsWith("arma2server.exe")) file = "arma2server.RPT";
            else if (serverExe.EndsWith("arma2oaserver.exe")) file = "arma2oaserver.RPT";
            else if (serverExe.EndsWith("arma3server.exe") || serverExe.EndsWith("arma3server_x64.exe"))
            {
                file = GetArma3Rpt();
            }
            else
            {
                file = "";
            }
            return file;
        }

        private string GetArma3Rpt()
        {
            var folder =
                new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TADST", ActiveProfile.ProfileName));
            FileInfo[] fileInfo = folder.GetFiles("*.rpt");
            List<String> fileNames = fileInfo.Select(info => info.Name).ToList();

            if (fileNames.Count == 0) return null;

            fileNames.Sort();
            return fileNames[fileNames.Count - 1];
        }

    }
}