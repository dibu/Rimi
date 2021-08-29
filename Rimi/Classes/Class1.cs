using Rimi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rimi.Classes {
    public class Class1 : ITestClass1 {
        public string test() {
            return "Output from ITestClass1.test()";
        }
    }
}
