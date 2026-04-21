using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS4 {
    class Parallelogram : GeometricFigure {
        private double _aSide, _bSide, _hA;

        public Parallelogram(double aSide, double bSide, double hA) {
            _aSide = aSide;
            _bSide = bSide;
            _hA = hA;
        }

        public override double FigureArea() {
            return _aSide * _hA;
        }

        public override double FigurePerimeter() {
            return (_aSide + _bSide) * 2;
        }
    }
}
