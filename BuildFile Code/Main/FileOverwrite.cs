using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildFile.Main
{
    internal class FileOverwrite
    {
        public static void Overwrite(string file, string? write, FileMode mode) {
            if (write == "") return;
            FileStream fs = new(file, mode);
            StreamWriter writer = new(fs);
            writer.WriteLine(write);
            writer.Close();
        }
        public static void TailwindConfigOverwrite(string path) =>
                        Overwrite(path, "/** @type {import('tailwindcss').Config} */\r\n" +
                                 "module.exports = {\r\n  " +
                                    "content: [\"./src/**/*.{html,js}\"],\r\n  " +
                                     "theme: {\r\n    " +
                                       "extend: {},\r\n  },\r\n  " +
                                       "plugins: [],\r\n}"
                                 , FileMode.Create);
    }

  
}
