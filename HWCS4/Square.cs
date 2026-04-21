using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS4 {
    class Square : GeometricFigure {
        private double _side;

        public Square(double side) {
            _side = side;
        }

        public override double FigureArea() {
            return _side * _side;
        }

        public override double FigurePerimeter() {
            return _side * 4;
        }
    }
}
