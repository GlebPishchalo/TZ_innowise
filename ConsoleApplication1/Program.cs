using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
       
     
        static void Main(string[] args)
        {
            BooksCatalog a = new BooksCatalog();
           // a.LoadData();
            Console.WriteLine("Выберите требуемое действие:\n 1.Список книг\n 2. Список авторов\n 3.Добавить книгу\n 4.Удалить книгу\n 5. Книги по коду автора");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                
                case 1: a.LoadBooks(); break;
                case 2: a.LoadAuthors(); break;
                case 3:
                    Console.WriteLine("Введите название книги");
                    string nazv_knigi;
                    do { nazv_knigi = Console.ReadLine(); }
                    while ((nazv_knigi.Length) > 30 && (nazv_knigi.Length <1));
                    Console.WriteLine("Введите год книги:");
                    int year_book;
                    do { year_book= Convert.ToInt32(Console.ReadLine()); }
                    while ((year_book>2019)&&(year_book<868)); a.InsertBook(nazv_knigi,year_book);
                    Console.WriteLine("Введите количество авторов:");
                    int n;
                    n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {

                        Console.WriteLine("Введите автора:");
                        string auth_knigi;
                        do { auth_knigi = Console.ReadLine(); }
                        while ((auth_knigi.Length) > 20 && (auth_knigi.Length < 1));
                        a.InsertAuthors(auth_knigi);
                        a.InsertBA();
                    }

                    break;
                case 4: Console.WriteLine("Введите код книги:"); try { int del_book = Convert.ToInt32(Console.ReadLine()); a.DeleteBook(del_book); }catch { Console.WriteLine("Neverniy nomer"); }break;
                case 5: Console.WriteLine("Введите код автора:"); int auth_code = Convert.ToInt32(Console.ReadLine()); a.FindBooks(auth_code);break;
                default: Console.WriteLine("Некоректные данные");break;


            }
            Console.ReadKey();

           
        }
    } 
}
