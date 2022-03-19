﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Invoicing.Core.Data
{
    public partial class Invoiceproduct
    {
        public int Idinvoiceproduct { get; set; }
        public int Idinvoice { get; set; }
        public int Idproduct { get; set; }
        public decimal Value { get; set; }

        public virtual Invoice IdinvoiceNavigation { get; set; }
        public virtual Product IdproductNavigation { get; set; }
    }
}
