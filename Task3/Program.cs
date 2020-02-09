/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
Написать программу, которая выполняет проигрывание и запись. 
*/
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IRecordable functionRecord = player as IRecordable;
            IPlayable functionPlay = player as IPlayable;
            
            //MakeAMovie();

            Console.ReadKey();

            //void MakeAMovie()
            //{
            //    Console.WriteLine("Запись на диск начата.\n");
            //}
        }
    }
}
