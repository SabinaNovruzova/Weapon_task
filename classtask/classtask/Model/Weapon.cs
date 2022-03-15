using System;
using System.Collections.Generic;
using System.Text;

namespace classtask.Model
{
    class Weapon
    {
        public int bulletCapacity;//gulle tutumu
        public int countBullet;//daraqdaki gulle sayi
        public int secondsOfCombDischarge;//daragin bosalma saniyesi
        public int shootingMode;//atis modu

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
    }
    
}
