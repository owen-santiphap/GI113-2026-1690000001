/*
 * Student ID : 1690000001
 * Name       : Lab02
 * Section    : 129D
 * No.        : 99
 * Course     : GI113 Computer Programming (GI)
 */
 
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            
            // Lab02 Part A
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            //Part B
            // ---------- Part B: My Own Game (SAMPLE ONLY — students design their own theme/values) ----------
            // เกณฑ์การตรวจ Part B: 4 ตัวละคร x 5 stat/ตัว, รวมกันครบ 6 ชนิดข้อมูล, มี label กำกับ, ใช้ $"..." ทุกจุด
            // ตัวอย่างธีมนี้ (ทีมนักผจญภัย 4 คน) เป็นแค่ 1 วิธี ไม่ใช่คำตอบเดียวที่ถูก ห้ามหักคะแนนถ้าธีม/ค่าไม่เหมือนตัวอย่างนี้

            string hero1Name = "Anya";
            int hero1Hp = 120;
            float hero1Atk = 18.5f;
            double hero1CritRate = 0.15;
            char hero1Rank = 'A';

            

            Console.WriteLine("----- HERO 1 -----");
            Console.WriteLine($"Name: {hero1Name}");
            Console.WriteLine($"HP: {hero1Hp}");
            // 1. การปริ้นค่าใหม่ โดยใช้ตัวแปรใหม่
            string hero2Name = "Max";
            int hero2Hp = 200;
            Console.WriteLine("----- HERO 2 -----");
            Console.WriteLine($"Name: {hero2Name}");
            Console.WriteLine($"HP: {hero2Hp}");
            
            // 2. การปริ้นค่าใหม่ โดยใช้ตัวแปรเดิม ผ่านการ assign ค่าเข้าใหม่
            string heroName = "Min";
            int money = 100;
            Console.WriteLine("----- HERO 3 -----");
            Console.WriteLine($"Name: {heroName}");
            Console.WriteLine($"HP: {money}");

            heroName = "Sum";
            money = 300;
            Console.WriteLine("----- HERO 4 -----");
            Console.WriteLine($"Name: {heroName}");
            Console.WriteLine($"HP: {money}");

            // 1. การเว้นบรรทัดแบบปริ้นช่องว่าง
            Console.WriteLine("I AM HUNGRY");
            Console.WriteLine();
            Console.WriteLine("I GO EAT");

            // 2. แบบใช้ \n เพื่อเว้นบรรทัด
            Console.WriteLine("\nI AM HUNGRY\n");
            Console.WriteLine("I GO EAT");

            // 3. แบบใช้ \n และลดการพิมพ์ Console.Write
            Console.WriteLine("\nI AM HUNGRY\n\nI GO EAT");

            // 4. แบบ Hybrid ใช้บรรทัดใหม่ และ \n รวม +
            Console.WriteLine("\nI AM HUNGRY" +
                "\nI GO EAT" +
                "\nI AM SLEEPY" +
                "\nI GO SLEEP");
        }
    }
}
