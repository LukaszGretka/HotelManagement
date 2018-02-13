﻿using HotelManagmentLogic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Models
{
    class ApartamentModel : Room
    {
        public int LivingRoomsAmount { get; set; }

        public int ToiletsAmount { get; set; }

        public int KitchenAmount { get; set; }

        public bool HasBalcon { get; set; }
    }
}
