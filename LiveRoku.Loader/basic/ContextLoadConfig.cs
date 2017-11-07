﻿using System.Collections.Generic;
using LiveRoku.Base;
namespace LiveRoku.Loader {
    public class ContextLoadConfig {

        internal SettingsSection AppSettings { get; } = new SettingsSection ("app.settings", null);
        public Dictionary<string, PluginConfig> AppConfigs { get; internal set; } = new Dictionary<string, PluginConfig> ();

        [Newtonsoft.Json.JsonIgnore]
        public Dictionary<string, SettingsSection> ExtraSettings { get; internal set; }

        [Newtonsoft.Json.JsonIgnore]
        internal string StoreDir { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        internal string AppDataFileName { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        internal string ExtraFileName { get; set; }

        private ISettings appSettings;
        public ContextLoadConfig () { }

        public ContextLoadConfig (string dataDir, string dataFileName, string extraConfig) {
            this.StoreDir = dataDir;
            this.AppDataFileName = dataFileName;
            this.ExtraFileName = extraConfig;
        }

        public ISettings getAppSettings () {
            return appSettings ?? (appSettings = new EasySettings (AppSettings.Items));
        }
    }
}