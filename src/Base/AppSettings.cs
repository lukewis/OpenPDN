using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PaintDotNet.Base
{
    public static class AppSettings
    {
        public static string FeedbackEmail => GetSetting();
        public static string CrashlogEmail => GetSetting();

        public static string GetSetting([CallerMemberName]string name = null)
        {
            var value = ConfigurationManager.AppSettings[name];
            if (string.IsNullOrEmpty(value)) throw new Exception($"Did not find {name} in the app.config file, but it is required");

            return value;
        }
    }
}
