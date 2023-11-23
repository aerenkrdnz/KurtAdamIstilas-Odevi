using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurtAdamIstilasiOdev.Models
{
    public class Hero : BaseHero
    {
        
        public void Attack()
        {
            Random rnd = new Random();
            Damage = 0;
            if (Race == "İnsan")
                Damage += 10;
            else if (Race == "Yaratık")
                Damage += 6;
            else
                Damage += 8;
            switch (Class)
            {
                case "Gladyatör":
                    Damage += rnd.Next(15, 45);
                    break;
                case "Mızrakçı":
                    Damage += rnd.Next(30, 36);
                    break;
                case "Şaman":
                    Damage += rnd.Next(25, 40);
                    break;
                case "Suikastçı":
                    Damage += rnd.Next(7, 77);
                    break;
            }
        }
    }
}
