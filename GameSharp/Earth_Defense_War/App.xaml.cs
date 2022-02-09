//    Copyright (C) <2022>  <小莕菜>
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
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
