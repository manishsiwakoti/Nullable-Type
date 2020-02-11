using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_Type
    {
   public class Major
        {
        public int Id { get; set; }

        public string Description { get; set; }
        public int? MinSat { get; set; }


        public Major(int id, string description, int? minsat)
            {
            Id = id;
            Description = description;
            MinSat = minsat;


           
            }

        }
    }
