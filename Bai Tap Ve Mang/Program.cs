using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Threading;

namespace Bai_Tap_Ve_Mang
{
	internal class Program

	//Bài 1:	Đọc và in các phần tử trong mảng vừa nhập. 
	{
		static void Main(string[] args)
		{
			//Console.Write(" nhap vao so luong phan tu n = ");
			//int n  =  int.Parse(Console.ReadLine());

			//int[] arr = new int[n];
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.Write("Nhap vao phan tu thu {0} = ", i);
			//	arr[i]= int.Parse(Console.ReadLine());
			//}

			//Console.WriteLine("mang vua nhap la:");
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.Write(arr[i] + "\t");
			//}

			//Bài 2.	In mảng dữ liệu trên theo chiều đảo ngược.

			//Console.Write("Nhap vao so luong phan tu n = ");
			//int n = int.Parse(Console.ReadLine());

			//int[] arr2 = new int[n];
			//for(int i = 0; i < n; i++)
			//{
			//	Console.Write("Nhap vao phan tu thu {0} = ", i);
			//	arr2[i] = int.Parse(Console.ReadLine()); 
			//}

			//Console.WriteLine("Mang vua nhap la: ");
			//for (int i = 0; i < n; i++)
			//{
			//	Console.Write(arr2[i] + "\t");
			//}

			// Xuất bằng cách sử dụng hàm Reverse
			//Array.Reverse(arr2);
			//Console.WriteLine();
			//Console.WriteLine("Mang vua nhap la: ");
			//for (int i = 0; i < n; i++)
			//{
			//	Console.Write(arr2[i] + "\t");
			//}


			//	Xuất mảng theo cách thông thường
			//Console.WriteLine("Mang du lieu theo chieu dao nguoc");
			//for(int i = arr2.Length - 1; i >= 0; i--)
			//{
			//	Console.Write(arr2[i] + "\t");
			//}

			// Bài 3 :Tìm số phần tử giống nhau trong mảng và hiển thị số lượng giống nhau ra màn hình.

			//Console.Write("Nhap vao so luong phan tu n = ");
			//int n = int.Parse(Console.ReadLine());

			//int[] arr3 = new int[n];
			//for (int i = 0; i < n; i++)
			//{
			//	Console.Write("Nhap vao phan tu thu {0} = ", i);
			//	arr3[i] = int.Parse(Console.ReadLine());
			//}

			//Console.WriteLine("Mang vua nhap la: ");
			//for (int i = 0; i < n; i++)
			//{
			//	Console.Write(arr3[i] + "\t");
			//}



			//int j = 0;
			//int count = 0;
			//for (int i = 0; i < n; i++)
			//	{
			//		for (j = i + 1; j < n; j++)
			//	{

			//	if (arr3[i] == arr3[j])
			//		{
			//			count++;
			//			break;
			//		}
			//	}
			//}

			//	Console.Write("\nSo phan tu giong nhau trong mang la: {0}\n\n", count++);

			//	Console.ReadKey();



			//bai 4: In các phần tử duy nhất trong mảng
			//Console.Write("Nhap phan tu: ");
			//int n = int.Parse(Console.ReadLine());

			//int[] arr = new int[n];
			//for (int i = 0; i < n; i++)
			//{
			//	Console.Write($"Phan tu thu {i + 1}: ");
			//	arr[i] = int.Parse(Console.ReadLine());
			//}

			//Console.Write("Cac phan tu duy nhat duoc tim thay trong mang la: \n");
			//for (int i = 0; i < n; i++)
			//{
			//	int count = 0;
			//	for (int j = 0; j < i - 1; j++)
			//	{
			//		if (arr[i] == arr[j])
			//		{
			//			count++;
			//		}
			//	}
			//	for (int k = i + 1; k < n; k++)
			//	{
			//		if (arr[i] == arr[k])
			//		{
			//			count++;
			//		}
			//	}
			//	if (count == 0)
			//	{
			//		Console.Write("{0} ", arr[i]);
			//	}
			//}


			// Bài 5: 	Chia mảng dữ liệu ban đầu thành mảng chẵn và mảng lẽ


			//Console.Write("nhap vao so luong phan tu n = ");
			//int n = int.Parse(Console.ReadLine());

			//int[] arr4 = new int[n];
			//for (var i = 0; i < n; i++)
			//{
			//	Console.Write("Nhap vao phan tu thu {0} = ", i);
			//	arr4[i] = int.Parse(Console.ReadLine());
			//}

			//Console.WriteLine("Cac so trong mang la = ");
			//for (var i = 0; i < n; i++)
			//{
			//	Console.Write(arr4[i] + "\t");
			//}

			//Console.WriteLine();
			//Console.WriteLine("Mang cac so chan la = ");
			//for (var i = 0; i < n; i++)
			//{
			//	if (arr4[i] % 2 == 0)
			//	{
			//		Console.Write(arr4[i] + "\t");
			//	}
			//}

			//Console.WriteLine();
			//Console.WriteLine("Mang cac so le la = ");
			//for(var i = 0; i < n; i++)
			//{
			//	if (arr4[i] % 2 != 0)
			//	{
			//		Console.Write(arr4[i] + "\t");
			//	}
			//}

			// Bài 6: Sắp xếp mảng theo thứ tự giảm dần
			//Console.Write("Nhap vao so luong phan tu n = ");
			//int n = int.Parse(Console.ReadLine());

			//int[] arr3 = new int[n];
			//for(var i = 0; i < n; i++)
			//{
			//	Console.Write("Nhap vao phan tu thu {0} = ", i);
			//	arr3[i] = int.Parse(Console.ReadLine());
			//}

			//Console.WriteLine("Mang vua nhap la = ");
			//for(var i = 0; i < n; i++)
			//{
			//	Console.Write(arr3[i] + "\t");
			//}


			//Sắp xếp tăng dần
			//Array.Sort(arr3);
			//Console.WriteLine();
			//Console.WriteLine("Mang sap xep theo thu tu tang dan");
			//for(var i = 0; i < n; i++)
			//{
			//	Console.Write(arr3[i] + "\t");
			//}

			// Sắp xếp giảm dần
			//Array.Reverse(arr3); 
			//Console.WriteLine();
			//Console.WriteLine("mang sap xep theo thu tu giam dan");
			//for(var i = 0; i < n; i++)
			//{
			//	Console.Write(arr3[i] + "\t");
			//}


			//Bài 7 Tìm kiếm phần tử lớn thứ hai trong mảng dữ liệu ban đầu.
			Console.Write("Nhap vao so luong phan tu n = ");
			int n = int.Parse(Console.ReadLine());

			int[] arr = new int[n];
			for (int i = 0; i < n; i++)
			{
				Console.Write("Nhap vao phan tu thu {0} = ", i);
				arr[i] = int.Parse(Console.ReadLine());
			}

			Console.Write("Cac so trong mang la {0}: ");
			for (int i = 0; i < n; i++)
			{
				Console.Write(arr[i] + "\t");
			}

			Console.WriteLine();
			int max = arr[0];
			int secondMax = arr[0];

			for (int i = 1; i < n; i++)
			{
				if (max < arr[i]) max = arr[i];
			}

			for (int i = 1; i < n; i++)
			{
				if (secondMax < arr[i] && (arr[i] < max))
				{
					secondMax = arr[i];
				}
			}
			Console.WriteLine("Gia tri lon thu 2 trong mang la {0}", secondMax);



		}
	}
}












			

	

	