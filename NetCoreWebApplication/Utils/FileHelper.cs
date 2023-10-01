﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace NetCoreWebApplication.Utils
{
    public class FileHelper
    {
        public static string FileLoader(IFormFile formFile, string filepath = "/Img/")
        {
            var fileName = "";

            if (formFile != null && formFile.Length > 0)
            {
                fileName = formFile.FileName;
                string directory = Directory.GetCurrentDirectory() + "/wwwroot" + filepath + fileName;
                using (var stream = new FileStream(directory, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }

            return fileName;
        }

        public static bool FileTerminator(string fileName, string filepath = "/Img/")
        {
            string deletedFile = Directory.GetCurrentDirectory() + "/wwwroot" + filepath + fileName;
            if (File.Exists(deletedFile))
            {
                File.Delete(deletedFile);
                return true;
            }
            return false;
        }
    }
}
