﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Domain.Base
{
    public interface IHaveCreationTime
    {
        public DateTime CreationTime { get; set; }
    }
}
