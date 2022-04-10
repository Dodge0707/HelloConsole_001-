int firstFriend = 1;
int secondFriend = 2;
int dogspeed = 5;
int count = 0;
int d = 10000; 


while (d > 10)
{
    int time = 0;
    int friend = 1;
    
    if (friend == 1)
    {
        time = d / (firstFriend + dogspeed);
        friend = 2;
    } else
    {
        time = d / (secondFriend + dogspeed);
        friend = 1;
    }

    d = d - (firstFriend + secondFriend) * time;
    count ++;
}

Console.WriteLine(count);