using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Player : IPlayable, IRecordable
    {
        /* Если название одного метода в двух интерфейсах одинаково,
         и оба реализуются в производном классе, то используем конструкцию:
         void IИмяИнтерфейса1.Метод() {...}
        */
        void IPlayable.Pause()
        {
            Console.WriteLine("Просмотр с диска в режиме паузы");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Просмотр с диска окончен");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Запись на диск в режиме паузы");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Запись на диск окончена");
        }

        /* Если в двух интерфейсах используются разные методы,
         и оба реализуются в производном классе, то используем конструкцию:
         public void Метод1(){...}
         public void Метод2(){...}
        */
        public void Play()
        {
            Console.WriteLine("Просмотр с диска начат");
        }

        public void Record()
        {
            Console.WriteLine("Запись на дик начата");
        }
    }
}
