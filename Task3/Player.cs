using System;

namespace Task3
{
    class Player : IPlayable, IRecordable
    {
        string _footageForPlay = "3HM:0837V@42f289", _footageForRecord;

        /* Если название одного метода в двух интерфейсах одинаково,
         и оба реализуются в производном классе, то используем конструкцию:
         void IИмяИнтерфейса1.Метод() {...}
        */
        void IPlayable.Pause()
        {
            Console.WriteLine("Просмотр с диска в режиме паузы.");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Просмотр с диска окончен.");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Запись на диск в режиме паузы.");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Запись на диск окончена.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Просмотреть запись с диска?\n1 - да;\n2 - нет\nМой ответ = ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.ResetColor();
                    Console.WriteLine($"Просмотр с диска начат.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($"Всего {_footageForRecord.Length} кадров: ");
                    for (int c = 0; c < _footageForRecord.Length; c++)
                    {
                        Console.Write("|" + _footageForRecord[c] + "| ");
                    }
                    Console.WriteLine("\n");
                    break;
                default:
                    break;
            }
            Console.ResetColor();
        }

        /* Если в двух интерфейсах используются разные методы,
         и оба реализуются в производном классе, то используем конструкцию:
         public void Метод1(){...}
         public void Метод2(){...}
        */
        public void Play()
        {
            Console.WriteLine("Просмотр с диска начат.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Всего {_footageForPlay.Length} кадров: ");
            for (int b = 0; b < _footageForPlay.Length; b++)
            {
                Console.Write("|" + _footageForPlay[b] + "| ");
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public void Record()
        {
            Console.WriteLine("Запись на диск начата.");
            for (int a = 1; a <= 9; a++)
            {
                _footageForRecord += a;
            }
        }
    }
}
