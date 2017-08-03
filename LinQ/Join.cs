using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ {
    public class Join {
        public static void Execute (List<int> list1, List<int> list2) {
            Console.WriteLine("Con join.");
            var join = from number1 in list1
                join number2 in list2 on number1 equals number2
                select number1;
            foreach (var number in join) {
                Console.WriteLine(number);
            }
        }
    }
}