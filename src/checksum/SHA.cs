using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace checksum
{
    public class SHA
    {
        public static string SHA1(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                using (BufferedStream bs = new BufferedStream(fs))
                using (SHA1Managed sha = new SHA1Managed())
                {
                    var comp = sha.ComputeHash(bs);
                    var hash = new StringBuilder(comp.Length * 2);

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
        public static string SHA256(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                using (BufferedStream bs = new BufferedStream(fs))
                using (SHA256Managed sha = new SHA256Managed())
                {
                    var comp = sha.ComputeHash(bs);
                    var hash = new StringBuilder(comp.Length * 2);

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
        public static string SHA512(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                using (BufferedStream bs = new BufferedStream(fs))
                using (SHA512Managed sha = new SHA512Managed())
                {
                    var comp = sha.ComputeHash(bs);
                    var hash = new StringBuilder(comp.Length * 2);

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