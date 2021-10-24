Console.Clear();                  // очищаем экран
int count = 0,                    // кол-во раз, которое пробежит собака
    friend = 2;                   // друг, к которому бежит собака

double distance = 10000,          // начальное расстояние между друзьями
       FirstFriendSpeed = 1,      // скорость 1 друга
       SecondFriendSpeed = 2,     // скорость 2 друга
       DogSpeed = 5,              // скорость собаки
       time = 0;
while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (FirstFriendSpeed + DogSpeed);
        friend = 2; 
    }
    else
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        friend = 1; 
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed)*time;
    Console.WriteLine($"Время {count+1}го пробега собаки {time :0.##}, дистанция между друзьями {distance :0.##}"); // :0.## - формат вывода: значение и 2 знака после запятой 
    count++;
} 
Console.WriteLine($"Собака пробежит {count} раз");