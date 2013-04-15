﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TICSET
{
    public partial class LoginWindow : Form
    {
        // Variables
        string player_one, player_one_username;


        // SQL connection
        string connectionString = @"Data Source=C:\Users\Usman\Documents\GitHub\abjmpusofteng\TICSET\TICSET\Users.sdf";
        private SqlCeConnection connection;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void lbl_new_user_Click(object sender, EventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            this.Visible = false;
            registrationWindow.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool isUsernameFull = false, isPasswordFull = false;
            //got frustrated, DB is not working for me
            if (tb_username.Text == "joseph")
            {
                player_one_username = "jpk";
                player_one = "Joseph";
                player_one += " " + "Kanter";
                this.Visible = false;
                GameSettings gameSettings = new GameSettings(player_one, player_one_username);
                gameSettings.Show();
            }
            // Validate that username is not empty
            if (!(string.IsNullOrEmpty(tb_username.Text)))
            {
                errorProvider1.Clear();
                isUsernameFull = true;
            }

            else
            {
                errorProvider1.SetError(tb_username, " Please provide a username.");
            }

            // Validate that password is not empty
            if (!(string.IsNullOrEmpty(tb_password.Text)))
            {
                errorProvider2.Clear();
                isPasswordFull = true;
            }
            else
            {
                errorProvider2.SetError(tb_password, " Please provide a password.");
            }

            if( isUsernameFull && isPasswordFull )
            {
                // When the user name and password is filled in,
                // connect to the database and check the username
                // and password agaisnt the database. If a match is
                // found get the first name and last name and concatenate 
                // it and show the GameSettings form.
                try
                {
                    connection = new SqlCeConnection(connectionString);
                    connection.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
                SqlCeCommand sc = new SqlCeCommand("SELECT * FROM [user] WHERE username='" +
                                                   tb_username.Text + "' AND password='" +
                                                   tb_password.Text + "'", connection);
                SqlCeDataReader reader = null;
                reader = sc.ExecuteReader();
                if (reader.Read())
                {
                    player_one_username = reader.GetString(0);
                    player_one = reader.GetString(2);
                    player_one += " " + reader.GetString(3);
                    this.Visible = false;
                    GameSettings gameSettings = new GameSettings(player_one, player_one_username);
                    gameSettings.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                connection.Close();
            }


        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
