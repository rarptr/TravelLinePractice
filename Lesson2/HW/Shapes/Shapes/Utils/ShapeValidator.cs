using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Utils;

public class ShapeValidator
{
    public void CheckSegmentLength(double length)
    {
        if (length <= 0)
        {
            throw new ArgumentException("Segment length is not greater than zero.");
        }
    }
}
