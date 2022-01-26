// **Задача**: 


void PrintArray(string[] newarray)
{
    for (int i = 0; i < newarray.Length; i++)
    {
        Console.Write($"{newarray[i]} ");
    }
}

int newarraysize(string[] newarray)
{
    int targetarraylength = 0;
    for (int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i].Length <= 3)
        {
            targetarraylength++;
        }
    }
    return targetarraylength;
}

void Fills3array(string[] newarray, string[] targetarray)
{
    for (int j = 0, k = 0; j < newarray.Length; j++)
    {
        if (newarray[j].Length <= 3)
        {
            targetarray[k] = newarray[j];
            k++;
        }
    }
}

void Demo ()
{
    string[] countries = {"Russia" , "UAE", "USA", "UK", "Germany", "France", "Italy", "Sweden"};
    //PrintArray(countries);
    Console.WriteLine("");
    string[] countriesshort = new string [newarraysize(countries)];
    Fills3array (countries, countriesshort);

    PrintArray(countriesshort);
}

Demo ();
