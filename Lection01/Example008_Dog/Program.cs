int count = 0;
double distance = 10000;
double  firstFriendSpeed = 1;
double  secondFriendSpeed = 2;
double  dogSpeed = 50;
double  friend = 1;
double time = 0;


while(distance > 10) 
{
    if(friend == 1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else 
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
    }
distance = distance - time*(firstFriendSpeed + secondFriendSpeed);
count++;
}
Console.Write("собака пробежала раз ");
Console.Write(count);