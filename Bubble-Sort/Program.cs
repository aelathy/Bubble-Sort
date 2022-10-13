// Bubble Sort

// function bubbleSort(anArray) {
//   for (the max number of comparisons needed down to one) {
//     for (the current number of comparisons needed) {
//       compare adjacent elements and swap if needed
//     }
//   }
// }
#nullable disable
Console.Clear();

List<int> mynums = new List<int> { 3, 1, 4, 6, 9, 2 };
List<string> mycars = new List<string> { "Volvo", "Ram", "Acura", "Ford", "Honda", "Hyundai" };




int bubbleSort<T>(IList<T> aList) where T : IComparable
{
    for (int i = 0; i < aList.Count - 1; i++)
    {
        for (int j = 0; j < aList.Count - (i + 1); j++)
        {
            int compare = aList[j].CompareTo(j + 1);
            if (compare == 1)
            {
                T chng = aList[j + 1];
                aList[j + 1] = aList[j];
                aList[j] = chng;
            }
        }
    }
    return -1;
}

bubbleSort(mynums);
// bubbleSort(mycars);

for (int i = 0; i < mynums.Count; i++)
{
    Console.WriteLine(mynums[i]);
}

// foreach (string car in mycars)
// {
//     Console.WriteLine(car);
// }