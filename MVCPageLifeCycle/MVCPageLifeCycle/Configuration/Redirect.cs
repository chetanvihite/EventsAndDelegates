using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVCPageLifeCycle.Configuration
{
    public class Redirect : ConfigurationElement
    {
        [ConfigurationProperty("Old")]
        public string Old
        {
            get { return this["Old"] as string; }
            set { this["Old"] = value; }
        }
        [ConfigurationProperty("New")]
        public string New
        {
            get { return this["New"] as string; }
            set { this["New"] = value; }
        }
        [ConfigurationProperty("Title")]
        public string Title
        {
            get { return this["Title"] as string; }
            set { this["Title"] = value; }
        }
    }
}