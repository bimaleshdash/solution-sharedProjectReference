using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectReferredCommon.Collection
{

    public abstract class GlobalBrowserConfig : IBrowserConfig
    {
        private readonly string tmpDir;
        public bool Headless { get; set; }
        public bool Debug { get; set; }
        public BrowserType Browser { get; set; }
        public string DownloadFolder { get; set; }
        protected GlobalBrowserConfig(string tmpDir)
        {
            Directory.CreateDirectory(tmpDir);
            this.tmpDir = tmpDir;
        }
        public void CleanUp()
        {

            foreach (var file in Directory.GetFiles(tmpDir))
            {
                File.Delete(file);
            }
        }
    }
    
}
