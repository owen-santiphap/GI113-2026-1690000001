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
        }
    }
}
