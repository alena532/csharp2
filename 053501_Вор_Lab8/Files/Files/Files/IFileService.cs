using System;
using System.Collections;
using System.Collections.Generic;

namespace Files
{
    public interface IFileService
    {
        IEnumerable <Employee> ReadFile(string fileName);
        void SaveData(IEnumerable<Employee> data, string fileName);
    }
}
