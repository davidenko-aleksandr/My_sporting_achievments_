﻿using My_sporting_achievments.Models;
using My_sporting_achievments.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace My_sporting_achievments.ViewModels
{
    public class RegistrationPageViewModels : Registration, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public RegistratoinAsyncRepository registratoinAsyncRepository;
        //private string _userName;
        //private string _login;
        //private string _password;


        


        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
