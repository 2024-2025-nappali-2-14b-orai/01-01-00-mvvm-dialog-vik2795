using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using UserProject.Models;

namespace ceci.ViewModels
{
  
    public partial class UserViewModel : ObservableObject
    {
        [ObservableProperty]
        private User _user;

        public UserViewModel()
        {
            _user = new User();
        }
    }
}
