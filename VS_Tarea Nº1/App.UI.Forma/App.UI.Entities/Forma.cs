using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App.UI.Entities.Events.Listeners;

namespace App.UI.Entities
{
     public abstract class Forma
    {
        public event DespuesCalcular onDespuesCalcular;

        public double ParmX { get; set; }
        public double ParmY { get; set; }
        public double AreaFinal { get; set; }

        public virtual void Area()
        {
            if (onDespuesCalcular != null)
            {
                onDespuesCalcular(this);
            }
        }
    }
}
