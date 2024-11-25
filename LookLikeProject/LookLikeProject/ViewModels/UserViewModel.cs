﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using LookLikeProject.Models;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.Input;

namespace LookLikeProject.ViewModels
{
    public partial class UserViewModel:ObservableObject
    {
        [ObservableProperty]
        private User _user;

        [ObservableProperty]
        private User _student = new User();
        public UserViewModel()
        {
            User.Szuldatum = DateTime.Now.AddYears(-14);
        }

        [RelayCommand]
        public void DoSave(User user)
        {
            User.Add(user);
            User = new User();
            User.Szuldatum = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(User));
        }

        [RelayCommand]
        public void DoNewStudent()
        {
            User = new User();
            User.Szuldatum = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(User));
        }

        [RelayCommand]
        public void DoDelete(User user)
        {
            User.Remove(user);
            User = new User();
            User.Szuldatum = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(User));
        }
    }
}
