﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdenty { get; set; }
        public int DataOfBirthYear { get; set; }
    }
}
