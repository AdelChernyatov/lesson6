using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    class Bank_account
    {
        private int account_number;
        public int Getnumber()
        {
            return account_number;
        }
        public void Setnumber(int num)
        {
            account_number = num;
        }
        private int balance;
        public int Getnbalance()
        {
            return balance;
        }
        public void Setbalance(int _balance)
        {
            balance = _balance;

        }

        private string type_bank_number;
        public string Gettype()
        {
            return type_bank_number;
        }
        public void Settype(string type)
        {
            type_bank_number = type;
        }
        //метод для задания 2
        static int account_number1 = 123435;
        public int Getnumber1()
        {
            return account_number1 + 1;
        }
        //метод для задания3
        public int Take_away(int balanc, int money)
        {
            return balanc - money;
        }
        public int Put(int balanc, int money)
        {
            return balanc + money;
        }
    }
    //класс для дз
    class Building
    { private string name_of_building;
        public string Get_name()
        {
            return name_of_building;
        }
        public void Set_name(string name_of_building_)
        {
            name_of_building =name_of_building_;
        }
        private double height;
        public double Getheight()
        {
            return height;
        }
        public void Setheight(double height_)
        {
            height = height_;
        }

        private int floor;
        public int Getfloors()
        {
            return floor;
        }
        public void Setfloor(int floor_)
        {
            floor = floor_;
        }
        private int floats;
        public int Getfloat()
        {
            return floats;
        }
        public void Setfloat(int floats_) 
        {
            floats = floats_;
        }
        private int porch;  //подъезды
        public int Getporch() 
        {
            return porch;
        }
        public void Setporch(int porch_) 
        {
            porch = porch_;
        }
        public void  Heightfloor(double height_,int floor_)
        {
            Console.WriteLine("Высота одного этажа " +height_/floor_ + " метров");
        }
        public void Quantity_floats_on_porch(int floats_, int porch_)
        {
            Console.WriteLine("Кол-во квартир в одном подъзде " + floats/porch);
        }
        public void Quantity_floats_on_floor(int floats_, int porch_, int floor_)
        {
            Console.WriteLine("Кол-во квартир на этаже " +(floats_/porch_/floor_));

        }
        static int house_number1 = 1;
        public int Getnumber_house()
        {
            return house_number1 + 1;
        }
    }

    class Program
    {
        static int Verification() //проверка на int исключения
        {
            int n = 0;
            if (int.TryParse(Console.ReadLine(), out n))
            {

            }
            else { Console.WriteLine("Вы ввели неверный формат"); }
            return n;

        }
        static double Verificationdouble() //проверка на double исключения
        {
            double n = 0;
            if (double.TryParse(Console.ReadLine(), out n)) { }
            else { Console.WriteLine("Вы ввели неверный формат"); }
            return n;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("task1");             
            Bank_account pers = new Bank_account();
            Console.WriteLine("Введите номер банковского счета");
            int check = Verification();
            pers.Setnumber(check);
            //Console.WriteLine("Номер банковского счета: " + pers.Getnumber());
            Console.WriteLine("Введите баланс");
            int cash = Verification();
            pers.Setbalance(cash);
            //Console.WriteLine("Баланс: " + pers.Getnbalance());
            Console.WriteLine("Введите тип бансковского счета");
           // string types = Console.ReadLine();
            pers.Settype(Console.ReadLine());
            Console.WriteLine("Номер банковского счета: " + pers.Getnumber());
            Console.WriteLine("Баланс: " + pers.Getnbalance());
            Console.WriteLine("Тип банковского счета: " + pers.Gettype());

            Console.WriteLine("task2");
            Console.WriteLine("Ввдите кол-во уникальных номеров");
            int old_check = pers.Getnumber1();
            int new_check = Verification();           
             for (int i = 0; i < new_check; i++)
             {
               int d = old_check + i;
               Console.WriteLine("Уникальный номер: "+d);
             }
                       
            Console.WriteLine("task3");
            Console.WriteLine("Вы хотите внести или забрать деньги?");
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine("С какой суммой вы хотите произвести операцию");
            int money = Verification();           
            switch (answer)
            {
              case "забрать":
               if (money < cash)
               {
                 int d = pers.Take_away(cash, money);
                 Console.WriteLine(d);
               }
               else { Console.WriteLine("На балансе недостаточно средств"); }
               break;
              case "внести":
                int c = pers.Put(cash, money);
                Console.WriteLine(c);
               break;
              default:
                Console.WriteLine("Вы неверно указали операцию");
               break;
            }
            
            Console.WriteLine("task7.1");
            Building house = new Building();
            Console.WriteLine("Введите название здания");
            //string name_of_building = Console.ReadLine();
            house.Set_name(Console.ReadLine());
            Console.WriteLine("Введите высоту здания");
            double height_ = Verificationdouble();
            house.Setheight(height_);
            Console.WriteLine("Введите кол-во этажей");
            int floors_ = Verification();
            house.Setfloor(floors_);
            Console.WriteLine("Введите кол-во квартир");
            int floats_ = Verification();
            house.Setfloat(floats_);
            Console.WriteLine("Введите кол-во подъездов");
            int porch_ = Verification();
            house.Setporch(porch_);
            Console.WriteLine("Уникальный номер "+ house.Get_name());
            Console.WriteLine("Введите высоту " + house.Getheight());
            Console.WriteLine("Введите кол-во этажей "+house.Getfloors());
            Console.WriteLine("Введите кол-во квартир "+house.Getfloat());
            Console.WriteLine("Введите кол-во подъездов "+ house.Getporch());
            house.Heightfloor(height_, floors_);
            house.Quantity_floats_on_porch(floats_, porch_);
            house.Quantity_floats_on_floor(floats_, porch_, floors_);
            Console.WriteLine("Ввдите кол-во уникальных номеров");
            int old_number = house.Getnumber_house();
            int new_number = Verification();
            for (int i = 0; i < new_number; i++)
            {
                int g = old_number + i;
                Console.WriteLine("Уникальный номер: " + g);
            }

        }
    }
}
