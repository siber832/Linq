using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ {
    public class QuerySyntax {
        public static void Execute(List<int> list1, List<int> list2) {
            Console.WriteLine("Con query sintax.");
            var query = from number in list1
                where list2.Contains(number)
                select number;
            foreach (var number in query) {
                Console.WriteLine(number);
            }
        }
    }
}