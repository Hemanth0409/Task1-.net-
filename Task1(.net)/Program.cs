using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_.net_
{
    public class task1program2
    {
        public void program2()
        {
            StringBuilder myStringBuilder = new StringBuilder("Hello!");
           
            myStringBuilder.AppendLine("Folks");
            Console.WriteLine(myStringBuilder);
            myStringBuilder.Remove(5, 1);
            Console.WriteLine(myStringBuilder);
            myStringBuilder.Insert(5, "Friends");
            Console.WriteLine(myStringBuilder); 
            myStringBuilder.Replace('!', '?');
            Console.WriteLine(myStringBuilder);
            Console.ReadLine();
        }
    }
    internal class task1program1
    {
        static void Main(string[] args)
        {
            //Static method 
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine("sharon");
            //sb.AppendLine("darshan");
            //sb.AppendLine("karthi");

            //Console.WriteLine(sb.ToString());
            //Console.ReadLine();

            //Input from user(Dynamic)
            Console.WriteLine("Enter the number of trainees");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter " + n + " trainees");
            for (int i = 0; i < n; i++)
            {
                sb.AppendLine(Console.ReadLine());
            }
            Console.WriteLine("The Entered Trainees are:");
            Console.WriteLine(sb.ToString());

            var x = new task1program2();
            x.program2();

            Console.ReadLine();
        }
    }
}
