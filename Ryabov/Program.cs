class Test
{
    static void Main(string[] args)
    {
        try
        {
            //массив ждя быстрого создания класса (без ввода с консоли)
            int[] arr = { 1, 6, 8, 2, -9 };
            //массив для создание класса с пустым массивом (для отслеживания дальнейших преобразований)
            int[] empty = { 0, 0, 0, 0, 0 };
            Ryabov.ArrCl arr1 = new(5);
            //проверка вывода на консоль массива/элемента массива
            arr1.print();
            arr1.printByIndex(4);
            arr1.printByIndex(5);
            Ryabov.ArrCl arr3 = new(empty);
            Ryabov.ArrCl arr2 = new Ryabov.ArrCl(arr);
            //проверка сложения массивов
            arr3 = arr2 + arr1;
            arr3.print();
            //проверка вычитания массивов
            arr3 = arr2 - arr1;
            arr3.print();
            //проверка умножения массива на число
            arr3 = arr2 * 4;
            arr3.print();
            //проверка деления массива на скаляр
            arr3 = arr2 / 2;
            arr3.print();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Введены некорректные данные! Ошибка:\n");
            Console.WriteLine(ex.ToString());
        }
    }
}

