﻿// Decompiled with JetBrains decompiler
// Type: Decrypter.Decrypt
// Assembly: _DBtoMedia_2.2, Version=2.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: EF99324B-9CC0-46C0-90FE-0C0236793599
// Assembly location: C:\Users\Admin\Desktop\silkroad deneme\6-DbToMedia_Csro-R\_DBtoMedia_2.2.exe

using System;
using System.IO;
using System.Text;

namespace Decrypter
{
  internal class Decrypt
  {
    private byte[] Hash_Table_1 = new byte[256]
    {
      (byte) 7,
      (byte) 131,
      (byte) 188,
      (byte) 238,
      (byte) 75,
      (byte) 121,
      (byte) 25,
      (byte) 182,
      (byte) 42,
      (byte) 83,
      (byte) 79,
      (byte) 58,
      (byte) 207,
      (byte) 113,
      (byte) 229,
      (byte) 60,
      (byte) 45,
      (byte) 24,
      (byte) 20,
      (byte) 203,
      (byte) 182,
      (byte) 188,
      (byte) 170,
      (byte) 154,
      (byte) 49,
      (byte) 66,
      (byte) 58,
      (byte) 19,
      (byte) 66,
      (byte) 201,
      (byte) 99,
      (byte) 252,
      (byte) 84,
      (byte) 29,
      (byte) 242,
      (byte) 193,
      (byte) 138,
      (byte) 221,
      (byte) 28,
      (byte) 179,
      (byte) 82,
      (byte) 234,
      (byte) 155,
      (byte) 215,
      (byte) 196,
      (byte) 186,
      (byte) 248,
      (byte) 18,
      (byte) 116,
      (byte) 146,
      (byte) 48,
      (byte) 201,
      (byte) 214,
      (byte) 86,
      (byte) 21,
      (byte) 82,
      (byte) 83,
      (byte) 96,
      (byte) 17,
      (byte) 51,
      (byte) 197,
      (byte) 157,
      (byte) 48,
      (byte) 154,
      (byte) 229,
      (byte) 210,
      (byte) 147,
      (byte) 153,
      (byte) 235,
      (byte) 207,
      (byte) 170,
      (byte) 121,
      (byte) 227,
      (byte) 120,
      (byte) 106,
      (byte) 185,
      (byte) 2,
      (byte) 224,
      (byte) 206,
      (byte) 142,
      (byte) 243,
      (byte) 99,
      (byte) 90,
      (byte) 115,
      (byte) 116,
      (byte) 243,
      (byte) 114,
      (byte) 170,
      (byte) 44,
      (byte) 159,
      (byte) 187,
      (byte) 51,
      (byte) 145,
      (byte) 222,
      (byte) 95,
      (byte) 145,
      (byte) 102,
      (byte) 72,
      (byte) 209,
      (byte) 122,
      (byte) 253,
      (byte) 63,
      (byte) 145,
      (byte) 62,
      (byte) 93,
      (byte) 34,
      (byte) 236,
      (byte) 239,
      (byte) 124,
      (byte) 165,
      (byte) 67,
      (byte) 192,
      (byte) 29,
      (byte) 79,
      (byte) 96,
      (byte) 127,
      (byte) 11,
      (byte) 74,
      (byte) 75,
      (byte) 42,
      (byte) 67,
      (byte) 6,
      (byte) 70,
      (byte) 20,
      (byte) 69,
      (byte) 208,
      (byte) 197,
      (byte) 131,
      (byte) 146,
      (byte) 228,
      (byte) 22,
      (byte) 208,
      (byte) 163,
      (byte) 161,
      (byte) 19,
      (byte) 218,
      (byte) 209,
      (byte) 81,
      (byte) 7,
      (byte) 235,
      (byte) 125,
      (byte) 206,
      (byte) 165,
      (byte) 219,
      (byte) 120,
      (byte) 224,
      (byte) 193,
      (byte) 11,
      (byte) 229,
      (byte) 142,
      (byte) 28,
      (byte) 124,
      (byte) 180,
      (byte) 223,
      (byte) 237,
      (byte) 184,
      (byte) 83,
      (byte) 186,
      (byte) 44,
      (byte) 181,
      (byte) 187,
      (byte) 86,
      (byte) 251,
      (byte) 104,
      (byte) 149,
      (byte) 110,
      (byte) 101,
      (byte) 0,
      (byte) 96,
      (byte) 186,
      (byte) 227,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 156,
      (byte) 181,
      (byte) 213,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 46,
      (byte) 63,
      (byte) 65,
      (byte) 86,
      (byte) 67,
      (byte) 69,
      (byte) 83,
      (byte) 99,
      (byte) 114,
      (byte) 105,
      (byte) 112,
      (byte) 116,
      (byte) 64,
      (byte) 64,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 100,
      (byte) 187,
      (byte) 227,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private byte[] Hash_Table_2 = new byte[496]
    {
      (byte) 13,
      (byte) 5,
      (byte) 144,
      (byte) 65,
      (byte) 249,
      (byte) 208,
      (byte) 101,
      (byte) 191,
      (byte) 249,
      (byte) 11,
      (byte) 21,
      (byte) 147,
      (byte) 128,
      (byte) 251,
      (byte) 1,
      (byte) 2,
      (byte) 182,
      (byte) 8,
      (byte) 196,
      (byte) 60,
      (byte) 193,
      (byte) 73,
      (byte) 148,
      (byte) 77,
      (byte) 206,
      (byte) 29,
      (byte) 253,
      (byte) 105,
      (byte) 234,
      (byte) 25,
      (byte) 201,
      (byte) 87,
      (byte) 156,
      (byte) 77,
      (byte) 132,
      (byte) 98,
      (byte) 227,
      (byte) 103,
      (byte) 249,
      (byte) 135,
      (byte) 244,
      (byte) 249,
      (byte) 147,
      (byte) 218,
      (byte) 229,
      (byte) 21,
      (byte) 241,
      (byte) 76,
      (byte) 164,
      (byte) 236,
      (byte) 188,
      (byte) 207,
      (byte) 221,
      (byte) 179,
      (byte) 111,
      (byte) 4,
      (byte) 61,
      (byte) 112,
      (byte) 28,
      (byte) 116,
      (byte) 33,
      (byte) 107,
      (byte) 0,
      (byte) 113,
      (byte) 49,
      (byte) 127,
      (byte) 84,
      (byte) 179,
      (byte) 114,
      (byte) 108,
      (byte) 170,
      (byte) 66,
      (byte) 193,
      (byte) 120,
      (byte) 97,
      (byte) 62,
      (byte) 213,
      (byte) 242,
      (byte) 225,
      (byte) 39,
      (byte) 54,
      (byte) 113,
      (byte) 58,
      (byte) 37,
      (byte) 54,
      (byte) 87,
      (byte) 209,
      (byte) 248,
      (byte) 112,
      (byte) 134,
      (byte) 189,
      (byte) 14,
      (byte) 88,
      (byte) 179,
      (byte) 118,
      (byte) 109,
      (byte) 195,
      (byte) 80,
      (byte) 246,
      (byte) 108,
      (byte) 160,
      (byte) 16,
      (byte) 6,
      (byte) 100,
      (byte) 162,
      (byte) 214,
      (byte) 44,
      (byte) 212,
      (byte) 39,
      (byte) 48,
      (byte) 165,
      (byte) 54,
      (byte) 28,
      (byte) 30,
      (byte) 62,
      (byte) 88,
      (byte) 157,
      (byte) 89,
      (byte) 118,
      (byte) 157,
      (byte) 167,
      (byte) 66,
      (byte) 90,
      (byte) 240,
      (byte) 0,
      (byte) 188,
      (byte) 105,
      (byte) 49,
      (byte) 64,
      (byte) 30,
      (byte) 250,
      (byte) 9,
      (byte) 29,
      (byte) 231,
      (byte) 238,
      (byte) 228,
      (byte) 84,
      (byte) 137,
      (byte) 54,
      (byte) 124,
      (byte) 103,
      (byte) 200,
      (byte) 101,
      (byte) 34,
      (byte) 126,
      (byte) 163,
      (byte) 96,
      (byte) 68,
      (byte) 30,
      (byte) 188,
      (byte) 104,
      (byte) 111,
      (byte) 21,
      (byte) 42,
      (byte) 253,
      (byte) 157,
      (byte) 63,
      (byte) 54,
      (byte) 107,
      (byte) 40,
      (byte) 6,
      (byte) 103,
      (byte) 254,
      (byte) 198,
      (byte) 73,
      (byte) 107,
      (byte) 155,
      (byte) 63,
      (byte) 128,
      (byte) 42,
      (byte) 210,
      (byte) 212,
      (byte) 211,
      (byte) 32,
      (byte) 27,
      (byte) 150,
      (byte) 244,
      (byte) 210,
      (byte) 202,
      (byte) 140,
      (byte) 116,
      (byte) 238,
      (byte) 11,
      (byte) 106,
      (byte) 225,
      (byte) 233,
      (byte) 198,
      (byte) 210,
      (byte) 110,
      (byte) 51,
      (byte) 99,
      (byte) 192,
      (byte) 233,
      (byte) 208,
      (byte) 55,
      (byte) 169,
      (byte) 60,
      (byte) 247,
      (byte) 24,
      (byte) 242,
      (byte) 74,
      (byte) 116,
      (byte) 236,
      (byte) 65,
      (byte) 97,
      (byte) 122,
      (byte) 25,
      (byte) 71,
      (byte) 143,
      (byte) 160,
      (byte) 187,
      (byte) 148,
      (byte) 143,
      (byte) 61,
      (byte) 17,
      (byte) 17,
      (byte) 38,
      (byte) 207,
      (byte) 105,
      (byte) 24,
      (byte) 27,
      (byte) 44,
      (byte) 135,
      (byte) 109,
      (byte) 179,
      (byte) 34,
      (byte) 108,
      (byte) 120,
      (byte) 65,
      (byte) 204,
      (byte) 194,
      (byte) 132,
      (byte) 197,
      (byte) 203,
      (byte) 1,
      (byte) 106,
      (byte) 55,
      (byte) 0,
      (byte) 1,
      (byte) 101,
      (byte) 79,
      (byte) 167,
      (byte) 133,
      (byte) 133,
      (byte) 21,
      (byte) 89,
      (byte) 5,
      (byte) 103,
      (byte) 242,
      (byte) 79,
      (byte) 171,
      (byte) 183,
      (byte) 136,
      (byte) 250,
      (byte) 105,
      (byte) 36,
      (byte) 158,
      (byte) 198,
      (byte) 123,
      (byte) 63,
      (byte) 213,
      (byte) 14,
      (byte) 77,
      (byte) 123,
      (byte) 251,
      (byte) 177,
      (byte) 33,
      (byte) 60,
      (byte) 176,
      (byte) 192,
      (byte) 203,
      (byte) 44,
      (byte) 170,
      (byte) 38,
      (byte) 141,
      (byte) 204,
      (byte) 221,
      (byte) 218,
      (byte) 193,
      (byte) 248,
      (byte) 202,
      (byte) 127,
      (byte) 106,
      (byte) 63,
      (byte) 42,
      (byte) 97,
      (byte) 231,
      (byte) 96,
      (byte) 92,
      (byte) 206,
      (byte) 211,
      (byte) 76,
      (byte) 172,
      (byte) 69,
      (byte) 64,
      (byte) 98,
      (byte) 234,
      (byte) 81,
      (byte) 241,
      (byte) 102,
      (byte) 93,
      (byte) 44,
      (byte) 69,
      (byte) 214,
      (byte) 139,
      (byte) 125,
      (byte) 206,
      (byte) 156,
      (byte) 245,
      (byte) 187,
      (byte) 247,
      (byte) 82,
      (byte) 36,
      (byte) 26,
      (byte) 19,
      (byte) 2,
      (byte) 43,
      (byte) 0,
      (byte) 187,
      (byte) 161,
      (byte) 143,
      (byte) 110,
      (byte) 122,
      (byte) 51,
      (byte) 173,
      (byte) 95,
      (byte) 244,
      (byte) 74,
      (byte) 130,
      (byte) 118,
      (byte) 171,
      (byte) 222,
      (byte) 128,
      (byte) 152,
      (byte) 139,
      (byte) 38,
      (byte) 79,
      (byte) 51,
      (byte) 216,
      (byte) 104,
      (byte) 30,
      (byte) 217,
      (byte) 174,
      (byte) 6,
      (byte) 107,
      (byte) 126,
      (byte) 169,
      (byte) 149,
      (byte) 103,
      (byte) 96,
      (byte) 235,
      (byte) 232,
      (byte) 208,
      (byte) 125,
      (byte) 7,
      (byte) 75,
      (byte) 241,
      (byte) 170,
      (byte) 154,
      (byte) 197,
      (byte) 41,
      (byte) 147,
      (byte) 157,
      (byte) 92,
      (byte) 146,
      (byte) 63,
      (byte) 21,
      (byte) 222,
      (byte) 72,
      (byte) 241,
      (byte) 202,
      (byte) 234,
      (byte) 201,
      (byte) 120,
      (byte) 60,
      (byte) 40,
      (byte) 126,
      (byte) 176,
      (byte) 70,
      (byte) 211,
      (byte) 113,
      (byte) 108,
      (byte) 215,
      (byte) 189,
      (byte) 44,
      (byte) 247,
      (byte) 37,
      (byte) 47,
      (byte) 199,
      (byte) 221,
      (byte) 180,
      (byte) 109,
      (byte) 53,
      (byte) 187,
      (byte) 167,
      (byte) 218,
      (byte) 62,
      (byte) 61,
      (byte) 167,
      (byte) 202,
      (byte) 189,
      (byte) 135,
      (byte) 221,
      (byte) 159,
      (byte) 34,
      (byte) 61,
      (byte) 80,
      (byte) 210,
      (byte) 48,
      (byte) 213,
      (byte) 20,
      (byte) 91,
      (byte) 143,
      (byte) 244,
      (byte) 175,
      (byte) 170,
      (byte) 160,
      (byte) 252,
      (byte) 23,
      (byte) 61,
      (byte) 51,
      (byte) 16,
      (byte) 153,
      (byte) 220,
      (byte) 118,
      (byte) 169,
      (byte) 64,
      (byte) 27,
      (byte) 100,
      (byte) 20,
      (byte) 223,
      (byte) 53,
      (byte) 104,
      (byte) 102,
      (byte) 91,
      (byte) 73,
      (byte) 5,
      (byte) 51,
      (byte) 104,
      (byte) 38,
      (byte) 200,
      (byte) 186,
      (byte) 209,
      (byte) 141,
      (byte) 57,
      (byte) 43,
      (byte) 251,
      (byte) 62,
      (byte) 36,
      (byte) 82,
      (byte) 47,
      (byte) 154,
      (byte) 105,
      (byte) 188,
      (byte) 242,
      (byte) 178,
      (byte) 172,
      (byte) 184,
      (byte) 239,
      (byte) 161,
      (byte) 23,
      (byte) 41,
      (byte) 45,
      (byte) 238,
      (byte) 245,
      (byte) 35,
      (byte) 33,
      (byte) 236,
      (byte) 129,
      (byte) 199,
      (byte) 91,
      (byte) 192,
      (byte) 130,
      (byte) 204,
      (byte) 210,
      (byte) 145,
      (byte) 157,
      (byte) 41,
      (byte) 147,
      (byte) 12,
      (byte) 157,
      (byte) 93,
      (byte) 87,
      (byte) 173,
      (byte) 212,
      (byte) 198,
      (byte) 64,
      (byte) 147,
      (byte) 141,
      (byte) 233,
      (byte) 211,
      (byte) 53,
      (byte) 157,
      (byte) 198,
      (byte) 211,
      (byte) 0
    };
    private uint key;
    private bool Encrypted;
    private byte[] buffer;

    public Decrypt()
    {
      this.Encrypted = false;
      this.key = 35871U;
    }

    public void ReadAndDecryptFile(string FilePath)
    {
      try
      {
        using (BinaryReader binaryReader = new BinaryReader((Stream) File.Open(FilePath, FileMode.Open), Encoding.Unicode))
        {
          this.key = 35871U;
          long length = binaryReader.BaseStream.Length;
          this.buffer = new byte[length + 1L];
          try
          {
            this.buffer = binaryReader.ReadBytes((int) length);
          }
          catch (Exception ex)
          {
            Console.WriteLine("Out of memory!\n");
          }
          if (this.buffer[0] == (byte) 226 && this.buffer[1] == (byte) 176)
            this.Encrypted = true;
          for (int index = 0; (long) index < length; ++index)
          {
            byte num = (byte) ((uint) this.Hash_Table_1[(int) (this.key % 167U)] - (uint) this.Hash_Table_2[(int) (this.key % 495U)]);
            ++this.key;
            if (this.Encrypted)
              this.buffer[index] += num;
            else
              this.buffer[index] -= num;
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    public void SaveFile(string OutputPath) => File.WriteAllBytes(OutputPath, this.buffer);
  }
}
