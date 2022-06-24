class Program
{
    static void Main(string[] args)
    {
        int[] st = { 1111, 0111 };
        string str = st.ToString();
        string[] mas = str.Split(".");
        mas[0] = "1111";
        mas[1] = "0111";
        int i1=Convert.ToInt32(mas[0], 2);
        int i2=Convert.ToInt32(mas[1], 2);
        string i3 = Convert.ToString(i1, 16);
        string i4 = Convert.ToString(i2, 16);
        Console.WriteLine($"Шестнадцатиричное число = {i3+"."+i4}");
    }
}
