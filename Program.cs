Boolean a(int x){
    Boolean t = false;
    if(x/10000<1){
        Console.WriteLine("Число должно быть пятизначным");
        return t ;
    }
int a1 = x /10000;
int a2 = (x%10000)-(x%100);
int a3 = x%100;
int a4 = x%10;

if(a1==a4|a2==a3){
    t = true;
    Console.WriteLine(t);
    return t;
}
Console.WriteLine(t);
    return t;
}


a(14212);
a(12821);
a(23432);