string[] getArrWereLenghLessThree(string[] arr)
{

    string[] boxArr = new string[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            boxArr[i] = arr[i];
        }

    }
    return boxArr;
}


string[] arr = { "Sunday", "Monday", "Tue", "Wed", "", "Friday", "Sa" };
arr = getArrWereLenghLessThree(arr);


Console.Write($"Ваш массив: [{string.Join(", ", arr)}] \n");