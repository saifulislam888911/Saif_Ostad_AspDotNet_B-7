using Encapsulation;

Uttoradhikar objAsset = new Uttoradhikar();
Console.WriteLine(objAsset.publicAsset); // Public : Access From anywhere
//Console.WriteLine(objAsset.privateAsset); // Private : Access only within the same class
//Console.WriteLine(objAsset.protectedAsset); // Protected : Access within the same class and from the class that inherits the base class
Console.WriteLine(objAsset.internalAsset); // Internal : Access only within own Assembly