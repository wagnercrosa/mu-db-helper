﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUTools
{
    class Inventory : StorageSpace
    {
        protected int space_size = 2048;

        public Inventory() : base()
        {

        }

        public Inventory(string hex) : base(hex)
        {

        }
    }
}
