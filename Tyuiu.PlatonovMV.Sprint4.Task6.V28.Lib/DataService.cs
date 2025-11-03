using System;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PlatonovMV.Sprint4.Task6.V28.Lib
{
    public class DataService : ISprint4Task6V28
    {
        public string[] Calculate(string[] array)
        {
            List<string> result = new List<string>();
            foreach (var item in array)
            {
                if (item.Length == 4)
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}