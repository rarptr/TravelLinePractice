using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Utils;

public class TriangleValidator : ShapeValidator
{
    public void CheckForExistence(double sideA, double sideB, double sideC)
    {
        CheckSegmentLength(sideA);
        CheckSegmentLength(sideB);
        CheckSegmentLength(sideC);

        if (!IsExists(sideA, sideB, sideC))
        {
            throw new ArgumentException("Triangle with given sides does not exist.");
        }
    }

    private bool IsExists(double sideA, double sideB, double sideC)
    {
        return sideA + sideB > sideC
            && sideB + sideC > sideA
            && sideC + sideA > sideB;
    }
}
