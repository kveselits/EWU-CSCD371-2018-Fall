using System;
using System.IO;

namespace Assignment7
{
    public class ResourceManagement : IDisposable
    {
        public StreamReader FileChecker { get; }
        public static int resources = 0;

        public ResourceManagement(string fileName)
        {
            FileChecker = new StreamReader(fileName);
            resources++;
        }
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                FileChecker?.Dispose();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);
            resources--;
        }
    }
}