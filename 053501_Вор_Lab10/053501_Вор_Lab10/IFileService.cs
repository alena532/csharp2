using System;
using System.Collections;
using System.Collections.Generic;
namespace _053501_Вор_Lab10
{
    public interface IFileService<T> where T : class
    {
        IEnumerable<T> ReadFile(string filename);
        void Savedata(IEnumerable<T> data, string filename);
    }
}
