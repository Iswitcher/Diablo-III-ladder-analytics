using System.IO;
using Diablo_III_ladder_analytics.Classes;

namespace Diablo_III_ladder_analytics
{
    static class AccountController
    {
        static bool CheckAccountsFileExists()
        {
            string filePath = AppSettings.accountsFilePath;

            if (File.Exists(filePath))
            {
                return true;
            }
            return false;
        }
    }
}
