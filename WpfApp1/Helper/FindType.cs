﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Helper
{
    class FindType
    {
        int id;
        public FindType(int id)
        {
            this.id = id;
        }
        public bool TypeAccountPredicate(TypeAccount typeAccount)
        {
            return typeAccount.Id == id;
        }
    }
}
