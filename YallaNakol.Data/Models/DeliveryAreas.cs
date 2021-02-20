﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YallaNakol.Data.Models
{
    [Flags]
    public enum DeliveryAreas
    {
        Obour=0,
        NewCairo=1,
        Madinaty=2,
        NasrCity=4,
        Maddi=8,
        AinShams=16,
        October=32
    }
}