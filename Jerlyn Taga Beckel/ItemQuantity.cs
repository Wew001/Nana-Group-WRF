﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Jerlyn_Taga_Beckel
{
    public class ItemQuantity
    {
        public int ItemID { get; }
        public int Quantity { get; }
        public ItemQuantity(int itemID, int quantity)
        {
            ItemID = itemID;
            Quantity = quantity;
        }
    }
}
