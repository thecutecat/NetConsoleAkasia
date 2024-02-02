// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//1. Algoritma hitung kata siapa dari string usomaanapaiumasydnip
//CountWordPossibility("usomaanapaiumasydnip","siapa");

static int CountWordPossibility(string inputString, string targetWord)

{
    int RealPossibility = 0;
    Dictionary<char, int> possibility = new Dictionary<char, int>();

    Dictionary<char, int> inputCharCount = new Dictionary<char, int>();
    Dictionary<char, int> targetCharCount = new Dictionary<char, int>();

    // Count characters in the input string
    foreach (char c in inputString)
    {
        if (inputCharCount.ContainsKey(c))
            inputCharCount[c]++;
        else
            inputCharCount[c] = 1;
    }

    // Count characters in the target word
    foreach (char c in targetWord)
    {
        if (targetCharCount.ContainsKey(c))
            targetCharCount[c]++;
        else
            targetCharCount[c] = 1;
    }

    // Calculate the possibility of forming the target word
    
    int x = 0;
    foreach (var kvp in targetCharCount)
    {
        char charInTarget = kvp.Key;
        int countInTarget = kvp.Value;

        if (!inputCharCount.ContainsKey(charInTarget) || inputCharCount[charInTarget] < countInTarget)
        {
            // The character in the target word is not present or occurs more times in the input string
            //possibility is 0;
            break;
        }
        else
        {
            // Update the possibility based on the ratio of character occurrences
            possibility[charInTarget] = (int)inputCharCount[charInTarget] / countInTarget;

            //initiate
            if (x == 0 && possibility[charInTarget] > 0)
            {
                RealPossibility = possibility[charInTarget];
            }

            if (possibility[charInTarget] == 0)
            {
                RealPossibility = 0;
            }else if(possibility[charInTarget] < RealPossibility)
            {
                RealPossibility = possibility[charInTarget];
            }
            //get lowest possibility

        }
        x++;
    }

    Console.WriteLine($"Kata {targetWord} bisa dibuat {RealPossibility} kali dari {inputString}");
    return RealPossibility;
}

//3. perkalian

//PerkalianSederhana(10, 5);
static int PerkalianSederhana(int j, int k)
{
    int hasil = 0;
    int x = j;
    while (x > 0)
    {
        hasil +=k;
        x--;
    }

    Console.WriteLine($"Kata {j} x {k} = {hasil}");
    return hasil;
}

//4. count store revenue
CountRevenue("KawanLamaJewel"); //result Rp. 3.250.000
static double CountRevenue(string StoreName)
{
    double revenue = 0.0;
    Dictionary<string, int> Items = new()
    {
        { "Ruby", 5 },
        { "Topaz", 3 },
        { "Permata", 1 }
    };

    Dictionary<string, int> ItemsPrice = new()
    {
        { "Ruby", 1000000 },
        { "Topaz", 1250000 },
        { "Permata", 3000000 }
    };

    foreach (KeyValuePair<string, int> item in Items)
    {
        revenue += ((int)(item.Value / 2) * ItemsPrice[item.Key]);
    }

    Console.WriteLine($"revenue maximum {StoreName} = {revenue}");
    return revenue;
}
