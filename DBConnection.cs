using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Menu_Item_CRUD_with_SQLite
{
    public class DBConnection
    {
        public SQLiteConnection cn = new SQLiteConnection("Data Source=cafepos.db;Version = 3;");
    }
}
