using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace nsModuleB.ViewModels
{
    public class Screen2VM:BindableBase
    {
        public string Title { get; set; }

        public Screen2VM()
        {
            Title = "Screen 2";
        }

    }
}
