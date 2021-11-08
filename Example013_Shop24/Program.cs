﻿// В магазин "Всё по 23Рэ" может заходить одновременно много людей (около 100 человек).
// В магазине охранник ведет учет и отмечает время прихода и ухода каждого посетителя.
// Двери магазина открываются в ровное количество часов (01:00, 13:00, 17:00 и т.д.). 
// В это время люди заходят в магазин и выходят. Заходит случайное количество людей, причем каждый человек
// должен провести в магазине минимум 1 час (он не может зайти и сразу жу выйти). Максимальное количество часов,
// которое каждый из людей может провести в магазине, равно 23 часа. Время нахождения каждого пользователя в 
// магазине определяется случайно.
// Магазин работает круглосуточно.
// В каком премежутке времени за день было больше всего народа (01:00 - 02:00, или 13:00-14:00, или 16:00-17:00)?

// Цикл от 0 до 24
// в нем прогоняем массив есмкостью [24] c периодами времени 
// [0-1, 1-2, 2-3, 3-4, 4-5, 5-6, 6-7, 7-8, 8-9, 9-10, 10-11, 11-12, 12-13, 13-14, 14-15, 15-16, 16-17, 17-18, 18-19, 19-20, 20-21, 21-22, 22-23, 23-24] для записи в 
// в цикле в каждом периоде времени заходит случайное количество человек в диапазоне от 0 никто не пришел до (100 - сколько уже сейчас в магазине + сколько человек вышло)
// подцикл для количества зашедших случайно определяется время их нахождения в магазине в диапазоне от 1 до (23 - кол-во прошедших периодов времени). Со временем это значение будет уменьшаться до 1
// для периода 0-1 зашли от (0, 100) человек, вышли 0. Для зашедших определяем случайным образом, сколько времени они будут находиться в магазин (1, 23] и записываем в массив


int openTime = 0;                              // время открытия магазина 00:00
int closeTime = 24;                            // время закрытия магазина 24:00
int[] peopleInside = new int[closeTime - openTime];    // массив, в котором хранится количество посетителей в текущем и будущих периодах времени
int peopleLimit = 100;                         // в магазине одновременно может находиться максимум 100 человек
int comingPeople = 0;                          // количество людей, которые пришли в магазин в некий период времени, изначально там не было никого
// текущее максимально возможное число посетителей = Лимит(100) минус те, кто пришел в данный период времени, минус те, кто пришел ранее и пока еще тут, плюс те, кто ушел в текущем периоде времени
int currentMaxPeople = peopleLimit - peopleInside[0];  
int visitTimeOfMan = new Random().Next(1, 24); // время, в течение которого человек может находиться в магазине в диапазоне [1,23] часов
int indexMaxPeople = 0;                        // индекс периода времени, когда в магазине находилось больше всего посетителей  

Console.Clear();
for (int time = openTime; time < closeTime; time++)            // в течение суток работы магазина выполняем слудующее
{
    Console.Write($"В период с {String.Format("{0:d2}", time)}:00 по {String.Format("{0:d2}", time +1)}:00 часов в магазине было {String.Format("{0:d2}", peopleInside[time])} человек, ");
    comingPeople = new Random().Next(0, currentMaxPeople +1);  // 0 = никто не зашел, максимум = текущее мах возможное число посетителей
    Console.Write($"пришло {String.Format("{0:d2}", comingPeople)} человек, ");
   // Console.WriteLine($"В период с {String.Format("{0:d2}", time)}:00 по {String.Format("{0:d2}", time +1)}:00 часов в магазин пришло {comingPeople} человек");
    for (int i = 0; i < comingPeople; i++)                    // для каждого зашедшего человека
    {
        // определяем время, в течение которое посетитель будет находиться в магазине (минимум 1 час, максимум = оставшееся время работы магазина)
        visitTimeOfMan = new Random().Next(1, closeTime - time +1); //    
        for (int j = time; j < (time + visitTimeOfMan); j++)  // начиная от текущего момента времени time, отмечаем  в будущих периодах сколько времени
        {
            peopleInside[j]++;                                // пользователь будет находиться в магазине visitTimeOfMan, увеличивая на 1 кол-во постетителей в этих периодах времени                               
        }                                                     // количество будущих периодов времени равно visitTimeOfMan   
    }
    currentMaxPeople = peopleLimit - peopleInside[time];      // определяем исходя из лимита(100) и текущей заполненности магазина, сколько максимально еще человек может прийти
    if (peopleInside[time] > peopleInside[indexMaxPeople])    // если в текущем периоде времени пришло больше посетителей, чем было известно до этого, 
        indexMaxPeople = time;                                // то запоминаем индекс этого периода времени  
    //Console.WriteLine($"В период с {String.Format("{0:d2}", time)}:00 по {String.Format("{0:d2}", time +1)}:00 часов в магазине находилось {peopleInside[time]} человек, пришло {comingPeople} человек, максимум еще может придти {currentMaxPeople}");
    Console.WriteLine($"стало находиться {peopleInside[time]} человек, максимум еще может придти {currentMaxPeople}");
}

Console.WriteLine($"Больше всего посетителей находилось в магазине в период с {String.Format("{0:d2}", indexMaxPeople)}:00 по {String.Format("{0:d2}", indexMaxPeople +1)}:00 часов: {peopleInside[indexMaxPeople]} человек");