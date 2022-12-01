void FirstToSecondArray(string[] firstArray, string[] secondArray)
{
    int j = 0;

    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[j] = firstArray[i];
            j++;
        }
    }
}

void WriteArry(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");   
    }
}

string[] firstArray = { "Hello", "2", "world", ":-)" };
int lengthSecond = 0;

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        lengthSecond++;
    }
}

string[] secondArray = new string[lengthSecond];

FirstToSecondArray(firstArray, secondArray);

WriteArry(secondArray);