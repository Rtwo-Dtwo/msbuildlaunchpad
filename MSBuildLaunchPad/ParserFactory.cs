﻿using System.IO;

namespace Lextm.MSBuildLaunchPad
{
    public static class ParserFactory
    {
        public static IParser Parse(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            if (extension == ".sln")
            {
                return new SolutionParser(fileName);
            }

            if (extension == ".csproj" || extension == ".vbproj" || extension == ".vcxproj" || extension == ".oxygene" || extension == ".shfbproj")
            {
                return new MSBuildScriptParser(fileName);
            }

            return null;
        }
    }
}