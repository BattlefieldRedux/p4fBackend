using System.IO;

namespace BFP4FLauncherWV
{
    public static class BackendLog
    {
        public static string logFile = "_BackendLog.txt";
        public static void Clear()
        {
            if (File.Exists(logFile))
                File.Delete(logFile);
        }

        public static void Write(string s)
        {
            File.AppendAllText(logFile, s);
        }
    }
}
