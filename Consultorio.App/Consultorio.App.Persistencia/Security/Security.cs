using System;
using System.Linq;
using System.Security.Cryptography;

namespace Consultorio.App.Persistencia{
public class Security{    
public string GetMD5Hash(string input)
{
   input += "claxo"+input.Reverse();

   MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
   byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
   bs = x.ComputeHash(bs);
   System.Text.StringBuilder s = new System.Text.StringBuilder();
   foreach (byte b in bs)
   {
      s.Append(b.ToString("x2").ToLower());
   }
   string hash = s.ToString();
   return hash;
}
}
}