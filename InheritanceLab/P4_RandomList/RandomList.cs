﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomList : ArrayList
{
    private Random rnd;

    public RandomList()
    {
        rnd = new Random();
    }
    public string RandomString()
    {
        return "someting";
    }
}