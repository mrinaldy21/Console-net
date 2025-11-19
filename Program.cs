class program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Masukan Angka : ");
            string input = Console.ReadLine() ?? "";

            string getinput = new string(input.Where(char.IsDigit).ToArray());

            if (string.IsNullOrWhiteSpace(getinput))
            {
                Console.WriteLine("input tidak valid, Masukan angka");
                continue;
            }

            int number = int.Parse(getinput);

            string reserveinput = new string(getinput.Reverse().ToArray());
            int reservenumber = int.Parse(reserveinput);

            int difference = Math.Abs(number - reservenumber);

            Console.WriteLine($"Angka Inputan         : {number}");
            Console.WriteLine($"Kebalikan angka input : {reservenumber}");
            Console.WriteLine($"Selesih               : {difference}");
        }
    }
}
