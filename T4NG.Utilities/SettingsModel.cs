using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4NG.Utilities
{
    public class SettingsModel
    {
        /// <summary>
        /// Connection for the database to access
        /// </summary>
        public string ConnectionString { get; set; }
        public string Database { get; set; }
        public ProjectModel EntityProject { get; set; }

        private void test()
        {
            var x = new System.Data.SqlClient.SqlConnection();
        }

    }

}
