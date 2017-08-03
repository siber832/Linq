using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ {
    class Program {
        static void Main(string[] args) {
            List<int> list1 = new List<int>() {1, 2, 3};
            List<int> list2 = new List<int>() {2, 3};

            MethodSyntax.Execute(list1, list2);
            QuerySyntax.Execute(list1, list2);
            Join.Execute(list1, list2);

        }
    }
}