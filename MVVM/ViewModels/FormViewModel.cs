using MauiTestApp.Api;
using MauiTestApp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.MVVM.ViewModels
{
    public class FormViewModel
    {
        public FormModel model { get; set; }

        public Command SubmitCommand { get; }


        public FormViewModel()
        {
            model = new FormModel();
            SubmitCommand = new Command(OnSubmitFormClick);
        }

        public async void OnSubmitFormClick()
        {
            bool isError = false;
            model.NameError = "";
            model.EmailError = "";
            model.PhoneError = "";

            if (string.IsNullOrEmpty(model.Name))
            {
                model.NameError = "Please enter your name";
                isError = true;
            }
            if (string.IsNullOrEmpty(model.Email))
            {
                model.EmailError = "Please enter your email";
                isError = true;
            }
            if (string.IsNullOrEmpty(model.Phone))
            {
                model.PhoneError = "Please enter your phone";
                isError = true;
            }
            if (isError == false)
            {
                var result = await LoginService.LoginCheck(model.Email);
                if (result)
                {
                    model.EmailError = "Email address is already exists!";
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Success", "Form submitted successfully", "OK");
                }
            }
            // Do something with the form data
        }
    }
}
