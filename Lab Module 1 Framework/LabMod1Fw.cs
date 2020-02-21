using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Module_1_Framework
{
    class LabMod1Fw
    {
        static void Main(string[] args)
        {
           int price, tax;
           price = 10;

           ServiceConfiguration config = new ServiceConfiguration();

            var config = new ServiceConfiguration();
            // Invoke the LoadConfiguration method.
            var loadSuccessful = config.LoadConfiguration();
            // Get the value from the ApplicationName property.
            var applicationName = config.ApplicationName;
            // Set the .DatabaseServerName property.
            config.DatabaseServerName = "78.45.81.23";
            // Invoke the SaveConfiguration method.
            var saveSuccessful = config.SaveConfiguration();
        }
    }
}
