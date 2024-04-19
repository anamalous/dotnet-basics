using System;

namespace oop
{
    public class Student
    {
        public int rno;
        protected String name;
        protected int marks1;
        internal int marks2;
        protected internal int marks3;
        private double average;

        public Student()
        {
            rno = 5;
            name = "student1";
            marks1 = 20;
            marks2 = 30;
            marks3= 50;
        }

        public Student(int r,string n,int m1,int m2,int m3)
        {
            rno = r;
            name = n;
            marks1 = m1;
            marks2 = m2;
            marks3 = m3;
        }
        public double avg(int internals)
        {
            return (marks1 + marks2 + marks3 + internals) / 4;
        }
        public double avg()
        {
            return (marks1 + marks2 + marks3) / 3;
        }
    }

    class execute
    {
        public static void Main(String[] args)
        {
            //object1
            Student s1 = new Student();
            Console.WriteLine("student 1\n");
            Console.WriteLine("rollno:"+s1.rno);
            Console.WriteLine("subject 2 marks:"+s1.marks2);
            Console.WriteLine("subject 3 marks:"+s1.marks3);
            Console.WriteLine("average:"+s1.avg());

            //object 2
            Console.WriteLine("\nenter details for student 2\n");
            Console.Write("rollno:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("name:");
            String n = Console.ReadLine();
            Console.Write("subject 1:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("subject 2:");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("subject 3:");
            int m3 = Convert.ToInt32(Console.ReadLine());
            Student s2 = new Student(r, n, m1, m2, m3); 
            Console.WriteLine("average:"+s2.avg());

            //for internal marks
            Console.Write("internal marks:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("average:"+((i == 0) ? s2.avg() : s2.avg(i)));
        }
    }
    class SYBSC : Student
    {
        private String stream;
        public SYBSC(int r,String n,int m1,int m2,int m3,String s):base(r, n, m1, m1, m3) 
        { stream = s; }
        public static void Main(string[] args)
        {
            Console.Write("rollno:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("name:");
            String n = Console.ReadLine();
            Console.Write("subject 1:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("subject 2:");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("subject 3:");
            int m3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("stream:");
            String s = Console.ReadLine();
            SYBSC stud = new SYBSC(r, n, m1, m2, m3, s);
            Console.WriteLine("\nstudent 3\n");
            Console.WriteLine("rollno:"+stud.rno);
            Console.WriteLine("name:"+stud.name);
            Console.WriteLine("subject 1:"+stud.marks1);
            Console.WriteLine("subject 2:"+stud.marks2); 
            Console.WriteLine("subject 3:"+stud.marks3);
            Console.WriteLine("stream:"+stud.stream);
            Console.WriteLine("average:"+stud.avg());
        }
    }
}