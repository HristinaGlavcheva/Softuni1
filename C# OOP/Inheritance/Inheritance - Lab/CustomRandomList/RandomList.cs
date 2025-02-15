﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();

            int index = random.Next(0, this.Count);

            string removedString = this[index];

            this.RemoveAt(index);

            return removedString;
        }
    }
}
