using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_TheInterface
{
    internal interface IShape
    {
        string Color();
        double FrameThickness();
        int VerticesNum();
    }
}
