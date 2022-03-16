using System;
using System.Collections.Generic;
using System.Text;

namespace classtask.Model
{
    class Weapon
    {
        public int bulletCapacity { get; set; }
        public int countBullet { get; set; }
        public int secondsOfCombDischarge { get; set; }
        public int shootingMode { get; set; }
        

        public Weapon(int bulletCapacity,int countBullet,int secondsOfCombDischarge, int shootingMode)
        {
            this.bulletCapacity = bulletCapacity;
            this.countBullet = countBullet;
            this.secondsOfCombDischarge = secondsOfCombDischarge;
            this.shootingMode = shootingMode;
        }
        public void Shoot()
        {
            int a = countBullet;
            if (bulletCapacity>0 || countBullet>0)
            {
                a -= 1;
                Console.WriteLine("BUM! ates acildi");
            }
            else
            {
                Console.WriteLine("atmaq ucun gulleniz yoxdur");
            } 
        }
        public void Fire()
        {
            int secondShootEnd = (countBullet * secondsOfCombDischarge) / bulletCapacity;
            Console.WriteLine(secondShootEnd);
        }
        public int GetRemainBulletCount()
        {
            int numberOfBulletsNeeded = bulletCapacity - countBullet;
            return numberOfBulletsNeeded;
        }
       public void Reload()
        {
            countBullet = bulletCapacity;
        }
        public void ChangeFireMode()
        {
            if (shootingMode==3)
            {
                shootingMode = 4;
                Console.WriteLine("avtomatikdir");
            }
            else if (shootingMode==4)
            {
                shootingMode = 3;
                Console.WriteLine("teklidir");
            }
        }
        public void Editing()
        {
            Console.WriteLine("tutumu redakte etmek ucun yeni qiymet verin:");
            bulletCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("gulle sayini deyismek ucun yeni qiymet verin:");
            countBullet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("daragin bosalma saniyesini deyismek ucun yeni qiymet yazin:");
            secondsOfCombDischarge = Convert.ToInt32(Console.ReadLine());
        }
    }
    
}
