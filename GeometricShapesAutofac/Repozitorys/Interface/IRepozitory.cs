using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesAutofac.Repozitorys.Interface
{
    public interface IRepozitory
    {
        List<string> GetName();
        List<string> GetInformation();
        void SevaFile();
    }
}
