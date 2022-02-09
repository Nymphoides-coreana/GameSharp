using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Earth_Defense_War
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static App GetApp()
        {
            return (App)Current;
        }
        public const string GameTitle = "Earth Defense War 地球防卫战";

        public const string VersionInfo = "Earth Defense War 地球防卫战 2.0\n2022年制造";

        public int Height { get; set; } = 700;
        public int Width { get; set; } = 500;
    }
}
