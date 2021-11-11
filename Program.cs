using System;

namespace hacker
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr2 = Console.ReadLine();
        string arr = Console.ReadLine();
        char[] bosluk = new char[] { ' ', '.' };

        string[] sayi = arr.Split(bosluk, StringSplitOptions.RemoveEmptyEntries);
        int n1 = sayi.Length;
       
        int [] sayidizisi1 = new int [n1];
       for (int i = 0; i < n1; i++)
        {
            sayidizisi1[i]=int.Parse(sayi[i]);
        }
        Array.Sort(sayidizisi1);
        Array.Reverse(sayidizisi1);
        int b=0;

        for (int i = 0; i < n1-1 ; i++)
        {
            b=sayidizisi1[i];
            if (sayidizisi1[i]>sayidizisi1[i+1])
            {
                break;
            }
            for (int j = i+1; j < n1-1 ; j++)
            { 
                if (sayidizisi1[j]>sayidizisi1[j+1])
                {
                break;
                }
                
                int g = i>(j-i) ? b=sayidizisi1[i] : i<(j-i) ? b=sayidizisi1[j] :b=sayidizisi1[j] ;
                for (int k = j+1; k < n1-1; k++)
                {
                    if (sayidizisi1[k]>sayidizisi1[k+1])
                    {
                        break;
                    }
                    int f = j>(k-j) || i>(k-i) ? b+=0 : j<(k-j) || i<(k-i) ? b=sayidizisi1[k] : b=sayidizisi1[k]  ;
                    for (int l = k+1; l < n1-1; l++)
                    {
                        if (sayidizisi1[l]>sayidizisi1[l+1])
                        {
                            break;
                        }
                        int d = j>(l-j) || i>(l-i) || k>(l-k)  ? b+=0 : j<(l-j) || i<(l-i) || k<(l-k) ? b=sayidizisi1[l]  : b=sayidizisi1[l]  ;
                        
                        for (int m = l+1; m < n1-1; m++)
                        {
                            if (sayidizisi1[m]>sayidizisi1[m+1])
                            {
                                break;
                            }
                            int s = j>(m-j) || i>(m-i) || k>(m-k) || l>(m-l)  ? b+=0 : j<(m-j) || i<(m-i) || k<(m-k)|| l<(m-l) ? b=sayidizisi1[m]  : b=sayidizisi1[m]  ;
                            Console.WriteLine(b);
                            

                            
                        }
                    }
                }
            }
        }Console.WriteLine(b);
        
        
        }
    }
}
