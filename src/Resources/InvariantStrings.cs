/////////////////////////////////////////////////////////////////////////////////
// Paint.NET                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, Tom Jackson, and contributors.     //
// Portions Copyright (C) Microsoft Corporation. All Rights Reserved.          //
// See src/Resources/Files/License.txt for full licensing and attribution      //
// details.                                                                    //
// .                                                                           //
/////////////////////////////////////////////////////////////////////////////////

using PaintDotNet.Base;
using System;
using System.Configuration;

namespace PaintDotNet
{
    /// <summary>
    /// Contains strings that must be the same no matter what locale the UI is running with.
    /// </summary>
    public static class InvariantStrings
    {
        // {0} is "All Rights Reserved"
        // Legal has advised that's the only part of this string that should be localizable.
        public static string CopyrightFormat => 
            "Copyright © 2008 dotPDN LLC, Rick Brewster, Tom Jackson, and contributors. Portions Copyright © Microsoft Corporation. {0}";

        public static string FeedbackEmail => AppSettings.GetSetting();

        public static string CrashlogEmail => AppSettings.GetSetting();

        public static string WebsiteUrl => AppSettings.GetSetting();

        public static string WebsitePageHelpMenu => "/redirect/main_hm.html";

        public static string ForumPageHelpPage => "/redirect/forum_hm.html";

        public static string PluginsPageHelpPage => "/redirect/plugins_hm.html";

        public static string TutorialsPageHelpPage => "/redirect/tutorials_hm.html";

        public static string DonatePageHelpMenu => "/redirect/donate_hm.html";

        public static string SearchEngineHelpMenu => "/redirect/search_hm.html";

        public static string DonateUrlSetup => AppSettings.GetSetting();

        public static string ExpiredPage => "redirect/pdnexpired.html";

        public static string EffectsSubDir => "Effects";

        public static string FileTypesSubDir => "FileTypes";

        public static string DllExtension => ".dll";

        // Fallback strings are used in case the resources file is unavailable.
        public static string CrashLogHeaderTextFormatFallback =>
            @"This text file was created because Paint.NET crashed.
Please e-mail this file to {0} so we can diagnose and fix the problem.
";

        public static string StartupUnhandledErrorFormatFallback =>
            "There was an unhandled error, and Paint.NET must be closed. Refer to the file '{0}', which has been placed on your desktop, for more information.";

        public static string SingleInstanceMonikerName => AppSettings.GetSetting();
    }
}
