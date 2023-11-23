using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurtAdamIstilasiOdev.Models
{
    public class EnemyHero : BaseHero
    {
        public void Attack()
        {
            Random rnd = new Random();
            Damage = 0;
            if (Race == "Jamiryo")
                Damage += 12;
            else if (Race == "Uzaylı")
                Damage += 6;
            else
                Damage += 8;
            switch (Class)
            {
                case "A(+)":
                    Damage += rnd.Next(15, 45);
                    break;
                case "Ufo":
                    Damage += rnd.Next(30, 36);
                    break;                
                case "Simitçi":
                    Damage += rnd.Next(7, 77);
                    break;
            }
        }
    }
}
