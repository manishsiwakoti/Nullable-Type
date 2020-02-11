using System;

namespace Nullable_Type
    {
    class Program
        {
        Major[] Major = new Major[]
            {
                new Major(100, "Math", 900),
                new Major(200, "Enlish", null),
                new Major(300, "BootCamp", null),
                };

         Students[] Students = new Students[] 
         {
            new Students(1, "Manish, Siwakoti", 950, 4.0),
             new Students(2, "Chris, Grey", null , 3.0),
            new Students(3, "John, Cena", null, 2.4),

                };
            
        
        static void Main(string[] args)
            {
            
            }
        }
    }
