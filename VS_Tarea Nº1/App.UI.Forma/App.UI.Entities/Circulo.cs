using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UI.Entities
{
    public class Circulo : Forma
    {
        public override void Area()
        {
            AreaFinal = Math.Round(Math.PI * Math.Pow(ParmX, 2), 2);

            base.Area();

        }



        
    }
}
