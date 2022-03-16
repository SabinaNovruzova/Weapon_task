using classtask.Model;
using System;

namespace classtask
{   
    class Program
    {
        static void Main(string[] args)
        {
            Weapon wep = new Weapon(40, 30, 5, 4);
           
                int key = 0;
            do
            {
                Console.WriteLine("Reqem daxil edin : ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("1ci metod");
                        wep.Shoot();
                        break;
                    case 2:
                        Console.WriteLine("2ci metod");
                         wep.Fire();
                        break;
                    case 3:
                        Console.WriteLine("3cu metod");
                        if (wep.GetRemainBulletCount()==0)
                        {
                            Console.WriteLine("daraq doludur");                              
                        }
                        else if (wep.GetRemainBulletCount()>0)
                        {
                            Console.WriteLine($"{"daragin dolmasi ucun"} {wep.GetRemainBulletCount()} {"gulle lazimdir"}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("4cu metod");
                        wep.Reload();
                        Console.WriteLine("daraq doldu");
                        break;
                    case 5:
                        Console.WriteLine("5ci  metod");
                        wep.ChangeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("Sagolun");
                        break;
                    case 7:
                        Console.WriteLine("7ci metod");
                        wep.Editing();
                        break;
                    case 0:
                        Console.WriteLine("0ci  metod");
                        Console.WriteLine($"{"Daragin tutumu:"} {wep.bulletCapacity}");
                        Console.WriteLine($"{"Daraqdaki gulle sayi:"} {wep.countBullet}");
                        Console.WriteLine($"{"Daragin bosalma saniyesi:"} {wep.secondsOfCombDischarge}");
                        Console.WriteLine($"{"Atis modu:"} {wep.shootingMode}");
                        break;
                    default:
                        Console.WriteLine("Sehv daxil etdiniz");
                        break;
                }
            } while (key != 6);
        }
    }
}
