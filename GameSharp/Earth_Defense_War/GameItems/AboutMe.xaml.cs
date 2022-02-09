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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Earth_Defense_War.GameItems
{
    /// <summary>
    /// AboutMe.xaml 的交互逻辑
    /// </summary>
    public partial class AboutMe : Window
    {
        public AboutMe()
        {
            InitializeComponent();

            using (Bitmap ms = new Bitmap(new MemoryStream(Properties.Resources.gplv3_with_text_136x68)))
            {
                BitmapImage myBitmapImage = new BitmapImage();

                myBitmapImage.BeginInit();
                myBitmapImage.StreamSource = new MemoryStream();
                ms.Save(myBitmapImage.StreamSource, ImageFormat.Png);
                myBitmapImage.EndInit();
                GPL_icon.Source = myBitmapImage;
            }

            Le.Text = @"    Copyright (C) <2022>  <小莕菜>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.";
            if (File.Exists("License"))
            {
                IAgree = true;
                YesBtn.Visibility = Visibility.Hidden;
                NoBtn.Visibility = Visibility.Hidden;
            }
            Closing += new System.ComponentModel.CancelEventHandler((obj, e) =>
            {
                AboutMe Win = (AboutMe)obj;
                if (!Win.IAgree)
                {
                    No(null, null);
                }
            });
        }

        public bool ISIAgree()
        {
            return IAgree;
        }

        private bool IAgree = false;

        private void No(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Yes(object sender, RoutedEventArgs e)
        {
            IAgree = true;
            using (StreamWriter sw = new StreamWriter(new FileStream("License", FileMode.OpenOrCreate)))
            {
                sw.Write(nameof(Yes));
            }
            Close();
        }
    }
}
