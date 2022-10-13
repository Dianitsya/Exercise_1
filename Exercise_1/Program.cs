using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarasi array int dengan ukuran 31
            int[] tasya = new int[31];

            //Deklarasi variabel int untuk menyimpan banyaknya data pada array
            int n;

            //Deklarasi variabel int yang ada di dalam array
            int i, dm, min_index, temp, pilih;
            {
                while (true)
                {
                    //menentukan banyaknya data(n)
                    Console.Write("Masukkan banyaknya elemen pada array : ");
                    string s = Console.ReadLine();
                    n = Int32.Parse(s);
                    if (n <= 31)
                        break;
                    else
                        Console.WriteLine("\n Array dapat mempunyai maksimal 31 elemen.\n");
                }
                Console.WriteLine("");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Masukkan elemen array");
                Console.WriteLine("-----------------------");

                //memasukkan data ke array sebanyak n data
                for (i = 0; i <= n - 1; i++)
                {
                    Console.Write("<" + (i + 1) + ">");
                    tasya[i] = Convert.ToInt32(Console.ReadLine());
                }
                //Memilih cara pengurutan data
                Console.Write("\n");
                Console.WriteLine("Silahkan memilih pengurutan data");
                Console.WriteLine("1. Bubble sort");
                Console.WriteLine("2. Selection sort");
                Console.WriteLine("3. Insertion sort ");
                Console.WriteLine("--------------------------------");
                Console.Write("Pilih : ");
                pilih = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (pilih)
                {
                    case 1:
                        //menjalankan bubble sort
                        break;
                    case 2:
                        //menjalankan selection sort
                        for (dm = 0; dm < n - 2; dm++)
                        {
                            min_index = dm;
                            for (i = dm + 1; i <= n - 1; i++)
                            {
                                min_index = i;
                            }
                            temp = tasya[dm];
                            tasya[dm] = tasya[min_index];
                            tasya[min_index] = temp;
                        } 
                        break;
                        
                    case 3:
                        //menjalankan insertion sort
                        dm = 0;
                        for (i = 0; i <= n - 1; i++)
                        {
                            temp = tasya[i];
                            dm = i - 1;
                            while((dm >= 0) && (tasya[dm] >= temp))
                            {
                                tasya[dm + 1] = tasya[dm];
                                dm--;
                            }
                            tasya[dm + 1] = temp;
                        }
                        break;
                }

                //cetak data sesudah diurutkan
                Console.WriteLine();
                Console.WriteLine("Elemen array yang sudah tersusun");
                Console.WriteLine("--------------------------------");
                for (i = 0; i < n - 1; i++)
                {
                    Console.Write(tasya[i]);
                }
                Console.ReadKey();
            }
        }
    }
}
