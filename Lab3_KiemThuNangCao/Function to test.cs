using System.Linq.Expressions;

namespace Lab3_KiemThuNangCao
{
    public class Function_to_test
    {
        public int Additions(int firstNumber, int secondNumber)
        {
            if (firstNumber <= 0)
            {
                if (secondNumber >= 0)
                {
                    throw new ArgumentException("Số đầu tiên nhật vào không thể là số nguyên");
                }
                else
                {
                    throw new ArgumentException("Cả 2 số nhập vào không thể là số nguyên");
                }
            }
            if (secondNumber <= 0)
            {
                throw new ArgumentException("Số thứ hai nhập vào không thể là số nguyên");
            }
            return firstNumber + secondNumber;
        }
        public int Divisions(int firstNumber, int secondNumber)
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
            if (secondNumber <= 0)
            {
                    throw new DivideByZeroException("Số thứ hai không thể chia cho số thứ hai");
            }
            return firstNumber / secondNumber;
        }
    }
}
