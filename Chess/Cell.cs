using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Cell
    {
        public string Row { get; set; }

        public string Column { get; set; }

        public string Name
        {
            get
            {
                return $"{Row}{Column}";
            }
        }

        public bool IsValidMove { get; set; }
    }
}
