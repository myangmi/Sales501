﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ItemDataBase
{
    public Item[] inventory;
    public Item[] buying ;
    public ItemDataBase()
    {
       Item[]nventory = { null, new Item(0, 9.47, 0), new Item(0, 10.97, 0), new Item(0, 19.97, 0), new Item(0, 13.28, 0), new Item(0, 5.97, 0), new Item(0, 4.99, 0), new Item(0, 4.99, 0), new Item(0, 4.99, 0) };
       Item[] uying = { null, new Item(0, 9.47, 0), new Item(0, 10.97, 0), new Item(0, 19.97, 0), new Item(0, 13.28, 0), new Item(0, 5.97, 0), new Item(0, 4.99, 0), new Item(0, 4.99, 0), new Item(0, 4.99, 0) };
        buying = uying;
        inventory = nventory;
    }
    public Item getItemFromB(int i)
    {
        return buying[i];
    }
}

