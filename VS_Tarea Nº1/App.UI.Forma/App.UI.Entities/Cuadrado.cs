using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UI.Entities
{
   
        public class Cuadrado : Forma
        {



        public override void Area()
        {
            AreaFinal = Math.Pow(ParmX, 2);

            base.Area();

        }                  
        }
}
