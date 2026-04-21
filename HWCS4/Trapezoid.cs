using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS4 {
    class Trapezoid : GeometricFigure {
        private double _top, _bottom, _aSide, _bSide, _h;

        public Trapezoid(double top, double bottom, double aSide, double bSide, double h) {
            _top = top;
            _bottom = bottom;
            _aSide = aSide;
            _bSide = bSide;
            _h = h;
        }

        public override double FigureArea() {
            return _top * _bottom / 2 * _h;
        }

        public override double FigurePerimeter() {
            return _top + _bottom + _aSide + _bSide;
        }
    }
}
