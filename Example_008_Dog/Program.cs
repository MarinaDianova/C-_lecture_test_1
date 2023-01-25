// Задача про собаку, которая бегает от одного друга к другому

int Distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int count = 0;
int Time = 0;

while (Distance > 10)
{
if (friend==1)
{
        Time= Distance/(secondFriendSpeed+dogSpeed);
    friend = 1;
}
else
{
   Time= Distance/(firstFriendSpeed+dogSpeed);
    friend = 2; 
}
Distance = Distance - (firstFriendSpeed+secondFriendSpeed)*Time;
count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");