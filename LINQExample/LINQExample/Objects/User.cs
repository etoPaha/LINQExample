﻿using System.Collections.Generic;

namespace LINQExample.Objects
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }

        public User()
        {
            Languages = new List<string>();
        }
    }
}