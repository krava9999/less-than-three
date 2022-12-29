string[] getArrWereLenghLessThree(string[] arr)
{

    int count = getCountElemntMoreThree(arr);
    string[] boxArr = new string[count];
    int indexBox = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            boxArr[indexBox] = arr[i];
            indexBox++;
        }

    }
    return boxArr;
}

int getCountElemntMoreThree(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] arr = { "Sunday", "Monday", "Tue", "Wed", "", "Friday", "Sa" };
arr = getArrWereLenghLessThree(arr);
Console.Write($"Ваш массив: [{string.Join(", ", arr)}] \n");

