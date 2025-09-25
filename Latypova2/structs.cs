using Structs;

namespace Structs
{
    struct User
    {
        public string name;
        public string city;
        public int age;
        public string pin;
        public void Answer()
        {
            Console.WriteLine($"Имя пользователя:{name}\n" +
                $"Город проживания:{city}\n" +
                $"Возраст:{age}\n" +
                $"PIN-код:{pin}\n");
        }
    }
    struct Student
    {
        public string first_name;
        public string last_name;
        public int age;
        public string ident;
        public string stage;
        public float volume;
    }
    struct Alcohol
    {
        public string name;
        public int procent;
    }
}
