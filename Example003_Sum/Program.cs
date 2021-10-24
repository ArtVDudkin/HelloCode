int numberA = new Random().Next(1,10); // 1 2 3 4 ... 9
Console.Write(numberA + " + ");
int numberB = new Random().Next(1,10);
Console.Write(numberB);
int sum = numberA + numberB;
Console.WriteLine(" = " + sum);
// поменять значения местами, не используя третью переменную
numberA = numberA + numberB;
numberB = numberA -numberB;
numberA = numberA - numberB;
Console.WriteLine(numberA + " <-> " + numberB);
