using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_III_ladder_analytics.Classes
{
    public static class AppSettings
    {
        public static string accountsFilePath = "";

        public static void RefreshAppSettings()
        {
            accountsFilePath = ApplicationSettings.Default.AccountsFilePath;
        }
    }
}
