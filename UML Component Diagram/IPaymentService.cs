﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Architecture.UML_Component_Diagram
{
    public interface IPaymentService
    {
        bool ProcessPayment(decimal amount);
    }
}
