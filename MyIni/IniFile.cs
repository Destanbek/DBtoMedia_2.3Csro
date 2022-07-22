// Decompiled with JetBrains decompiler
// Type: MyIni.IniFile
// Assembly: _DBtoMedia_2.2, Version=2.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: EF99324B-9CC0-46C0-90FE-0C0236793599
// Assembly location: C:\Users\Admin\Desktop\silkroad deneme\6-DbToMedia_Csro-R\_DBtoMedia_2.2.exe

using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace MyIni
{
  internal class IniFile
  {
    private string Path;
    private string EXE = Assembly.GetExecutingAssembly().GetName().Name;

    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(
      string Section,
      string Key,
      string Value,
      string FilePath);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(
      string Section,
      string Key,
      string Default,
      StringBuilder RetVal,
      int Size,
      string FilePath);

    public IniFile(string IniPath = null) => this.Path = new FileInfo(IniPath ?? this.EXE + ".ini").FullName.ToString();

    public string Read(string Key, string Section = null)
    {
      StringBuilder RetVal = new StringBuilder((int) byte.MaxValue);
      IniFile.GetPrivateProfileString(Section ?? this.EXE, Key, "", RetVal, (int) byte.MaxValue, this.Path);
      return RetVal.ToString();
    }

    public void Write(string Key, string Value, string Section = null) => IniFile.WritePrivateProfileString(Section ?? this.EXE, Key, Value, this.Path);

    public void DeleteKey(string Key, string Section = null) => this.Write(Key, (string) null, Section ?? this.EXE);

    public void DeleteSection(string Section = null) => this.Write((string) null, (string) null, Section ?? this.EXE);

    public bool KeyExists(string Key, string Section = null) => this.Read(Key, Section).Length > 0;

    public string getSetting(string Section, string Key) => new IniFile("settings.ini").Read(Section, Key);
  }
}
