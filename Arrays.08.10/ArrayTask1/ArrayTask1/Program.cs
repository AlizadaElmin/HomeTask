// Verilmiş 2 integer array-dən birincisində yer alıb digərində yer almayan elementləri ekrana çıxarın

int[] arr1 = { 1, 3, 4, 5, 6, 8, 9};
int[] arr2 = { 1, 4, 0, 12, 2, 7,11 };
bool isExist = false;


for (int i =0; i < arr1.Length; i++)
{
    isExist = false;
    for(int j =0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            isExist = true;
            break;
        }
    }

    if (!isExist)
    {
        Console.WriteLine(arr1[i]);
    }
    
}



