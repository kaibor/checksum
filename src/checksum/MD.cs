using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace checksum
{
    public class MD
    {
        public static string MD5(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                using (BufferedStream bs = new BufferedStream(fs))
                using (var md5 = System.Security.Cryptography.MD5.Create())
                {
                    var comp = md5.ComputeHash(bs);
                    var hash = new StringBuilder();
                    foreach (byte b in comp)
                    {
                        hash.Append(b.ToString("X2"));
                    }
                    return hash.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
