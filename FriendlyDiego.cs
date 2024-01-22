using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /* Он может остановить одного противника на 9 секунд
     * Он может ударить кулаком пртивника
     * 
     * 
     * */
    internal class FriendlyDiego : Friendly
    {

        public override void Move()
        {
            moveSpeed = 11;
            
            Console.WriteLine("Я Diego я бегу со скоростью " + moveSpeed);
        }
        public void Stop() 
        {
            Console.WriteLine("Я остановил противника на 10 секунд");
        }
        public void Hit() 
        {
            Console.WriteLine("Я ударил противника");
        }
    }
}
