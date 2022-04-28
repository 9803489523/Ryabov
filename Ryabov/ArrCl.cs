using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryabov
{
    class ArrCl
    {
        //поле массива +геттер и сеттер
        private int[] array
        {
            get; 
            set;
        }
        //индексаторы
        public int this[int index]
        {
            get { 
                if(index < 0 || index >= array.Length)
                    throw new ArgumentException();
                return array[index]; 
            }
            set {
                if (index < 0 || index >= array.Length)
                    throw new ArgumentException();
                array[index] = value; }
        }
        //конструктор с параметрами, , в качестве аргумента берем длину массива
        public ArrCl(int size)
        {
            if (size <= 0)
                throw new ArgumentException();
            array = new int[size];
            Console.WriteLine("Введите массив");
            for(int i=0; i < size; i++)
            {
                Console.Write($"{i + 1} элемент: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
        //конструктор с параметром, в качестве аргумента берем массив
        public ArrCl(int[] arr)
        {
            this.array= arr;
        }
        //конструктор без параметров, созлается массив размерности 0
        public ArrCl() { array = new int[0]; }
        //перегрузка оператора сложения двух массивов
        public static ArrCl operator +(ArrCl arr1, ArrCl arr2)
        {   
            if(arr1.array.Length != arr2.array.Length)
                throw new ArgumentException();
            int[] arr = new int[arr1.array.Length];
            ArrCl sum=new ArrCl(arr);
            for(int i=0; i<arr1.array.Length; i++)
            {
                sum.array[i] = arr1.array[i]+ arr2.array[i];
            }
            return sum;
        }
        //перегрузка оператора разности двух массивов
        public static ArrCl operator -(ArrCl arr1, ArrCl arr2)
        {
            if (arr1.array.Length != arr2.array.Length)
                throw new ArgumentException();
            int[] arr = new int[arr1.array.Length];
            ArrCl sum = new ArrCl(arr);
            for (int i = 0; i < arr1.array.Length; i++)
            {
                sum.array[i] = arr1.array[i] - arr2.array[i];
            }
            return sum;
        }
        //перегрузка оператора умножения на число
        public static ArrCl operator *(ArrCl arr,int vector)
        { 
            for (int i = 0; i < arr.array.Length; i++)
            {
               arr.array[i]*= vector;
            }
            return arr;
         
        }
        //перегрузка оператора деления на число
        public static ArrCl operator /(ArrCl arr, int vector)
        {
            for (int i = 0; i < arr.array.Length; i++)
            {
                arr.array[i] /= vector;
            }
            return arr;
        }

        //вывод на печать всего массива
        public void print()
        {
            for(int i = 0; i < array.Length-1; i++)
            {
                Console.Write(array[i]+", ");
            }
            Console.Write(array[array.Length-1]+".\n");
        }
        //вывод на печать элемента, получаемого по индексу
        public void printByIndex(int index)
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Выход за границы массива");
                return;
            }
            Console.WriteLine($"{index}-элемент = {array[index]}");
        }
    }
}
