
//Задача 19
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

// Задача 21

// Задача 23
Array d(int n){
    int [] p = new int[n];
    for(int i = 1;i<=n;i++){
        int y = i;
p[i-1] =(int) Math.Pow(y, 3);
Console.Write(p[i-1]+" ");
    }
    Console.WriteLine();
    return p ;
    
}

d(3);
d(5);
