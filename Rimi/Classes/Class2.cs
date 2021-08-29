using Rimi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rimi.Classes {
    public class Class2 : ITestClass2 {
        public string testfunction() {
            return "output from ITestClass2.testfunction()";
        }
    }
}
