class Program
{


    public static void Main()
    {

       int[] nums1 = { 4, 9, 0, 5, 12 };

       int[] nums2 = BubbleSortingArray(nums1);
           

            for(int i=0;i<nums2.Length;i++){

               Console.WriteLine(nums2[i]);
            }

        Console.WriteLine();

        int[] nums3={-8,65,42,15,0,24};
         int[] nums4=SelectoinSortingArray(nums3);

            for(int i=0;i<nums3.Length;i++){

               Console.WriteLine(nums4[i]);
            }



    }



    public static int[] BubbleSortingArray(int[] nums)
    {

     


        for (int i = 0; i < nums.Length; i++)
        {

            for (int x = 0; x < nums.Length - i - 1; x++)
            {

                if (nums[x] > nums[x + 1])
                {

                    int k = nums[x];
                    nums[x] = nums[x + 1];
                    nums[x + 1] = k;
                }
            }
        }
        return nums;
    }
public static int[] SelectoinSortingArray(int[] nums){
int min;
int temp;
 for (int i = 0; i < nums.Length; i++)
 {
   min=i;
     for (int x = i+1; x < nums.Length; x++)
            {

                if (nums[x]< nums[min])
                {

                  min=x;
                }
            }

        temp=nums[min];
        nums[min]=nums[i];
        nums[i]=temp;
 }





  return nums;
}

}










































