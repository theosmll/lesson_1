using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 - questionnaire

            /*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
            а) используя склеивание;
            б) используя форматированный вывод;
            в) *используя вывод со знаком $.*/

            Console.WriteLine("Здравствуйте, ответьте, пожалуйста, на несколько вопросов. ");
            Console.WriteLine("Введите своё имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою Фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите свой рост");
            string Height = Console.ReadLine();
            Console.WriteLine("Введите свой вес");
            string Weight = Console.ReadLine();


            Console.WriteLine(name + " " + surname + " " + age + " лет " + Height + " см " + Weight + " кг ");

            Console.WriteLine("{0} {1} {2} лет {3} см {4} кг", name, surname, age, Height, Weight);

            Console.WriteLine($"{name} {surname} {age} лет {Height} см {Weight} кг");

            Console.ReadLine();

            #endregion

            #region Task 2
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
            //Есть недостаток: если пользоователь введет рост через "." а не "," программа не сработает
            Console.Clear();
            Console.WriteLine("Давайте посчитаем ИМТ");
                double m;
                double h;
            Console.WriteLine("Введите свой вес в киллограммах");
            string inputM = Console.ReadLine();
            Console.WriteLine("Введите свой рост в метрах");
            string inputH = Console.ReadLine();

            m = double.Parse(inputM);
            h = double.Parse(inputH);

            double I = m / (h * h);

            Console.WriteLine($"Ваш ИМТ = {Math.Round(I, 2)}");
            Console.ReadLine();

            #endregion

            #region Task 2.0
            //Здесь исправила этот недостаток
            Console.Clear();
            Console.WriteLine("Давайте посчитаем ИМТ");

            double r;
            double v;

            Console.WriteLine("Введите свой вес в киллограммах");
            string inputR = Console.ReadLine();
            Console.WriteLine("Введите свой рост в сантиметрах");
            string inputV = Console.ReadLine();

            r = double.Parse(inputR);
            v = double.Parse(inputV);

            v = v / 100;

            double X = r / (v * v);

            Console.WriteLine($"Ваш ИМТ = {Math.Round(X,2)}");
            Console.ReadLine();

            #endregion

            #region Task 3
            /*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
            Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;*/
            Console.Clear();

            int x1;
            int x2;
            int y1;
            int y2;

            Console.WriteLine("Давайте посчитаем расстояние между точками");
            Console.WriteLine("Введите координату точки x1");
            string inputX1 = Console.ReadLine();
            Console.WriteLine("Введите координату точки x2");
            string inputX2 = Console.ReadLine();
            Console.WriteLine("Введите координату точки y1");
            string inputY1 = Console.ReadLine();
            Console.WriteLine("Введите координату точки y2");
            string inputY2 = Console.ReadLine();

            x1 = int.Parse(inputX1);
            x2 = int.Parse(inputX2);
            y1 = int.Parse(inputY1);
            y2 = int.Parse(inputY2);

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(Math.Round(r,2));
            Console.ReadLine();

            #endregion
 
            #region Task 4a
            /*4. Написать программу обмена значениями двух переменных.
            а) с использованием третьей переменной;*/
            Console.Clear();

            int x;
            int y;
            int z;
            Console.WriteLine("Введите первое число");
            string inputX = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string inputY = Console.ReadLine();
            x = int.Parse(inputX);
            y = int.Parse(inputY);

            z = y;
            y = x;
            x = z;


            Console.WriteLine("Первое число " + x);
            Console.WriteLine("Второе число " +  + y);

            Console.ReadLine();

            #endregion

            #region Task 4b
            //б) *без использования третьей переменной.
            Console.Clear();
            int q;
            int q1;

            Console.WriteLine("Введите первое число");
            string inputQ = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string inputQ1 = Console.ReadLine();

            q = int.Parse(inputQ1);
            q1 = int.Parse(inputQ);

            Console.WriteLine("Первое число " + q);
            Console.WriteLine("Второе число " + q1);
            Console.ReadLine();

            #endregion

            #region Task 5
            /*а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y)*/
            string data = "Горшунова Алла. Город Астрахань. ";

            int width = Console.WindowWidth, height = Console.WindowHeight;
            Print(data);
            while (true)
            {
                if (width != Console.WindowWidth || height != Console.WindowHeight)
                {
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    Print(data);
                }
            }

           

            
            #endregion

        }
        static void Print(string ms)
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - ms.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine($"{ms}");
            Console.ReadLine();
        }
        static void Pause()
        {
            Environment.Exit(0);
        }
    } 
    
}
