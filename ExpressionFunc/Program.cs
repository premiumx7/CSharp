using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionFunc
{

    public class Person
    {
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Label { get; set; }
        public long? Id { get; set; }
        public bool HasChanged { get; set; }
        public bool HasChangedRole { get; set; }
        public bool HasDeleted { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Person, string>> lambda = i => i.FullName + " - " + i.Label;
            Console.WriteLine(lambda.Compile()(new Person { FullName = "Cze", Label = "No ema" }));

            var binaryExpression = (BinaryExpression)lambda.Body;
            Console.WriteLine(binaryExpression.Left.ToString());
            Console.WriteLine(binaryExpression.Right.ToString());

            Console.ReadLine();
        }
    }
}
