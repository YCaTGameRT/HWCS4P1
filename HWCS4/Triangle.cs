using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS4 {
    class Triangle : GeometricFigure {
        private double _first, _second, _third;

        public Triangle(double aSide, double bSide, double cSide) {
            _first = aSide;
            _second = bSide;
            _third = cSide;
        }

        public override double FigureArea() {
            return Math.Sqrt((_first + _second + _third / 2) * ((_first + _second + _third / 2) - _first) * ((_first + _second + _third / 2) - _second) * ((_first + _second + _third / 2) - _third));
        }

        public override double FigurePerimeter() {
            return _first + _second + _third;
        }
    }
}
