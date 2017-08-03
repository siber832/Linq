using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ {
    public class MethodSyntax {
        public static void Execute(List<int> list1, List<int> list2){
            IEnumerable<int> method = list1.Where(number => list2.Contains(number));
            Console.WriteLine("Con method sintax.");
            foreach (var number in method) {
                Console.WriteLine(number);
            }
        }
    }
}