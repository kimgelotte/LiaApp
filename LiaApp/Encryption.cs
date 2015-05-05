using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LiaApp
{
    class Encryption
    {
        public static void ToggleConfigEncryption(string exeConfigName)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(exeConfigName);

                ConnectionStringsSection section = (ConnectionStringsSection)config.GetSection("connectionStrings");

                if (section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.UnprotectSection();
                }
                else
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                config.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
