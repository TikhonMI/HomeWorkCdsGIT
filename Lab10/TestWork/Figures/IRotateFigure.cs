using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Figures
{
    interface IRotateFigure
    {
        bool Rotate();
        bool IfRotate { get; set; }
    }
}
