Console.Write("Введите с кем собака ");
int friend = Console.ReadLine();

int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogspeed = 5;
int friend = 2;

if(distance>10)
{
    if(friend = 1)
    {
        double time=distance/(firstFriendSpeed+dogspeed);
        int friend = 2;
    }
    else
    {
        double  time=distance/(secondFriendSpeed+dogspeed);
        int friend = 1;
    }
double distance = distance - (firstFriendSpeed+secondFriendSpeed)*time;
count = count + 1;
}
else
{
    Console.Write(count);
}




//if(username.ToLower() == "маша")
//{
//    Console.WriteLine("Ура это же Маша");
//}
//else
//{
//    Console.Write("Hello ");
//    Console.Write(username);
//}
