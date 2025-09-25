using Structurs;

namespace Tumakov2
{
 
    class Programm
    {   
       
        static void Main(string[] args)
        {   //Упр 3.1
            Console.WriteLine($"\tУпражнение 3.1");
            Bank now = Bank.Сберегательный;
            Console.WriteLine($"Вид банковского счёта: {now}"+'\n');

            //Упр 3.2
            Console.WriteLine($"\tУпражнение 3.2");
            Case new_case = new();
            new_case.num = "2200-5308-1409-2323";
            new_case.type = "Сберегательный";
            new_case.balance = 25000;
            new_case.print();

            //Дз 3.1
            Console.WriteLine($"\tДомашнее задание 3.1");
            Job new_worker = new();
            Vuz new_vuz = Vuz.КАИ;
            new_worker.name = "Ахмедзянова Файруза Камиловна";
            new_worker.vuz = new_vuz;
            new_worker.rez();
            
        }
    }
}
