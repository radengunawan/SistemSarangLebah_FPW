using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemSarangLebah_FPW
{
    class ProduserMadu : Lebah
    {
        //override ﬂoat CostPerShift
        //protected virtual float HargaPerShift = 0f;
        private readonly float HargaPerShift = 1.0f;
        
        
        
        //protected virtual void DoJob()
        protected override void DoJob()
        {
            base.DoJob();
        }

    }
}
