using System;
using System.IO;
using System.Runtime.InteropServices;
using Urho;

namespace MyUrhoGame.Desktop
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string dllToLoad);

        static void Main(string[] args)
        {
            var assmLocation = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            var monoUrhoPath = Path.Combine(assmLocation, "Win64_OpenGL", "mono-urho.dll");
            _ = LoadLibrary(monoUrhoPath);

            var options = new ApplicationOptions()
            {
                ResourcePrefixPaths = new[] { assmLocation },
                ResourcePaths = new[] { "MyData" }
            };
            new MyGame(options).Run();
        }
    }
}
