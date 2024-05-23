using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clab6._1
{
    internal class Program
    {
        class Employer
        {
            protected string name;
            protected string post;
            protected string company;
            protected int exp;
            protected int salary;
            public Employer()
            {
                this.name = "none";
                this.post = "employer";
                this.company = "nothing";
                this.exp = 0;
                this.salary = 0;
            }
            public Employer(string name, int exp = 2)
            {
                this.name = name;
                this.exp = exp;
            }
            public Employer(string name = "Виталий", string post = "Стример", string company = "Youtube", int exp = 10, int salary = 199999)
            {
                this.name = name;
                this.post = post;
                this.company = company;
                this.exp = exp;
                this.salary = salary;
            }
            [DllImport(@"DLL1.dll",
            CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode)]
            public static extern bool InputStr(
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder str, int len);

            [DllImport(@"DLL1.dll",
            CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode)]
            public static extern int InputInt();

            [DllImport(@"DLL1.dll",
            CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode)]
            public static extern bool OutputInt(int num);

            [DllImport(@"DLL1.dll",
            CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode)]
            public static extern bool OutputStr(
                [MarshalAs(UnmanagedType.LPWStr)] StringBuilder str, int length);
            public virtual void Input()
            {
                Console.WriteLine("Enter name, post, company, exp, salary");
                StringBuilder str = new StringBuilder(10);
                InputStr(str, str.Capacity);
                name = str.ToString();
                post = str.ToString();
                company = str.ToString();
                exp = InputInt();
                salary = InputInt();
            }

            public virtual void Output()
            {
                OutputStr(new StringBuilder(name), name.Length);
                OutputStr(new StringBuilder(post), post.Length);
                OutputStr(new StringBuilder(company), company.Length);
                OutputInt(exp);
                OutputInt(salary);
                Console.WriteLine("\n");
            }

            private void SetName(string name)
            {
                this.name = name;
            }

            private void SetPost(string post)
            {
                this.post = post;
            }

            private void SetCompany(string company)
            {
                this.company = company;
            }

            private void SetExp(int exp)
            {
                this.exp = exp;
            }

            protected string Getname()
            {
                return name;
            }

            protected string Getpost()
            {
                return post;
            }

            protected string Getcompany()
            {
                return company;
            }
            protected int Getexp()
            {
                return exp;
            }

            protected int Getsalary()
            {
                return salary;
            }

            ~Employer()
            {
                this.name = null;
                this.post = null;
                this.company = null;
                this.exp = 0;
                this.salary = 0;
            }
        }
        [StructLayout(
            LayoutKind.Sequential,
            CharSet = CharSet.Unicode)]

        public struct Employer1Struct
        {
            [MarshalAs(
                UnmanagedType.ByValTStr,
                SizeConst = 100)]
            public string name;
            public string post;
            public string company;
            public int exp;
            public int capital;
            public int salary;
            public Employer1Struct(string name, string post, string company, int exp, int capital, int salary)
            {
                this.name = name;
                this.post = post;
                this.company = company;
                this.exp = exp;
                this.capital = capital;
                this.salary = salary;
            }
        }
        class Employer1 : Employer
        {
            private int capital;
            public Employer1(string name, string post, string company, int exp, int capital, int salary) : base(name, post, company, exp, salary)
            {
                this.capital = 0;
            }
            public Employer1()
            {
                this.name = "Employer1";
                this.capital = 0;
            }
            [DllImport(@"DLL1.dll",
            CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode)]
            public static extern bool InputEmployer1(
            ref Employer1Struct ptr);

            public override void Input()
            {
                Employer1Struct structure = new Employer1Struct();
                InputEmployer1(ref structure);
                name = structure.name;
                post = structure.post;
                company = structure.company;
                exp = structure.exp;
                salary = structure.salary;
                capital = structure.capital;
            }

            [DllImport(@"DLL1.dll",
            CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode)]
            public static extern bool OutputEmployer1(
               ref Employer1Struct ptr);

            public override void Output()
            {
                Employer1Struct structure = new Employer1Struct(name, post, company, exp, capital, salary);
                OutputEmployer1(ref structure);
                Console.WriteLine("\n");
            }
        }
        [StructLayout(
            LayoutKind.Sequential,
            CharSet = CharSet.Unicode)]
        public struct Employer2Struct
        {
            [MarshalAs(
                UnmanagedType.ByValTStr,
                SizeConst = 100)]
            public string name;
            public string post;
            public string company;
            public int exp;
            public int socialraiting;
            public Employer2Struct(string name, string post, string company, int exp, int socialraiting)
            {
                this.name = name;
                this.post = post;
                this.company = company;
                this.exp = exp;
                this.socialraiting = socialraiting;
            }
        }
        class Employer2 : Employer
        {
            public int socialraiting;
            public Employer2()
            {
                this.socialraiting = 0;
                this.name = "Employer2";
            }
            public Employer2(string name, string post, string company, int exp, int socialraiting) : base(name, post, company, exp)
            {
                this.socialraiting = 0;
            }

            [DllImport(@"DLL1.dll",
            CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode)]
            public static extern bool InputEmployer2(
            ref Employer2Struct ptr);

            public override void Input()
            {
                Employer2Struct structure = new Employer2Struct();
                InputEmployer2(ref structure);
                name = structure.name;
                post = structure.post;
                company = structure.company;
                exp = structure.exp;
                socialraiting = structure.socialraiting;
            }

            [DllImport(@"DLL1.dll",
            CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode)]
            public static extern bool OutputEmployer2(
               ref Employer2Struct ptr);

            public override void Output()
            {
                Employer2Struct structure = new Employer2Struct(name, post, company, exp, socialraiting);
                OutputEmployer2(ref structure);
                Console.WriteLine("\n");
            }
        }
        [StructLayout(
            LayoutKind.Sequential,
            CharSet = CharSet.Unicode)]
        public struct Employer3Struct
        {
            [MarshalAs(
                UnmanagedType.ByValTStr,
                SizeConst = 100)]
            public string name;
            public string post;
            public string company;
            public int exp;
            public int salary;
            [MarshalAs(
                UnmanagedType.ByValTStr,
                SizeConst = 100)]
            public int age;
            public Employer3Struct(string name, string post, string company, int exp, int salary, int age)
            {
                this.name = name;
                this.post = post;
                this.company = company;
                this.exp = exp;
                this.salary = salary;
                this.age = age;
            }
        }
        class Employer3 : Employer
        {
            private int age;
            public Employer3()
            {
                this.age = 0;
                this.name = "Employer3";
            }
            public Employer3(string name, string post, string company, int exp, int salary, int age) : base(name, post, company, exp, salary)
            {
                this.age = age;
            }

            [DllImport(@"DLL1.dll",
            CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode)]
            public static extern bool InputEmployer3(
            ref Employer3Struct ptr);

            public override void Input()
            {
                Employer3Struct structure = new Employer3Struct();
                InputEmployer3(ref structure);
                name = structure.name;
                post = structure.post;
                company = structure.company;
                exp = structure.exp;
                salary = structure.salary;
                age = structure.age;
            }

            [DllImport(@"DLL1.dll",
            CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode)]
            public static extern bool OutputEmployer3(
               ref Employer3Struct ptr);

            public override void Output()
            {
                Employer3Struct structure = new Employer3Struct(name, post, company, exp, salary, age);
                OutputEmployer3(ref structure);
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Employer employer = new Employer();
            employer.Input();
            employer.Output();

            Employer1 employer1 = new Employer1();
            employer1.Input();
            employer1.Output();

            Employer2 employer2 = new Employer2();
            employer2.Input();
            employer2.Output();

            Employer3 employer3 = new Employer3();
            employer3.Input();
            employer3.Output();
        }
    }
}
