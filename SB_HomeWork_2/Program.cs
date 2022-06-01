using System;


namespace Example_001_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Иванов Иван Иванович";
            byte age = 55;
            string Email = "ivanov_II@ivanovo.com";
            double programming_point = 80;
            double maths_point = 50;
            double physics_point = 50;
            double sum_point = programming_point + maths_point + physics_point;
            double average_point = sum_point / 3;
            
           

            string pattern = "ФИО: {0} \nВозраст: {1}  \nЭлектронная почта: {2}  \nБаллы по программированию: {3}  \nБаллы по математике: {4}  \nБаллы по физике: {5}";
            
            Console.WriteLine(pattern,
                FullName,
                age,
                Email,
                programming_point,
                maths_point,
                physics_point);

            Console.ReadKey();

            Console.WriteLine($"Общий бал по всем предметам: {sum_point} \nСрединий бал: {average_point}");






        }
    }
}
