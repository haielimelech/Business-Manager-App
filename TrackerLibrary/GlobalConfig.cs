using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TevelCampersUpdated.TrackerLibrary.DataAccess;

namespace TevelCampersUpdated.TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnector Connection { get; private set; }


        public static void InitializeConnections(DatabaseType db)
        {

            if (db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
