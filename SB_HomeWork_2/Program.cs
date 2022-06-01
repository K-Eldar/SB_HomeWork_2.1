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
            double programming_point = 87;
            double maths_point = 65;
            double physics_point = 78;

            string pattern = "Имя: {0} \nВозраст: {1}  \nЭлектронная почта: {2}  \nБаллы по программированию: {3}  \nБаллы по математике: {4}  \nБаллы по физике: {5}";
            
            Console.WriteLine(pattern,
                FullName,
                age,
                Email,
                programming_point,
                maths_point,
                physics_point);

           
        }
    }
}
