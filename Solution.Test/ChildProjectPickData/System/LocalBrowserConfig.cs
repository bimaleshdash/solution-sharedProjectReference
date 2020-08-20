using ProjectReferredCommon.Collection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChildProjectPickData.System
{
    class LocalBrowserConfig : GlobalBrowserConfig
    {
        public DataHubConfig datahub;

        public LocalBrowserConfig() : base(MakeTempPath())
        {
        }

        private static string MakeTempPath() =>
            Path.Combine(Path.GetTempPath(), $"GS1-{"78945641"}");
    }

    class DataHubConfig
    {
        public string url;
        public string username;
        public string password;
    }

}
