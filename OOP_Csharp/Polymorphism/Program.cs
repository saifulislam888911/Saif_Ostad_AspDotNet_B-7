using Polymorphism;

Animal objAnimal = new Animal();
objAnimal.Movement_1();
objAnimal.Movement_1("Amoebidae"); //Overload

Console.WriteLine();

Animal objBird = new Bird();
objBird.Movement_1();
objBird.Movement_1("Bird"); //Overrride

Console.WriteLine();

Animal objFish = new Fish();
objFish.Movement_1();
objFish.Movement_1("Fish"); //Overrride