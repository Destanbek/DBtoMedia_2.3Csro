// Decompiled with JetBrains decompiler
// Type: Textdata.dep
// Assembly: _DBtoMedia_2.2, Version=2.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: EF99324B-9CC0-46C0-90FE-0C0236793599
// Assembly location: C:\Users\Admin\Desktop\silkroad deneme\6-DbToMedia_Csro-R\_DBtoMedia_2.2.exe

using Decrypter;
using sql;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Textdata
{
  internal class dep
  {
    private StreamWriter file;

    public void openTxt(string src) => this.file = new StreamWriter("Media/" + src, true, Encoding.Unicode);

    public void closeTxt() => this.file.Close();

    public void txtWrite(string str, bool line)
    {
      if (!line)
        this.file.Write(str + "\t");
      else
        this.file.WriteLine(str);
    }

    public void txtClear(string src)
    {
      for (int index = 0; index < 51; ++index)
        new FileInfo("Media/" + src).Delete();
    }

    public void getAndWrite(string query)
    {
      SqlDataReader sqlDataReader = new sqlClass().query(query);
      do
      {
        int fieldCount = sqlDataReader.FieldCount;
        while (sqlDataReader.Read())
        {
          for (int ordinal = 0; ordinal < fieldCount; ++ordinal)
            this.txtWrite(sqlDataReader.GetValue(ordinal).ToString(), false);
          this.txtWrite("", true);
        }
      }
      while (sqlDataReader.NextResult());
    }

    private void writeBytes(string file, byte[] array)
    {
      try
      {
        byte[] buffer = new byte[22]
        {
          (byte) 13,
          (byte) 0,
          (byte) 10,
          (byte) 0,
          (byte) 47,
          (byte) 0,
          (byte) 47,
          (byte) 0,
          (byte) 101,
          (byte) 0,
          (byte) 110,
          (byte) 0,
          (byte) 99,
          (byte) 0,
          (byte) 114,
          (byte) 0,
          (byte) 121,
          (byte) 0,
          (byte) 112,
          (byte) 0,
          (byte) 116,
          (byte) 0
        };
        using (FileStream fileStream = new FileStream("Media/" + file, FileMode.Append))
        {
          fileStream.Write(array, 0, array.Length);
          fileStream.Write(buffer, 0, buffer.Length);
          Console.WriteLine("Media/" + file);
          fileStream.Close();
        }
      }
      catch
      {
        Console.WriteLine("Cant encode");
      }
    }

    public bool skillDataENC()
    {
      byte[] array1 = new byte[4]
      {
        (byte) 71,
        (byte) 79,
        (byte) 145,
        (byte) 242
      };
      byte[] array2 = new byte[4]
      {
        (byte) 130,
        (byte) 213,
        (byte) 18,
        (byte) 127
      };
      byte[] array3 = new byte[4]
      {
        (byte) 120,
        (byte) 135,
        (byte) 206,
        (byte) 107
      };
      byte[] array4 = new byte[4]
      {
        (byte) 17,
        (byte) 90,
        (byte) 86,
        (byte) 93
      };
      byte[] array5 = new byte[4]
      {
        (byte) 18,
        (byte) 51,
        (byte) 15,
        (byte) 93
      };
      byte[] array6 = new byte[4]
      {
        (byte) 110,
        (byte) 89,
        (byte) 92,
        (byte) 191
      };
      byte[] array7 = new byte[4]
      {
        (byte) 105,
        (byte) 242,
        (byte) 165,
        (byte) 49
      };
      try
      {
        Decrypt decrypt = new Decrypt();
        decrypt.ReadAndDecryptFile("Media\\skilldata_5000.txt");
        decrypt.SaveFile("Media\\\\skilldata_5000enc.txt");
        this.writeBytes("skilldata_5000enc.txt", array1);
        decrypt.ReadAndDecryptFile("Media\\skilldata_10000.txt");
        decrypt.SaveFile("Media\\\\skilldata_10000enc.txt");
        this.writeBytes("skilldata_10000enc.txt", array2);
        decrypt.ReadAndDecryptFile("Media\\skilldata_15000.txt");
        decrypt.SaveFile("Media\\\\skilldata_15000enc.txt");
        this.writeBytes("skilldata_15000enc.txt", array3);
        decrypt.ReadAndDecryptFile("Media\\skilldata_20000.txt");
        decrypt.SaveFile("Media\\\\skilldata_20000enc.txt");
        this.writeBytes("skilldata_20000enc.txt", array4);
        decrypt.ReadAndDecryptFile("Media\\skilldata_25000.txt");
        decrypt.SaveFile("Media\\\\skilldata_25000enc.txt");
        this.writeBytes("skilldata_25000enc.txt", array5);
        decrypt.ReadAndDecryptFile("Media\\skilldata_30000.txt");
        decrypt.SaveFile("Media\\\\skilldata_30000enc.txt");
        this.writeBytes("skilldata_30000enc.txt", array6);
        decrypt.ReadAndDecryptFile("Media\\skilldata_35000.txt");
        decrypt.SaveFile("Media\\\\skilldata_35000enc.txt");
        this.writeBytes("skilldata_35000enc.txt", array7);
        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}
