using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS4 {
    class Circle : GeometricFigure {
        private double _radius;

        public Circle(double radius) {
            _radius = radius;
        }

        public override double FigureArea() {
            return 3.14 * _radius * _radius;
        }

        public override double FigurePerimeter() {
            return 2 * 3.14 * _radius;
        }
    }
}
