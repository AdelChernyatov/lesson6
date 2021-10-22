using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace hw
{
    class Star_ship
    {
        private string nameship;
        public string Get_name_ship()
        {
            return nameship;
        }
        public void Set_name_ship(string name_ship)
        {
            nameship = name_ship;
        }
        private bool invisibility;
        public bool Get_invisibility()
        {
            return invisibility;
        }
        public void Set_invisibility(bool invisibility_)
        {
            invisibility = invisibility_;
        }
        private bool cannon;
        public bool Get_cannon()
        {
            return cannon;
        }
        public void Set_cannon(bool cannon_)
        {
            cannon = cannon_;
        }

    }
    class Sith_ship : Star_ship
    {

        private bool Superspeed;
        private bool Teleporation;
        public Sith_ship(bool superspeed, bool teleparation)
        {
            Superspeed = superspeed;
            Teleporation = teleparation;
        }
        public bool Get_superspeed()
        {
            return Superspeed;
        }
        public void Set_superspeed(bool super_speed)
        {
            Superspeed = super_speed;
        }

        public bool Get_teleportation()
        {
            return Teleporation;
        }
        public void Set_teleportation(bool teleportation_)
        {
            Teleporation = teleportation_;
        }
        public void End()
        {
            Console.WriteLine("Ваш корабль готов");
        }
    }
    class Djeday_ship : Star_ship
    {
        public Djeday_ship(bool powerful_engine, bool laser_gun)
        {
            Powerful_engine = powerful_engine;
            Laser_gun = laser_gun;
        }
        private bool Powerful_engine;
        public bool Get_powerful_engine()
        {
            return Powerful_engine;
        }
        public void Set_powerful_engine(bool powergul_engine) 
        {
            Powerful_engine = powergul_engine;
        }
        private bool Laser_gun;
        public bool Get_Laser_gun()
        {
            return Laser_gun;
        }
        public void Set_Laser_gun(bool laser_gun)
        {
            Laser_gun = laser_gun;
        }


    }

    class LegoPerson
    {
        private string name;
        public string Get_name()
        {
            return name;
        }
        public void Set_name(string name_)
        {
            name = name_;
        }

        private bool arms;
        public bool Get_arms()
        {
            return arms;
        }
        public void Set_arms(bool arms_)
        {
            arms = arms_;
        }
        private bool legs;
        public bool Get_legs()
        {
            return legs;
        }
        public void Set_legs(bool legs_)
        {
            legs = legs_;
        }

    } 
    class Ninja : LegoPerson
    {
         private string name;
         public string Get_name()
         {
            return name;
         }
         public void Set_name(string name_) 
         {
           name = name_;
         }
         private string weapon;
         public string Get_weapon()
         {
            return weapon;
         }
         public void Set_weapon(string weapon_)
         {
            weapon = weapon_;
         }
         private bool armor;
         public bool Get_armor()
         {
            return armor;
         }
         public void Set_armor(bool armor_)
         {
             armor = armor_;
         }
         private bool helm;
         public bool Gethelm()
         {
             return helm;
         }
         public void Sethelm(bool helm_)
         {
             helm = helm_;
         }
    }

    class Program
    {
       static string Reading()
       {
          string workwithFile = "D:\\lesson6\\names.txt";
          string readAllFile = File.ReadAllText(workwithFile);
          string add = Console.ReadLine().ToLower();
          File.AppendAllText(workwithFile, Environment.NewLine); // Добавим новую строку в файл
          File.AppendAllText(workwithFile, add);
          string newFile = File.ReadAllText(workwithFile);
          string[] readEveryLine = new string[10];
          readEveryLine = File.ReadAllLines(workwithFile);
          string will_find = "";
          for (int i = 0; i < readEveryLine.Length; i++)
          {
            bool find = readEveryLine[i].Contains(add);
            if (find)
            {
              will_find = readEveryLine[i];
            }
          }
          return will_find;
       }
       static bool Verification() //проверка на double исключения
       {
           bool n = false;
           if (bool.TryParse(Console.ReadLine(), out n)) { }
           else { Console.WriteLine("Вы ввели неверный формат"); }
           return n;

       }

       static void Main(string[] args)
       {
           Console.WriteLine("Реализован процесс постройки двух звездных кораблей и lego-человечка");
           Console.WriteLine("Назовите своего lego-человечка");
           string name_ = Reading();
           Ninja p = new Ninja();
           p.Set_name(name_);
           Console.WriteLine("Присоединили ли вы руки  вашему приятелю,в случае неверного формата входных данных выведеся их отстутсвие(true/false)");
           bool arms_ = Verification();
           p.Set_arms(arms_);
           Console.WriteLine("Присоединили вы ноги вашему приятелю,в случае неверного формата входных данных выведеся их отстутсвие(true/false)");
           bool legs_ = Verification();
           p.Set_legs(legs_);
           Console.WriteLine("Введите оружие вашего героя");
           p.Set_weapon(Console.ReadLine());
           Console.WriteLine("Наличие шлема(true/false)");
           bool helm_ = Verification();
           p.Sethelm(helm_);
           Console.WriteLine("Наличие доспехов(true/false)");
           bool armor_ = Verification();
           p.Set_armor(armor_);
           Console.WriteLine("Показатели вашего героя ");
           Console.WriteLine("имя: " + p.Get_name());
           Console.WriteLine("руки " + p.Get_arms());
           Console.WriteLine("ноги " + p.Get_legs());
           Console.WriteLine("оружие " + p.Get_weapon());
           Console.WriteLine("шлем " + p.Gethelm());
           Console.WriteLine("доспехи " + p.Get_armor());
           Console.WriteLine("\n");

           Console.WriteLine("Перейдем к постройке корабля ситхов");
           Console.WriteLine( "Есть ли у него суперскорость(true/false)" );
           bool superspeed_ = Verification();
           Console.WriteLine("Умеет ли он телепортироваться (true/false)");
           bool teleportation_ = Verification();
           Sith_ship ship = new Sith_ship(superspeed_, teleportation_);
           Console.WriteLine("Дайте имя кораблю");
           ship.Set_name_ship(Console.ReadLine());
           Console.WriteLine("Имеет ли он невидимость(true/false)");
           bool invisibility_ = Verification();
           ship.Set_invisibility(invisibility_);
           Console.WriteLine("Имеет ли он орудие");
           bool cannon_ = Verification();
           ship.Set_cannon(cannon_);
           ship.Set_superspeed(superspeed_);
           ship.Set_teleportation(teleportation_);
           Console.WriteLine("Хар-ки корабля ситхов");
           Console.WriteLine("имя: " + ship.Get_name_ship());
           Console.WriteLine("невидимость " + ship.Get_invisibility());
           Console.WriteLine("оружие " + ship.Get_cannon());
           Console.WriteLine("суперскорость " + ship.Get_superspeed());
           Console.WriteLine("телепортация " + ship.Get_teleportation());
           Console.WriteLine("\n");

           Console.WriteLine("Перейдем к постройке корабля джедаев");           
           Console.WriteLine("Есть ли у него мощный двигатель(true/false)");
           bool powerful_engine_ = Verification();
           Console.WriteLine("Имеет ли он лазер (true/false)");
           bool laser_gun = Verification();
           Djeday_ship ship1 = new Djeday_ship(powerful_engine_,laser_gun);
           Console.WriteLine("Дайте имя кораблю");
           ship1.Set_name_ship(Console.ReadLine());
           Console.WriteLine("Имеет ли он невидимость(true/false)");
           bool invisibility1_ = Verification();            
            ship1.Set_Laser_gun(laser_gun);
            ship1.Set_invisibility(invisibility1_);
            ship1.Set_powerful_engine(powerful_engine_);

            Console.WriteLine("Хар-ки корабля джедаев");
            Console.WriteLine("имя: " + ship1.Get_name_ship());
            Console.WriteLine("невидимость " + ship1.Get_invisibility());
            Console.WriteLine("лазер " + ship1.Get_Laser_gun());
            Console.WriteLine("мощный двигатель " + ship1.Get_powerful_engine());
            




        }

    }
}
