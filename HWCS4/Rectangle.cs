using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS4 {
    class Rectangle : GeometricFigure {
        private double _aSide, _bSide;

        public Rectangle(double aSide, double bSide) {
            _aSide = aSide;
            _bSide = bSide;
        }

        public override double FigureArea() {
            return _aSide * _bSide;
        }

        public override double FigurePerimeter() {
            return (_aSide + _bSide) * 2;
        }
    }
}
