﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;
namespace TiblerZone
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
