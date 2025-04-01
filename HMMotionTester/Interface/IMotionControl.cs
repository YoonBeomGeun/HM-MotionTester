using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMMotionTester.Interface
{
    public interface IMotionControl
    {
        string GetMotionData();
        void RunMotion();
    }
}
