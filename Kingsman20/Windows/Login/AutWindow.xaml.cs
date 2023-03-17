﻿using Kingsman20.DB;
using System;
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
using System.Windows.Shapes;

namespace Kingsman20.Windows.Login
{
    /// <summary>
    /// Логика взаимодействия для AutWindow.xaml
    /// </summary>
    public partial class AutWindow : Window
    {
        public AutWindow()
        {
            InitializeComponent();

        }

        private void BtnSigIn_Click(object sender, RoutedEventArgs e)
        {


            var userAuth = ClassHelper.EF.Context.Staff.ToList().
                Where(i => i.Email == Login.Text && i.Password == Password.Text).
                FirstOrDefault();

            if (userAuth != null)
            {
                MainWindow serviceWindow = new MainWindow();                
                serviceWindow.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Пользователя не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
