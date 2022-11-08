void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
    Console.WriteLine();
}


string[] massInput ={"Hello", "2", "world", ":-)"};
string[] massResult= {};

PrintArray(massInput);

for (int i = 0; i < massInput.Length; i++)
{
    if(massInput[i].Length <= 3)
    {
                   string [] massNewResult = new string[massResult.Length + 1];    
        
        for (int j = 0; j < massResult.Length; j++)
        {
            massNewResult[j] = massResult[j];        
        }

        massNewResult[massNewResult.Length - 1] = massInput[i];        

        massResult = massNewResult;   
    }
}

PrintArray(massResult);