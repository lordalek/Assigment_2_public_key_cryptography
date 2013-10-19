using System;
using System.IO;

namespace Assigment2.Logic
{
    public static class Helper
    {
        public static RsaInfo GetCryptionInfo(string path)
        {
            if (string.IsNullOrEmpty(path))
                return new RsaInfo();

            var cryptionInfo = new RsaInfo();
            path = Path.Combine(path, "RSAInfo.xml");
            if (!File.Exists(path))
                return cryptionInfo;
            cryptionInfo.Load(path);
            return cryptionInfo;
        }

        public static void SaveCryptionInfo(RsaInfo info, string path)
        {
            if (info == null) throw new ArgumentNullException("info");
            if (string.IsNullOrEmpty(path)) throw new ArgumentException("path");
            info.Save(Path.Combine(path, "RSAInfo.xml"));
        }
    }
}