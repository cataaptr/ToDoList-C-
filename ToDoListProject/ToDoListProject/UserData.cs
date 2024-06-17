using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace ToDoListProject
{
    internal class UserData
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public UserData()
        {
        }

        public UserData(string fullName, string email, string phoneNumber)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public UserData(UserData other)
        {
            this.FullName = other.FullName;
            this.Email = other.Email;
            this.PhoneNumber = other.PhoneNumber;
        }

        public void openFileForReadUserData(ref UserData userData)
        {
            try
            {
                string filePath = @"C:\Users\HP\Desktop\1051_Apetroaei_Emanuela-Catalina\ToDoListProject\ToDoListProject\PersonalData.txt";

                if (File.Exists(filePath))
                {
                    string line = File.ReadAllText(filePath);
                    string[] parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        userData.FullName = parts[0];
                        userData.Email = parts[1];
                        userData.PhoneNumber = parts[2];
                    }
                    else
                    {
                        MessageBox.Show("Fisierul de configurare nu este formatat corect. Parts: ");
                    }
                }
                else
                {
                    MessageBox.Show("Fișierul de configurare nu există.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea din fisierul de configurare: " + ex.Message);
            }
        }

    }
}
