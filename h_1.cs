

void Result(string[] array_1, string[] array_2)
{
    int count = 0;
    for (int i = 0; i < array_1.Length; i++)
    {
        if (array_1[i].Length <= 3)
        {
            array_2[count] = array_1[i];
            count++;
        }
    }
}