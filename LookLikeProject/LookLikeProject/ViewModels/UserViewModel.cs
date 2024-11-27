using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LookLikeProject.Models;
using System.Collections.ObjectModel;

namespace LookLikeProject.ViewModels
{
    public partial class UserViewModel:ObservableObject
    {

        [ObservableProperty]
        private User _user = new User();

       

        [ObservableProperty]
        private ObservableCollection<User> _users = new ObservableCollection<User>();

        [ObservableProperty]
        private User _selectedUser = new User();

        public UserViewModel()
        {
            User.Szuldatum = DateTime.Now.AddYears(-14);
        }

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