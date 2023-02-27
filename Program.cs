using static Shares;

int size = Input("Введите количество чисел");
int[] array = InputArray(size);
int pos = Positive(array);
Console.WriteLine("Количество положительных элементов = " + pos);