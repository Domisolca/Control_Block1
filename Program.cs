string[] firstArray = { "Hello", "2", "world", ":-)" };
int lengthSecond = 0;

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        lengthSecond++;
    }
}

string[] arraySecond = new string[lengthSecond];
