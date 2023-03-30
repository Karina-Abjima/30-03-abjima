using System;
namespace Pratice
{
    public abstract class child//only single inheritence supported
    {
        public static int a, b, c, choice;
        public abstract void add(int x, int y);
        public abstract void sub(int x, int y);
        public abstract void mult(int x, int y);
        public abstract void div(int x, int y);


    }
    public interface Isibling
    {
        public void employee(int a);
       
    }
    public sealed class parent : child, Isibling
    {
        public static int emp1;

        public static void Main(String[] args)
        {
            Console.WriteLine("Example of abstract function");
            Console.WriteLine("enter 2 number for operation");
            a = Convert.ToInt32(Console.ReadLine());//problem regarding error
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter choice\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            choice = Convert.ToInt32(Console.ReadLine());
            parent ob = new parent();
            switch (choice)
            {
                case 1:
                    ob.add(a, b);
                    break;
                case 2:
                    ob.sub(a, b);
                    break;
                case 3:
                    ob.mult(a, b);
                    break;
                case 4:
                    ob.div(a, b);
                    break;
                default:
                    Console.WriteLine("enter valid number");
                    break;
            }
            Console.WriteLine("Enter Employee's salary");
            emp1 = Convert.ToInt32(Console.ReadLine());
            ob.employee(emp1);
        }
        public void employee(int a)
        {
            if (a >= 20000)
                Console.WriteLine("Permanent Employee");
            else if (a <= 5000)
                Console.WriteLine("Trainee");
            else
                Console.WriteLine("Enter valid salary");
        }
     
        public void display(int a)
        {
            Console.WriteLine("Answer is " + a);
        }
        public override void sub(int x, int y)
        {
            display(Math.Abs(a - b));
        }
        public override void mult(int x, int y)
        {
            display(a * b);
        }
        public override void div(int x, int y)//override keyword is used to implement abstract functions of parent
        {
            display(Math.Abs(x / y));//for printing answers 
        }
        public override void add(int x, int y)
        {
            display(x + y);
        }

    }
} 

 