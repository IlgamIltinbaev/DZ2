namespace Structurs
{ 
         enum Bank
    {
        Сберегательный,
        Текущий
    }

    enum Vuz
    {
        КГУ,
        КАИ,
        КХТИ
    }
    struct Case
    {
        public string num;
        public string type;
        public float balance;
        public void print()
        {
            Console.WriteLine($"Номер счёта:{num}\nТип счёта:{type}\nТекущий баланс:{balance}$" + '\n');
        }
    }
    struct Job
    {
        public string name;
        public object vuz;
        public void rez()
        {
            Console.WriteLine($"Работник:{name}\nМесто работы:{vuz}" + '\n');
        }
    }
}


