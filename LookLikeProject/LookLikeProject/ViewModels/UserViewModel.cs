using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using LookLikeProject.Models;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace LookLikeProject.ViewModels
{
    public partial class UserViewModel:ObservableObject
    {
        [ObservableProperty]
        private User _user=;

        [ObservableProperty]
        private List<User> _users = 

        public UserViewModel()
        {
            User.Szuldatum = DateTime.Now.AddYears(-14);
        }

        [ObservableProperty]
        private ObservableCollection<User> _users = new ObservableCollection<User>();

        [RelayCommand]
        public void DoSave(User user)
        {
            Users.Add(user);
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
            Users.Remove(user);
            User = new User();
            User.Szuldatum = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(User));
        }
    }
}
