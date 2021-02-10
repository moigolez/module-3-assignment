﻿using System;
using Modules.Models;

namespace Modules.MyClasses.DTOS
{
    public class CakeDTO
    {
        public int CakeId { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public string Form { get; set; }

        public string Flavor { get; set; }

        public Role Role { get; set; }
    }
}
