using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS4
{
    class Rhombus : GeometricFigure {
        private double _side, _h;

        public Rhombus(double side, double h) {
            _side = side;
            _h = h;
        }

        public override double FigureArea() {
            return _side * _h;
        }

        public override double FigurePerimeter() {
            return _side * 4;
        }
    }
}
