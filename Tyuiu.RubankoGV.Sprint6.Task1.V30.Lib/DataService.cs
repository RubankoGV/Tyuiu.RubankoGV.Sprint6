﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RubankoGV.Sprint6.Task1.V30.Lib
{
    public class DataService : ISprint6Task1V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // Измените округление на 2 знака после запятой
                y = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}