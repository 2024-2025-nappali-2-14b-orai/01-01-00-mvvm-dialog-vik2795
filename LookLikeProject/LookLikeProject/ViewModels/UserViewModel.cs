using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using LookLikeProject.Models;
using System.Collections.Generic;

namespace LookLikeProject.ViewModels
{
    public partial class UserViewModel:ObservableObject
    {
        [ObservableProperty]
        private User _user;


        public UserViewModel() 
        {
            _user= new User();
        }
    }
}
