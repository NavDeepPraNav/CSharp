using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace student
{
    public class student1
    {
        public String name;
        public int rollno;
        public String[] subname = { "pqt", "daa", "os", "java", "dbms", "coa", "oslab", "javalab" };
        public int[] credit = { 4, 4, 3, 4, 4, 3, 4, 2, 2 };
        public char[] grade = new char[8];
        public int gradept = 0;

    }
   public  class gpa : student1
    {
       public  gpa(String n, int r)
        {
            name = n;
            rollno = r;

        }
        public void readgrade()
        {
            double sum=0;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("enter the grade for {0}", subname[i]);
                grade[i] = Convert.ToChar(Console.ReadLine());
                if (grade[i] == ('S' |'s'))
                    gradept += credit[i] * 10;
                else if (grade[i] == ('A' | 'a'))
                    gradept += credit[i] * 9;
                else if (grade[i] == ('B' | 'b'))
                    gradept += credit[i] * 8;

                else if (grade[i] == ('C' | 'c'))
                    gradept += credit[i] * 7;

                else if (grade[i] == ('D' | 'd'))
                    gradept += credit[i] * 6;

                else if (grade[i] == ('E' | 'e'))
                    gradept += credit[i] * 5;

                else
                    gradept += credit[i] * 0;
            }
                sum = gradept / 26;
                Console.WriteLine("gpa is {0:R}", sum);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                string name1;
                int rollno1;
                name1 = Console.ReadLine();
                rollno1 = Convert.ToInt32(Console.ReadLine());
                gpa ob = new gpa(name1, rollno1);
                ob.readgrade();
                Console.ReadLine();
            }
        }
    }
