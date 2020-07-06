using System;

namespace Tests
{
    
    class Cats_adding
    {
        int cats_total_count;
        public Cats_adding(int count_plus)
        {
            cats_total_count = count_plus;
        }
        public void Puting_cats(int count_plus)
        {
            cats_total_count += count_plus;
            Console.WriteLine($"{count_plus} cats was added\n");
            Console.WriteLine($"Cats total count: {cats_total_count}");
        }
        public void Excluding_cats(int count_mines)
        {
            if (cats_total_count >= count_mines)
            {
                cats_total_count -= count_mines;
                Console.WriteLine($"{count_mines} cats excluded\n");
                Console.WriteLine($"Cats total count: {cats_total_count}");
            }
            else
            {
                Console.WriteLine($"Total cats count = {cats_total_count}, we can't exclude required cat number");
            }
        }
    }
    class House
    {
        delegate int Operation(int summ);

        static void Main(string[] args)
        {
            Console.WriteLine("Plese, add number of cats: ");
            int cats_count_plus = Convert.ToInt32(Console.ReadLine());

            Cats_adding cats_add = new Cats_adding(0);
            cats_add.Puting_cats(cats_count_plus);

            Console.WriteLine("Plese, exclude number of cats: ");
            int cats_count_mines = Convert.ToInt32(Console.ReadLine());

            Cats_adding cats_exclude = new Cats_adding(cats_count_plus);
            cats_exclude.Excluding_cats(cats_count_mines);


        }
    }
}

