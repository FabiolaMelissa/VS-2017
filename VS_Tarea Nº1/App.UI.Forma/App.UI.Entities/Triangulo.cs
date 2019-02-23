using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UI.Entities
{
    public class Triangulo : Forma
    {
        
       

        public override void Area()
        {
            AreaFinal = (ParmX * ParmY) / 2;

            base.Area();

        }

    }
}
