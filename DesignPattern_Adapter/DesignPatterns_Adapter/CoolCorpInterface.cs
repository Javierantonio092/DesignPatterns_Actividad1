using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Adapter
{
    interface CoolCorpInterface
    {
        float CurrentSpeedInKilometersPerHour { get; set; }
        void Jump(float meters);
    }
}
