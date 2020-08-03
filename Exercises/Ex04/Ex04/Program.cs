using System;


namespace Ex04
{
    class Farm
    {
        public void Animals(string name, string type, string sound, string eat, string produce)
        {
            Console.WriteLine($"My name is {name} and I am a {type}, I go {sound}, Eat {eat}, and Produce {produce}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Farm Pig1 = new Farm();
            Pig1.Animals("Willma", "Pig", "Oink", "Slop", "Bacon");
            Farm Pig2 = new Farm();
            Pig2.Animals("Arthur", "Pig", "Oink", "Slop", "Bacon");
            Farm Pig3 = new Farm();
            Pig3.Animals("Pork Wantan", "Pig", "Oink", "Slop", "Ham");
            Farm Pig4 = new Farm();
            Pig4.Animals("Jimmy Dean", "Pig", "Oink", "Slop", "Ham");
        
            Farm Cow1 = new Farm();
            Cow1.Animals("Regina", "Cow", "Moo", "Grass", "Milk");
            Farm Cow2 = new Farm();
            Cow2.Animals("Stella", "Cow", "Moo", "Grass", "Milk");
            Farm Cow3 = new Farm();
            Cow3.Animals("Kevin", "Cow", "Moo", "Grass", "Beef");
            Farm Cow4 = new Farm();
            Cow4.Animals("Jimmy", "Cow", "Moo", "Grass", "Beef");

            Farm Chicken1 = new Farm();
            Chicken1.Animals("Henry", "Chicken", "Cluck", "Grains", "Eggs");
            Farm Chicken2 = new Farm();
            Chicken2.Animals("Harold", "Chicken", "Cluck", "Grains", "Meat");
            Farm Chicken3 = new Farm();
            Chicken3.Animals("Harriott", "Chicken", "Cluck", "Grains", "Eggs");
            Farm Chicken4 = new Farm();
            Chicken4.Animals("Darlene", "Chicken", "Cluck", "Grains", "Meat");

            Farm Goose1 = new Farm();
            Goose1.Animals("Kyle", "Goose", "Honk", "Seeds", "Pillows");
            Farm Goose2 = new Farm();
            Goose2.Animals("Adam", "Goose", "Honk", "Seeds", "Pillows");
            Farm Goose3 = new Farm();
            Goose3.Animals("Tommy", "Goose", "Honk", "Seeds", "Pillows");
            Farm Goose4 = new Farm();
            Goose4.Animals("Ada", "Goose", "Honk", "Seeds", "Pillows");
        }
    }
}
