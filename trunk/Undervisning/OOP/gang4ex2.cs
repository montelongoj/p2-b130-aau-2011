using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    interface I1
    {
        string M0();
        string M1();
    }
    interface I2 : I1
    {
        
    }
    class A : I1
    {
        public string M0() { return "A.M0"; }
        public virtual string M1() { return "A.M1"; }
    }
    class B : A
    {
        public new string M0() { return "B.M0"; }
        public override string M1() { return "B.M1"; }
    }
    class C : I2
    {
        public string M0() { return "C.M0"; }
        public virtual string M1() { return "C.M1"; }
    }
    class D : C, I2
    {
        public override string M1() { return "D.M1"; }
    }
    class E : I1, I2
    {
        public virtual string M0() { return "E.M0"; }
        public string M1() { return "E.M1"; }
        string I1.M0() { return this.M0(); }
    }
    class F : D, I2
    {
        public new string M0() { return "F.M0"; }
        public override string M1() { return "F.M1"; }
    }
    class G : E, I1, I2
    {
        public override string M0() { return "G.M0"; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            I1[] i1s = new I1[]
{
new A(),
new B(),new C(),
new D(),
new E(),
new F(),
new G()
};
            foreach (I1 i1 in i1s)
            {
                Console.WriteLine("{0} - {1}", i1.M0(), i1.M1());
            }
            Console.ReadLine();
        }
    }
}
