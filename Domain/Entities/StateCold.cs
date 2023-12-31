﻿namespace Domain.Entities
{
    public class StateCold : ITemperatureState 
    {
        public double Measure { get; }
        public DateTime MeasureDateTime { get; }
        public string Name => StateName;
        public static string StateName => "COLD";

        public StateCold(double measure, DateTime measureDateTime)
        {
            Measure = measure;
            MeasureDateTime = measureDateTime;
        }
    }
}
