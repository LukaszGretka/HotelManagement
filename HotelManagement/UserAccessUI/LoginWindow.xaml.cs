﻿using HotelManagmentLogic.LoginScreenLogic;
using HotelManagmentLogic.LoginScreenLogic.UserAccessActionResults;
using System.Windows;

namespace HotelManagement.UserAccessUI
{
    public partial class LoginWindow : Window
    {
        WindowsManagement windowsManagement;
        UserLogin userLogin;

        public LoginWindow()
        {
            InitializeComponent();
            windowsManagement = new WindowsManagement(this);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            userLogin = new UserLogin();

            LoginResult loginResult = userLogin.Login(this.UserTextBox.Text, this.UserPasswordTextBox.Password);
            MessageBox.Show(loginResult.UserAccessActionMessage);

            if (loginResult.UserAccessActionStatus)
            {
                PrecedeToMainWindow();
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            WindowsManagement.loginWindow.Hide();
            WindowsManagement.registrationWindow.Show();
        }

        private void ForceLogin_Click(object sender, RoutedEventArgs e)
        {
            PrecedeToMainWindow();
        }

        private void PrecedeToMainWindow()
        {
            WindowsManagement.loginWindow.Close();
            WindowsManagement.mainWindow.Show();
        }
    }
}