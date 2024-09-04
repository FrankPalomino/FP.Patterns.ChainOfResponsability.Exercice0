﻿namespace FP.Patterns.ChainOfResponsability.Exercice4
{
    public class ConsoleLogger : Logger
    {
        private Logger _next;
        public override void LogMessage(string message, string level)
        {
            if ("Info".Equals(level))
            {
                Console.WriteLine($"Sending to administrator: {message}");
            }
            else
            {
                _next.LogMessage(message, level);
            }
        }

        public override void SetNext(Logger logger)
        {
            _next = logger;
        }
    }
}