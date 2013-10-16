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
            cryptionInfo.Load(Path.Combine(path, "RSAInfo.xml"));
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