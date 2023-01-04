
using Catsing_practices.Models;

//Salmon salmon1= new Salmon();

//Eagle eagle1 = new Eagle();


//Animal animal1 = eagle1;

//animal1.Sound();

//Animal animal2 = salmon1;

//Bird bird = new Bird();

//Animal animal3 = new Salmon();




//salmon1.Sound();

//eagle1.Sound();

//Animal animal1 = new Animal();

//animal1.Sound();

//Bird bird = new Bird();

//bird.Sound();



// Eagle eagle1 = new Eagle();    

//Animal animal1= new Animal();

//Eagle eagle2 = (Eagle)animal1;

//Eagle eagle1 = new Eagle();

//Animal animal1 = new Animal();

//Fish fish1 = new Fish();

//Animal animal2 = fish1;

//Bird bird1 = new Bird();


//Animal[] animals = {eagle1, animal1, bird1,fish1,animal2};

//foreach (var item in animals)
//{
//    item.Name = "XXX";
//    Console.WriteLine(item.Name);
//}


//string str = "dddd";

//object obj1 = str;

//string name = obj1.ToString();


//int num1 = 55;

//object obj1 = num1;

//int num3 = (int)obj1;

//string str = "dd";

//object obj = str;

//int num3 = (int)obj;


//string str1 = "55";

//object obj1 = str1;

//var result= int.Parse(str1);

//bool isMarrid = false;

//object obj1 = isMarrid;

//bool result = (bool)obj1;

//Console.WriteLine(result);


//byte num1 = 22;

//int num2 = num1;

//int num1 = 12;

//byte num2 =(byte)num1;



Bird bird = new Bird();

Fish fish= new Fish();

Animal animal1 = new Bird();

Animal animal2 = new Fish();

object[] objects = {1,2, "Salam", bird, fish};

//foreach (var item in objects)
//{
//	if (item is Animal)
//	{
//		((Animal)item).Name = "test";
//		Console.WriteLine(((Animal)item).Name);

//    }
//}


foreach (var item in objects)
{
    Animal animal= item as Animal;

	if (animal == null)
	{

		animal.Name = "ddddd";

		Console.WriteLine(animal.Name);

		//Console.WriteLine("Ede bilmedi");
	}

}
