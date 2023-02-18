#region 1 misol class work
//Console.Write(" n = "); double n = double.Parse(Console.ReadLine());
//double yigindi = 0;
//double J =yigindi;
//while (J <= n)
//{ 
//  J+= Math.Pow(J, n);
//    J++;
//    Console.WriteLine(J);
//}
#endregion
#region 2 misol class work
//Console.Write(" n = "); double n = double.Parse(Console.ReadLine());
//double J = 0;
//while (J< n )
//{
//    J+= (J+ n) / 2;
//    J+= Math.Sqrt(J* n);
//    J++;
//    Console.WriteLine(J);
//}
#endregion
#region while 2 misol
//Console.Write(" A = "); double A = double.Parse(Console.ReadLine());
//Console.Write(" B = "); double B = double.Parse(Console.ReadLine());
//int j = 0;
//while (B <= A)
//{
//    A = A - B;
//    j ++;
//}


//    Console.WriteLine(" Butun son" + j);
#endregion
#region 10 misol
//Console.WriteLine(" n = "); int n = int.Parse(Console.ReadLine());
//int j = 1,yigindi = 0;
//while (j <= n)
//{
//    int i = 2, k = 0;
//    while (j > i)
//    {
//        if (j % i == 0)
//        {
//            k++;
//        }
//        i ++;
//    }
//    if (k == 0)
//    {
//        Console.Write(j + " ");
//        yigindi += j;
//    }
//    j++;
//}
#endregion
#region 5 misol
//Console.WriteLine(" N = "); int N = int.Parse(Console.ReadLine());
//int s = 1, k = 0;
//while (N > s)
//{
//    s *= 2;
//    k++;
//}
//if (N == s)
//{
//    Console.WriteLine(k);
//}
//else
//{
//    Console.WriteLine(N + " soni 2 ning darajasi emas ");
//}
#endregion
#region 8 misol
//int n = 10;
//while (n < 100)
//{
//    if (n % 2 == 1)
//    {
//        Console.WriteLine(n); 
//    }
//     n++;
//}

#endregion
#region 9 misol
int j = 0;
int n = 100;
while (n <= 999)
{
    if ( n % 3 == 0 && n % 7 == 0 )
    {
        Console.WriteLine( n );
        j = j + n;
    }
    n++;
}
Console.WriteLine(j);


#endregion






