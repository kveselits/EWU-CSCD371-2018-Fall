using System;

namespace UniversityCourse
{
    public interface IConsole
    {
        void Write(string line);

        void WriteLine(string line);

        string ReadLine();

        void Clear();
    }
}