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
            
        }

        void IRecordable.Pause()
        {

        }

        void IPlayable.Stop()
        {

        }

        void IRecordable.Stop()
        {

        }

        /* Если в двух интерфейсах используются разные методы,
         и оба реализуются в производном классе, то используем конструкцию:
         public void Метод1(){...}
         public void Метод2(){...}
        */
        public void Play()
        {

        }

        public void Record()
        {

        }
    }
}
