using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectReferredCommon.Collection
{
    public enum BrowserType
    {
        chrome, Firefox
    };
    public interface IBrowserConfig
    {
        bool Headless { get; }
        bool Debug { get; }
        BrowserType Browser { get; }
        string DownloadFolder { get; }
    }
}
