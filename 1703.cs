using System;

class Program
{
    public static decimal Sqrt(decimal x)
    {
        decimal epsilon = 0.0M;
        decimal previous;
        decimal current = (decimal)Math.Sqrt((double)x);
        do
        {
            
            previous = current;
            if (previous == 0.0M) return 0;
            current = (previous + x / previous) / 2;
        }
        while (Math.Abs(previous - current) > epsilon);
        return current;
    }

    public struct coord
    {
        public decimal x;
        public decimal y;
        public decimal z;
    }

    static void Main(string[] args)
    {
        var s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);

        s = Console.ReadLine().Split();
        // point M1
        coord m1;
        m1.x = decimal.Parse(s[0]);
        m1.y = decimal.Parse(s[1]);
        m1.z = decimal.Parse(s[2]);
        s = Console.ReadLine().Split();
        // point M2
        coord m2;
        m2.x = decimal.Parse(s[0]);
        m2.y = decimal.Parse(s[1]);
        m2.z = decimal.Parse(s[2]);
        // vector M1M2
        coord m1m2;
        m1m2.x = m2.x - m1.x;
        m1m2.y = m2.y - m1.y;
        m1m2.z = m2.z - m1.z;

        // lengths of M1O & M1M2
        decimal lm1o = Sqrt(m1.x * m1.x + m1.y * m1.y + m1.z * m1.z);
        decimal lm1m2 = Sqrt(m1m2.x * m1m2.x + m1m2.y * m1m2.y + m1m2.z * m1m2.z);

        decimal lm1h = -(m1.x * m1m2.x + m1.y * m1m2.y + m1.z * m1m2.z) / lm1m2;
        // point H
        coord h;
        h.x = m1.x + m1m2.x * lm1h / lm1m2;
        h.y = m1.y + m1m2.y * lm1h / lm1m2;
        h.z = m1.z + m1m2.z * lm1h / lm1m2;
        decimal c = Sqrt(h.x * h.x + h.y * h.y + h.z * h.z);
        decimal eps = 0.0000000000000001M;
        if ((c - a - b > eps) || (Sqrt(a * a + b * b) - c > eps))
        {
            Console.Write("No solution.");
        }
        else if (Math.Abs(c-a-b)<eps)
        {
            Console.Write("{0} {1} {2} {3}", h.x * a / c, h.y * a / c, h.z * a / c, Math.PI);
        }
        else
        {
            //vector HK
            coord hk;
            hk.x = m1m2.y * h.z - h.y * m1m2.z;
            hk.y = m1m2.z * h.x - h.z * m1m2.x;
            hk.z = m1m2.x * h.y - h.x * m1m2.y;

            decimal lhk = Sqrt(hk.x * hk.x + hk.y * hk.y + hk.z * hk.z);
            decimal cos = (a * a + b * b - c * c) / (2 * a * b);
            double angle = Math.Acos((double)cos);
            
            decimal d = (a * a + c * c - b * b) / (2 * c);
            decimal k = Sqrt(a * a - d * d);
            // point F
            coord f;
            f.x = k * hk.x / lhk + d * h.x / c;
            f.y = k * hk.y / lhk + d * h.y / c;
            f.z = k * hk.z / lhk + d * h.z / c;
            Console.Write("{0} {1} {2} {3}", f.x, f.y, f.z, angle);
        }
    }
}
