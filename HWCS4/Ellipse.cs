using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS4 {
    class Ellipse : GeometricFigure {
        private double _halfSmallR, _halfBigR;

        public Ellipse(double halfSmallR, double halfBigR) {
            _halfSmallR = halfSmallR;
            _halfBigR = halfBigR;
        }

        public override double FigureArea() {
            return 3.14 * _halfSmallR * _halfBigR;
        }

        public override double FigurePerimeter() {
            return 2 * 3.14 * Math.Sqrt((Math.Sqrt(_halfSmallR) + Math.Sqrt(_halfBigR)) / 2);
        }
    }
}
