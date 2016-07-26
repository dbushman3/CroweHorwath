using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace API.Classes
{
    abstract class clsDB
    {
        private string m_strConn;

        public clsDB()
        {
            this.m_strConn = ConfigurationManager.ConnectionStrings["MsSQLDBConnection"].ConnectionString;
            //Code to set up database connection goes here.
        }

        public clsDB(string connString)
        {
            this.m_strConn = connString;
            //Code to set up database connection goes here.
        }
        
        abstract public void OpenConnection();
        abstract public void CloseConnection();
        abstract public long Execute(string SQL);
    }
}