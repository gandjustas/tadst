using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace TADST
{
    [Serializable]
    sealed class Mod: IEquatable<Mod>
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public bool IsChecked { get; set; }

        public ModSource Source { get; set; }

        public bool Equals(Mod other)
        {
            return other == null ? false : (this.Source == other.Source && this.Path == other.Path);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Mod);
        }

        public override int GetHashCode()
        {
            return this.Source.GetHashCode() ^ this.Path.GetHashCode();
        }
        public override string ToString()
        {
            return Name;
        }
        public static string GetModName(string path)
        {
            var meta = System.IO.Path.Combine(path, "meta.cpp");
            if (!File.Exists(meta)) return System.IO.Path.GetFileName(path);

            foreach (var line in File.ReadLines(meta))
            {
                var p = line.Split('=', ';');
                if (p.Length == 2 && p[0].Trim() == "name")
                {
                    return p[1].Trim('\"');
                }
            }
            return System.IO.Path.GetFileName(path);
        }

        public static bool IsModDir(string directory)
        {
            var addons = System.IO.Path.Combine(directory, "addons");
            return Directory.Exists(addons) && Directory.EnumerateFiles(addons, "*.?bo").Any();
        }
    }

    enum ModSource
    {
        GameDir = 0,
        Steam = 1,
        Custom = 2,
    }
}
