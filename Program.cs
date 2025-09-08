using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SP
    {
        float a, b;

        public SP(float a = 0, float b = 0)
        {
            this.a = a;
            this.b = b;
        }

        public void Nhap()
        {
            Console.Write("Nhap phan thuc: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap phan ao: ");
            b = float.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            if (b > 0) Console.WriteLine("{0}+{1}i", a, b);
            else if (b < 0) Console.WriteLine("{0}-{1}i", a, Math.Abs(b));
            else Console.WriteLine("{0}", a);
        }

        public SP cong2sp(SP so2)
        {
            SP ans = new SP();
            ans.a = this.a + so2.a;
            ans.b = this.b + so2.b;

            return ans;
        }

        public SP tru2sp(SP so2)
        {
            SP ans = new SP();
            ans.a = this.a - so2.a;
            ans.b = this.b - so2.b;

            return ans;
        }
        public SP nhan2sp(SP so2)
        {
            SP ans = new SP();
            ans.a = this.a * so2.a;
            ans.b = this.b * so2.b;

            return ans;
        }
        public float B { get => b; set => b = value; }
        public float A { get => a; set => a = value; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SP sp1 = new SP(5, 7);
            SP sp2 = new SP();
            sp2.Nhap();
            (sp1.cong2sp(sp2)).xuat();
        }
    }
}
