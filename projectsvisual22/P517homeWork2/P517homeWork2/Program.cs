
//Task A

//int sum = 0;
//bool isContinue = true;

//Console.Write("1ci ededi daxil edin: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("2ci ededi daxil edin: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//1st way

//if (num1>num2) //n
//{
//    Console.Write("Yanlish deyer! Yeni deyerler daxil edin: ");

//}
//else //n
//{
//	for (int i = num1; i <= num2 ; i++) //n*n
//	{
//		sum += num1; //n
//		num1++; //n
//	}
//	Console.WriteLine(sum);
//}

///////////////////////////////////////////////////////////////////////////



//2nd way

//do //n
//{

//    if (num1 > num2) //n*n
//    {
//        Console.Write("Yanlish deyer! Yeni deyerler daxil edin: ");
//       isContinue = false;
//        break;
//    }


//        for (int i = num1; i <= num2; i++) //n*n
//        {
//            sum += num1; //n
//            num1++; //n
//        }
//        Console.WriteLine(sum);




//} while (isContinue == true); //n



//Task B

//1,4,-1,7,0
//-1,0,1,4,7




//void FindMedian()
//{
//int[] arr = { 5, 3, 7, -2, 0, 8 };
//	int size = arr.Length;
//	int mid = size / 2;

//	if (size % 2 != 0)
//	{

//	}



//int[] ArraySort(int[]arr)
//{
//	for (int i = 0; i < arr.Length-1; i++)
//	{
//		for (int j = 0; j < arr.Length - (1+i); j++)
//		{
//			if (arr[j] > arr[j+1])
//			{
//				int temp = arr[j + 1];
//				arr[j + 1] = arr[j];	
//				arr[j] = temp;
//			}
//		}


//	}

//	return arr;

//}
//}



void FindSumOfMinMax(int[]arr)
{


    for (int i = 0; i < arr.Length - 1; i++)


        for (int j = i + 1; j < arr.Length; j++)


            if (arr[i] < arr[j])
            {
                int temp;
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }



}
int[] numbers = new[] { 1, 5, 2, 4, 8, 12, 3, -2 };


foreach (int value in numbers)
{
    Console.Write(value + " ");
}



//int[] arr = new int[] { 1, 5, 2, 4, 8, 12, 3, -2 };

//int temp;


//for (int i = 0; i < arr.Length - 1; i++)

   
//    for (int j = i + 1; j < arr.Length; j++)

     
//        if (arr[i] < arr[j])
//        {

//            temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }


//foreach (int value in arr)
//{
//    Console.Write(value + " ");
//}
    