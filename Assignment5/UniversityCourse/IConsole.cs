using System;

namespace UniversityCourse
{
    public interface IConsole
    {
        void WriteLine(string line);

        string ReadLine();
    }
}