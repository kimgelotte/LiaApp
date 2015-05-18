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
        public static void ToggleConfigEncryption()
        {
            
            string exe = Environment.GetCommandLineArgs()[0];
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(exe);

                ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;

                if (section.SectionInformation.IsProtected)

                {
                    section.SectionInformation.UnprotectSection();
                }
                else
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                config.Save();

                Console.WriteLine("Protected={0}", section.SectionInformation.IsProtected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
