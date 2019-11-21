using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    public class Global
    {
        private Global() { }
        private static Lazy<Global> _instance = new Lazy<Global>(() => new Global());
        public static Global Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        public String myData { get; set; }
    }
   
}
