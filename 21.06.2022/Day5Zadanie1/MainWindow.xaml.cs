﻿using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Day5Zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Directory.CreateDirectory("Folder_" + i);
                }
                l1.Content = "Папки появились";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Directory.Delete("Folder_" + i);
                }
                l1.Content = "Папок больше нет";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
