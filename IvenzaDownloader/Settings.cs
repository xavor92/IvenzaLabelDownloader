using System;
using System.Collections.Generic;
using System.Text;

namespace ivenzaDownloader
{
    class Settings
    {
        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

        public string User {get;set;}
        public string Passwort {get;set;}
        public string URLBase { get; set; }
        public string URLTest { get; set; }
        public string LoginPage { get; set; }
        public string DownloadTemplate { get; set; }
        public string DownloadTemplate_rotated { get; set; }
        public string InputFile {get;set;}
        public string OutputPath {get;set;}
    }
}
