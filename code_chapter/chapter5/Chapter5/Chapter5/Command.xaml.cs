using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mycommands
{
    class MyClass
    {
        public ICommand MyCommand { protected set; get; }
        public MyClass()
        {
            MyCommand = new Command({
                                    Console.WriteLine("Hello");
        });
                      }
}
        }
