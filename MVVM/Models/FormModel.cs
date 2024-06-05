using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.MVVM.Models
{
    public class FormModel: INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Name)));
                NameError = "";
            }
        }

        private string email;
        public string Email
        {
            get => email;
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Email)));
                EmailError = "";
                if (!Helper.HelperUtility.IsEmailValid(Email))
                {
                    EmailError = "Please enter a valid email";
                }
                
            }
        }

        private string phone;
        public string Phone
        {
            get => phone;
            set
            {
                phone = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Phone)));
                PhoneError = "";
            }
        }

        private string comments;
        public string Comments
        {
            get => comments;
            set
            {
                comments = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Comments)));
            }
        }


        private string nameError;
        public string NameError
        {
            get => nameError;
            set
            {
                nameError = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(NameError)));
            }
        }

        private string emailError;
        public string EmailError
        {
            get => emailError;
            set
            {
                emailError = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(EmailError)));
            }
        }

        private string phoneError;
        public string PhoneError
        {
            get => phoneError;
            set
            {
                phoneError = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(PhoneError)));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
