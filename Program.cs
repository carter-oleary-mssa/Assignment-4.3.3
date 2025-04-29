// Build the array
Console.Write("Input the number of elements to be stored in an array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Console.WriteLine($"Input {n} elements into the array: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Element {i}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

// Create dictionary of all values
var dic = new Dictionary<int, int>();
foreach (int i in arr)
{
    if (dic.ContainsKey(i)) dic[i]++;
    else dic.Add(i, 1);
}

// Print only unique keys
Console.WriteLine("The unique elements found in this array are: ");
foreach(KeyValuePair<int, int> kvp in dic)
{
    if (kvp.Value == 1) Console.Write($"{kvp.Key} ");
}