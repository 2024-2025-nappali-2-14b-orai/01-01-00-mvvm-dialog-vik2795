using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ceci.ViewModels
{
  
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private User _user;
    }
}
