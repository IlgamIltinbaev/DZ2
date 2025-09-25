using Structs;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace Latypova2
{ 

    class Programm
    {

        static void Main(string[] args)
        {
            //Упр 1
            Console.WriteLine($"\tУпражнение 1");
            Console.WriteLine("Bool - хранит значение true или false\n" +
                "Byte - [255] - [0]\n" +
                "Sbyte - [127] - [-128]\n" +
                "Short - [32767] - [-32768]" +
                "UShort - [65535] - [0]\n" +
                "Int - [2147483647] - [-2147483648]\n" +
                "Uint - [4294967295] - [0]\n" +
                "Long - [9223372036854775807] - [–9223372036854775808]\n" +
                "Ulong - [18446744073709551615] - [0]\n" +
                "Float - [3.4*10^38] - [-3.4*10^38]\n" +
                "Double - [±1.7*10^308] - [±5.0*10^(-324)]\n" +
                "Decimal - [±7.9228*10^28] - [±1.0*10^(-28)]\n" +
                "Char - храни т одиночный символ в кодировке Unicode\n" +
                "String - хранит набор символов Unicode\n" +
                "Object - хранит значение любого типа данных\n");
            
            //Упр 2
            Console.WriteLine($"\tУпражнение 2");
            User user = new();
            Console.Write("Введите ваше имя:");
            user.name = Console.ReadLine();
            Console.Write("Введите город проживания:");
            user.city = Console.ReadLine();
            Console.Write("Введите ваш возраст:");
            user.age = int.Parse(Console.ReadLine());
            Console.Write("Введите ваш пин-код:");
            user.pin = Console.ReadLine();
            user.Answer();
            
            //Упр 3
            Console.WriteLine($"\tУпражнение 3");
            Console.Write("ВВедите вашу строчку:");
            string str = Console.ReadLine();
            int len_str = str.Length;
            string uper = str.ToUpper();
            string lower = str.ToLower();
            string new_string = "";
            for (int i = 0; i < len_str; i++)
            {
                if (str[i] == uper[i])
                {
                    new_string += lower[i];
                }
                else
                {
                    new_string += uper[i];
                }
            }
            Console.WriteLine(new_string+'\n');
            
            //Упр 4
            Console.WriteLine($"\tУпражнение 4");
            Console.Write("ВВедите вашу строчку:");
            string line = Console.ReadLine();
            Console.Write("ВВедите вашу ПОДстрочку:");
            string downline = Console.ReadLine();
            int count = line.Split(downline).Length-1;
            Console.WriteLine($"Кол-во вхождений: {count}\n");
            
            //Упр 5
            Console.WriteLine($"\tУпражнение 5");
            Console.Write("Введите стандартную цену:");
            float norm_price = int.Parse(Console.ReadLine());
            Console.Write("Введите процент скидки:");
            float free_proc = int.Parse(Console.ReadLine());
            Console.Write("введите сумму отпуска:");
            float holi_price = int.Parse(Console.ReadLine());
            float impact = norm_price - norm_price * (100 - free_proc)/100;
            Console.WriteLine($"Вы должны привезти {(int)(holi_price/impact)} бутылок\n");
            
            //Упр 6
            Console.WriteLine($"\tУпражнение 6");
            Student first = new()
            {
                first_name = "Артур",
                last_name = "Микаэлян",
                age = 23,
                ident = "1231-2344-3434-5565",
                stage = "Любитель",
                volume = 500
            };
            Student second = new()
            {
                first_name = "Майкoл",
                last_name = "Демидов",
                age = 31,
                ident = "3454-5678-4523-5467",
                stage = "Алкоголик",
                volume = 300
            };
            Student third = new()
            {
                first_name = "Евгений",
                last_name = "Кузьмин",
                age = 26,
                ident = "2341-7897-5454-3434",
                stage = "Праздничный",
                volume = 600
            };
            Student fourth = new()
            {
                first_name = "Валентин",
                last_name = "Будейко",
                age = 19,
                ident = "9217-9987-2028-9494",
                stage = "Зожник",
                volume = 800
            };
            Student fifth = new()
            {
                first_name = "Антон",
                last_name = "Мартынов",
                age = 32,
                ident = "9834-0023-2111-3255",
                stage = "Алкологик",
                volume = 400
            };
            Alcohol Konyak = new()
            {
                name = "Дары Востока",
                procent = 25
            };
            Alcohol Vodka = new()
            {
                name = "Пять озёр",
                procent = 40
            };
            Alcohol Shamp = new()
            {
                name = "Бугульма",
                procent = 15
            };
            Alcohol Viski = new()
            {
                name = "Jack Daniel's",
                procent = 30
            };
            float mast_volume = (first.volume + second.volume + third.volume + fourth.volume + fifth.volume) / 1000;
            float mast_alko = (first.volume * Konyak.procent + second.volume * Vodka.procent + third.volume * Shamp.procent + fourth.volume + fifth.volume * Viski.procent) / 100 / 1000;
            Console.WriteLine($"Общий объём выпитого: {mast_volume} литров\n" + $"Объём алкоголя: {mast_alko} литров");
            Console.WriteLine($"{first.first_name}:{first.volume * Konyak.procent/100/mast_alko/1000}% алкоголя и {first.volume * (100-Konyak.procent) / 100/mast_volume/1000}% жидкости\n" +
                $"{second.first_name}:{second.volume * Vodka.procent / 100 / mast_alko / 1 / 1000}% алкоголя и {second.volume * (100 - Vodka.procent) / 100/mast_volume/1000}% жидкости\n" +
                $"{third.first_name}:{third.volume * Shamp.procent / 100 / mast_alko/1000}% алкоголя и {third.volume * (100 - Shamp.procent) / 100 / mast_volume / 1000}% жидкости\n" +
                $"{fourth.first_name}:{ fourth.volume * 0 / 100 / mast_alko/1000}% алкоголя и {fourth.volume * (100 - 0) / 100 / mast_volume / 1000}% жидкости\n" +
                $"{fifth.first_name}:{fifth.volume * Viski.procent / 100 / mast_alko / 1000}% алкоголя и {fifth.volume * (100 - Viski.procent) / 100 / mast_volume / 1000}% жидкости\n");
        }
    }
}