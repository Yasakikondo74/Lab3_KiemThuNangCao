using System;

namespace Lab3_KiemThuNangCao
{
    public class Function_to_test
    {
        public static int Additions(int firstNumber, int secondNumber)
        {
            if (firstNumber <= 0)
            {
                if (secondNumber >= 0)
                {
                    throw new Exception("Số đầu tiên nhật vào không thể là số nguyên");
                }
                else
                {
                    throw new Exception("Cả 2 số nhập vào không thể là số nguyên");
                }
            }
            if (secondNumber <= 0)
            {
                throw new Exception("Số thứ hai nhập vào không thể là số nguyên");
            }
            return firstNumber + secondNumber;
        }
        public static int Divisions(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0)
            {
                if (secondNumber == 0)
                {
                    throw new DivideByZeroException("Cả 2 số nhập vào không thể chia cho nhau");
                }
                else
                {
                    throw new DivideByZeroException("Số đầu tiên không thể chia cho số thứ hai");
                }
            }
            if (secondNumber == 0)
            {
                    throw new DivideByZeroException("Số thứ hai không thể chia cho số thứ hai");
            }
            return firstNumber / secondNumber;
        }
        public static float Average(int[] Array_of_numbers)
        {
            if (Array_of_numbers == null || Array_of_numbers.Length == 0)
            {
                throw new ArithmeticException("Array không được để trống");
            }

            int sum = 0;
            for (int i = 0; i < Array_of_numbers.Length; i++)
            {
                sum += Array_of_numbers[i];
            }
            if (sum == 0)
            {
                throw new DivideByZeroException("Array không thể chia cho 0");
            }
            float average = sum / Array_of_numbers.Length;
            return average;
        }
        public static int Int_Pos(int[] Array_of_numbers, int pos)
        {
            if (pos < 0 || pos >= Array_of_numbers.Length)
            {
                throw new IndexOutOfRangeException($"Index {pos} nằm ngoài phạm vi.");
            }
            return Array_of_numbers[pos];
        }
        public static string String_Pos(string[] Array_of_name, int pos)
        {
            if (pos < 0 || pos >= Array_of_name.Length)
            {
                throw new IndexOutOfRangeException($"Index {pos} không nằm trong danh sách.");
            }
            return Array_of_name[pos];
        }
    }
}
