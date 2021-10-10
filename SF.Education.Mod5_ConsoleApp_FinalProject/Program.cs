using System;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace SF.Education.Mod5_ConsoleApp_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!");
            (string Name, string LastName, int Age, bool haspets, string[] Pets, bool hascolors, string[] Colors) myUser = EnterUser();

            ShowData(myUser);
            Console.ReadKey();
        }

        static void ShowData(
            (string Name, string LastName, int Age, bool haspets, string[] Pets, bool hascolors, string[] Colors) sUser)
        {
            Console.WriteLine("Вывод данных о пользователе:");
            Console.WriteLine("Имя: " + sUser.Name);
            Console.WriteLine("Фамилия: " + sUser.LastName);
            Console.WriteLine("Возраст: " + sUser.Age);
            Console.WriteLine("Наличие питомцев: " + sUser.haspets);
            if (sUser.haspets)
            {
                Console.WriteLine("Количество питомцев: " + sUser.Pets.Length);
                //Вывод имен питомцев
                foreach (var el in sUser.Pets)
                {
                    Console.WriteLine(el);
                }
            }

            Console.WriteLine("Наличие любимых цветов: " + sUser.hascolors);
            if (sUser.hascolors)
            {
                Console.WriteLine("Количество цветов: " + sUser.Colors.Length);
                //Вывод цветов
                foreach (var el in sUser.Colors)
                {
                    Console.WriteLine(el);
                }
            }


        }

        /// <summary>
        /// Создание массива имен животных
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static string[] CreateArrayPets(int num)
        {
            var result = new string[num];
            for (int i = 0; i < num; i++)
            {

                string namePet;
                do
                {
                    Console.WriteLine("Введите имя вашего животного с большой буквы, питомец {0}:", i + 1);
                    namePet = Console.ReadLine();
                } while (!CheckName(namePet));

                result[i] = namePet;

            }

            return result;
        }
        /// <summary>
        /// Создание массива любимых цветов
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static string[] CreateArrayСolors(int num)
        {
            var result = new string[num];
            for (int i = 0; i < num; i++)
            {

                string nameColor;
                do
                {
                    Console.WriteLine("Введите название вашего цвета, цвет {0}:", i + 1);
                    nameColor = Console.ReadLine();
                } while (!CheckColor(nameColor));

                result[i] = nameColor;

            }

            return result;
        }
        /// <summary>
        /// Задание кортежа с данными пользователя без питомцев и цветов
        /// </summary>
        /// <returns></returns>
        static (string Name, string Lastname, int Age, bool haspets, string[] Pets, bool hascolors, string[] Colors) EnterUser()
        {
            (string Name, string LastName, int Age, bool haspets, string[] Pets, bool hascolors, string[] Colors) User;

            Console.WriteLine("Введите имя:");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            User.LastName = Console.ReadLine();

            string age;
            int intage;

            do
            {
                Console.WriteLine("Введите возраст цифрами:");
                age = Console.ReadLine();
            } while (!CheckNum(age, out intage));

            User.Age = intage;

            Console.WriteLine("Есть ли у вас питомец?");
            if (Console.ReadLine().ToUpper() == "ДА")
            {
                string countPets;
                int intcountPets;
                do
                {
                    Console.WriteLine("Введите, сколько у вас питомцев?");
                    countPets = Console.ReadLine();
                } while (!CheckNum(countPets, out intcountPets));

                User.haspets = true;
                User.Pets = CreateArrayPets(intcountPets);
            }
            else
            {
                User.haspets = false;
                User.Pets = null;
            }
            Console.WriteLine("Есть ли у вас любимые цвета?");
            if (Console.ReadLine().ToUpper() == "ДА")
            {
                string countColors;
                int intcountColors;
                do
                {
                    Console.WriteLine("Введите, сколько у вас любимых цветов?");
                    countColors = Console.ReadLine();
                } while (!CheckNum(countColors, out intcountColors));

                User.hascolors = true;
                User.Colors = CreateArrayСolors(intcountColors);
            }
            else
            {

                User.hascolors = false;
                User.Colors = null;
            }

            return User;


        }
        /// <summary>
        /// проверка ввода на число изпримера подсказки
        /// </summary>
        /// <param name="number"></param>
        /// <param name="corrnumber"></param>
        /// <returns></returns>
        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return true;
                }
                else
                {
                    corrnumber = 0;
                    return false;
                }
            }
            else
            {
                corrnumber = 0;
                return false;
            }
        }
        /// <summary>
        /// Проверка ввода имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static bool CheckName(string name)
        {
            //имя питомца с большой буквы
            Regex regex = new Regex("^[А-Я][а-я]*$");
            return regex.IsMatch(name);
        }
        /// <summary>
        /// //првоерка наименвоание цвета
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static bool CheckColor(string name)
        {

            Regex regex = new Regex("^[а-я]*$");

            // Здесь надо сделать еще проверку, а точно ли введенная строка является цветом? Пока ограничемся такой проверкой
            return regex.IsMatch(name);
        }

    }
}
