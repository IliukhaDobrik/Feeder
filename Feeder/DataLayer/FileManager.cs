﻿using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public sealed class FileManager : IFileManager
    {
        public Task<string> Read(string fileName)
        {
            ThrowIfNotExist(fileName);
            return File.ReadAllTextAsync(fileName);
        }

        public Task Write(string fileName, string text)
        {
            ThrowIfNotExist(fileName);
            return File.WriteAllTextAsync(fileName, text);
        }

        private static void ThrowIfNotExist(string path)
        {
            if (File.Exists(path) == false)
            {
                throw new FileNotFoundException(Path.GetFileName(path));
            }
        }
    }
}
