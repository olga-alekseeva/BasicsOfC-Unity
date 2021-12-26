using System;

namespace RollingBall
{
    public class MyException : Exception
    {
        public int Value { get; }
        public MyException(string message) : base(message)
        {

        }
      
    }
}