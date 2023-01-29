using System;
using System.Reflection;

namespace problemeSet3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
        }

        private static void P14()
        {
            //Interschimbati elementele unui vector
            //in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. 

            int n, i, j = 0;
            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elemnte

            Console.WriteLine($"Introduceti {n} elemente:");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (vector[i] != 0)
                {
                    int temp = vector[j];
                    vector[j] = vector[i];
                    vector[i] = temp;
                    j++;
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }

        private static void P13()
        {
            //Insertion Sort

            int n, i, j, val, flag;
            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elemnte

            Console.WriteLine($"Introduceti {n} elemente:");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 1; i < n; i++)
            {
                val = vector[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < vector[j])
                    {
                        vector[j + 1] = vector[j];
                        j--;
                        vector[j + 1] = val;
                    }
                    else flag = 1;
                }
            }

            Console.WriteLine("Insertion sort: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }


        private static void P12()
        {
            //Selection sort

            int n, i, min, temp;
            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elemnte

            Console.WriteLine($"Introduceti {n} elemente:");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vector[j] < vector[min])
                    {
                        min = j;
                    }
                }
                temp = vector[min];
                vector[min] = vector[i];
                vector[i] = temp;
            }
            Console.WriteLine("Selection sort: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }

        private static void P11()
        {
            //Toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).

            int n;

            Console.WriteLine("Introduceti un numar n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Numere prime mai mici sau egale cu n: ");

            //do-while loop
            int i = 2;
            while (i <= n)
            {
                if (i == 2)
                    Console.Write(i + ", ");
                if (i % 2 != 0)
                {
                    Console.Write($"{i}, ");
                }
                i++;
            } 
        }

        private static void P10()
        {
            //Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.
            //Se cere sa se determine pozitia unui element dat k.
            //Daca elementul nu se gaseste in vector rezultatul va fi -1. 

            int n, i, k;
            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elemnte

            Console.WriteLine($"Introduceti {n} elemente:");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            //pozitia k
            Console.WriteLine("Dati o pozitie k: ");
            k = int.Parse(Console.ReadLine());

            //sortam vectorul
            Array.Sort(vector);
            Console.WriteLine("Vectorul sortat: " + String.Join(", ", vector));

            //binary search
            Array.BinarySearch(vector, k);
            Console.WriteLine($"Pe pozitia {k} este: " + vector[k]);
        }

        private static void P9()
        {
            //Rotire k. Rotiti elementele vectorului cu k pozitii spre stanga. 

            int n, i, k;
            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elemnte

            Console.WriteLine($"Introduceti {n} elemente:");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            //pozitia k
            Console.WriteLine("Dati o pozitie k: ");
            k = int.Parse(Console.ReadLine());

            var rezultat = vector.Skip(k).Concat(vector.Take(k));
            Console.WriteLine(String.Join(", ", rezultat));
        }

        private static void P8()
        {
            //Rotire. Primul element devine ultimul, al doilea devine primul etc. 

            int n, i;
            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elemnte

            Console.WriteLine($"Introduceti {n} elemente:");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            var rezultat = vector.Skip(1).Concat(vector.Take(1));
            Console.WriteLine(String.Join(", ", rezultat));
        }

        private static void P7()
        {
            //Reverse. 
            int i, n;

            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elemente

            Console.WriteLine($"Introduceti {n} elemente:");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(vector);
            Console.WriteLine(String.Join(", ", vector));
        }

        private static void P6()
        {
            //Se cere sa se stearga din vector elementul de pe pozitia k

            int i, n, k;

            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n

            Console.WriteLine($"Introduceti {n} elemente:");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            //pozitia k
            Console.WriteLine("Dati o pozitie k: ");
            k = int.Parse(Console.ReadLine());

            //stergem k cu for loop si resize
            for (i = k; i < vector.Length - 1; i++)
            {
                vector[i] = vector[i + 1];
            }
            Array.Resize(ref vector, vector.Length - 1);

            Console.WriteLine(String.Join(", ", vector));
        }

        private static void P5()
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
            //Se cere sa se insereze valoarea e in vector pe pozitia k.
            //Primul element al vectorului se considera pe pozitia zero. 

            int n, e, k;

            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elem

            Console.WriteLine($"Introduceti {n} elemente:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            //valoarea e 
            Console.WriteLine("Dati o valoare e: ");
            e = int.Parse(Console.ReadLine());

            //pozitia k
            Console.WriteLine("Dati o pozitie k: ");
            k = int.Parse(Console.ReadLine());

            vector[k] = e;
            Console.WriteLine($"Pe pozitia {k} este valoarea " + vector[k]);
        }

        private static void P4()
        {
            //Det printr-o singura parcurgere, c.m. mica si c.m. mare valoare si de cate ori apar. 

            int i, n, min, max, repMax = 0, repMin = 0;
            
            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elemente

            Console.WriteLine($"Introduceti {n} elemente:");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = vector[0];
            min = vector[0];

            for (i = 0; i < n; i++)
            {
                if (vector[i] > max)
                {
                    max = vector[i];
                }

                if (vector[i] < min)
                {
                    min = vector[i];
                }
            }

            for (i = 0; i < n; i++)
            {
                if (vector[i] == vector[max])
                {
                    repMax++;
                }
                if (vector[i] == vector[min])
                {
                    repMin++;
                }
            }
            Console.WriteLine($"Maximum este: {max};\n  Apare de: {repMax} ori.");
            Console.Write($"Minimum este: {min};\n  Apare de : {repMin} ori.");
        }

        private static void P3()
        {
            //Pozitiile dintr-un vector, c.m. mic si c.m. mare element.

            int i, n, min, max;
            
            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elemente


            Console.WriteLine($"Introduceti {n} elemente:");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = vector[0];
            min = vector[0];

            for (i = 1; i < n; i++)
            {
                if (vector[i] > max)
                {
                    max = vector[i];
                }


                if (vector[i] < min)
                {
                    min = vector[i];
                }
            }
            Console.WriteLine($"Maximum este : {max}");
            Console.Write($"Minimum este : {min}");
        }

        private static void P2()
        {
            //Se da un vector cu n elemente si o valoare k.
            //Se cere sa se determine prima pozitie din vector pe care apare k.
            //Daca k nu apare in vector rezultatul va fi -1. 

            int i, n;
            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elemnte

            Console.WriteLine($"Introduceti {n} numere:");

            for (i = 0; i < n; i++)      //citim separat pt fiecare element 
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("k: ");      //cerem valoarea k
            int k = int.Parse(Console.ReadLine());

            //folosim metoda IndexOf()
            Console.WriteLine("Prima pozitie a lui k este: {0}", Array.IndexOf(vector, k));  
            //metoda de la sine afiseaza -1 daca valoarea nu exista in vector

        }

        private static void P1()
        {
            //Calculati suma elementelor unui vector de n numere citite de la tastatura

            int i, n;

            Console.Write("Numar de elemente :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];    //initializam un vector cu n elem

            Console.WriteLine($"Introduceti {n} numere:");
            
            for (i = 0; i < n; i++)      //citim separat pt fiecare element 
            {
                Console.Write("element - {0} : ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = vector.Sum();       //folosim .Sum();
            Console.WriteLine(sum);       //afisare tastatura
        }
    }
}
