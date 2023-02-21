using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsUtility
{
    public class FilePath
    {
        private static string? path { get; set; }
        private static string? directory { get; set; }
        public static bool FileAlreadyExist()
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool FileAlreadyExist(String filePath)
        {
            if (File.Exists(filePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void DeleteFile(String filePath)
        {
            if (filePath != null || File.Exists(filePath))
            {
                File.Delete(filePath);
            }

        }
        public static void DeleteFile()
        {
            if (path != null || File.Exists(path))
            {
                File.Delete(path);
            }

        }

        public static string FilePathName {
            get { return path; }
            set { path = value; }
        }

        public static void CreateDirectory(String directoryName)
        {
            if (!Directory.Exists(directoryName)) Directory.CreateDirectory(directoryName);
        }

        public static string? DirectoryPath
        {
            get
            {
                if(path !=null) return Path.GetDirectoryName(path);
                return null;
            }
        }

        public static string baseDirectory
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
    }

}
