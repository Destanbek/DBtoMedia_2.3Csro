// Decompiled with JetBrains decompiler
// Type: sql.sqlClass
// Assembly: _DBtoMedia_2.2, Version=2.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: EF99324B-9CC0-46C0-90FE-0C0236793599
// Assembly location: C:\Users\Admin\Desktop\silkroad deneme\6-DbToMedia_Csro-R\_DBtoMedia_2.2.exe

using MyIni;
using System;
using System.Data.SqlClient;

namespace sql
{
  internal class sqlClass
  {
    private static SqlConnection Connect()
    {
      try
      {
        IniFile iniFile = new IniFile();
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + iniFile.getSetting("Host", "CONNECTION") + ";Initial Catalog=" + iniFile.getSetting("Db", "CONNECTION") + ";User ID=" + iniFile.getSetting("User", "CONNECTION") + ";Password=" + iniFile.getSetting("Pass", "CONNECTION"));
        sqlConnection.Open();
        return sqlConnection;
      }
      catch
      {
        Console.WriteLine("Cannot Connect! Check Settings.ini");
      }
      return new SqlConnection();
    }

    public SqlDataReader query(string q) => new SqlCommand(q, sqlClass.Connect()).ExecuteReader();
  }
}
