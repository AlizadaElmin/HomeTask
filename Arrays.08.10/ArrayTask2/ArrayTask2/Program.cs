// Verilmiş integer array-in tək indexdə duran elementləri ilə cüt indexdə duran elementləri müqayisə edin

int[] nums = { 1, 2, 3, 4, 5, 6};
int oddIndex = 0;
int evenIndex = 0;



for(int i = 0; i < nums.Length; i++)
{
    if(i % 2 == 0)
    {
        evenIndex += nums[i];
    }
    else
    {
        oddIndex += nums[i];
    }
}


if (evenIndex > oddIndex)
{
    Console.WriteLine("Cut index cemi boyukdur");
}
else if(evenIndex == oddIndex)
{
    Console.WriteLine("Beraberdir");
}
else
{
    Console.WriteLine("Tek index cemi boyukdur");
}














