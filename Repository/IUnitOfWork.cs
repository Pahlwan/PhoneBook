﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUnitOfWork:IDisposable
    {
        IPersonRepository People { get; }
        int Complete(object entity);
    }
}
