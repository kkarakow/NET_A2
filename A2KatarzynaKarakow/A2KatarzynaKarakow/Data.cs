using System;
using System.Collections.Generic;
using System.Text;

namespace A2KatarzynaKarakow
{
    class Data
    {
        private static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=WorldDB;Integrated Security=True";

        public static string ConnectionString { get => connStr; }
    }

}

