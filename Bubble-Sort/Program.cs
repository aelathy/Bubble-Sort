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




int bubbleSort(List<int> aList)
{
    for (int i = 0; i < aList.Count - 1; i++)
    {
        for (int j = 0; j < aList.Count - (i + 1); j++)
        {
            if (aList[j] > aList[j + 1])
            {
                int chng = aList[j + 1];
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