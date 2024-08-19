using EntitySpaces.Interfaces;
using System;
using Wisej.Web;

namespace wisej_webapp_postgresql_net8
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            esDatabaseConfig();

            Window1 window = new Window1();
            window.Show();
        }

        private static void esDatabaseConfig()
        {
            // esDataProviderFactory is a one time setup 
            esProviderFactory.Factory = new EntitySpaces.Loader.esDataProviderFactory();


            // Add a connection
            esConnectionElement conn = new esConnectionElement();
            conn.Provider = "EntitySpaces.PostgreSQLClientProvider";

            string connectionString = "";

#if DEBUG
            //connectionString = configurationManagerWrapper.GetConnectionString("develop");
            connectionString = Application.Configuration.Settings.dbConnectionDevelop;

#else
            connectionString = Application.Configuration.Settings.dbConnectionProduction;

#endif
            conn.ConnectionString = connectionString;
            esConfigSettings.ConnectionInfo.Connections.Add(conn);
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    }
}