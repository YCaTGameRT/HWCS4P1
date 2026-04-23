using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS4 {
    class CompoundFigure {
        List<GeometricFigure> figures = new List<GeometricFigure>();

        public double Area() {
            double totalArea = 0;
            foreach (GeometricFigure item in figures) {
                totalArea += item.FigureArea();
            }
            return totalArea;
        }
    }
}
