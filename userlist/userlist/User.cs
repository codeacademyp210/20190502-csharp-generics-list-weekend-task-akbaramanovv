﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userlist
{
    class User
    {
        public static int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

      
        public int getId()
        {
            return ++ID;
        }

    }
}
