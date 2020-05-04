using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaaw_Pr_Obiektowe_zaliczenie
{
    class Operation
    {
        float payment, bonus;
        int overtime;
        DateTime currentTime = DateTime.Now;

        public Operation(float payment, float bonus, int overtime)
        {
            this.payment = payment;
            this.bonus = bonus;
            this.overtime = overtime;
        }
    }
}
