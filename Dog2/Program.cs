// See https://aka.ms/new-console-template for more information
Console.Write("Скорость первого друга: ");
int sp1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Скорость второго друга: ");
int sp2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Скорость собаки: ");
int spDog = Convert.ToInt32(Console.ReadLine());
Console.Write("Расстояние в метрах: ");
int dis = Convert.ToInt32(Console.ReadLine());
int fr = 1;
int count = 0;
int time = 0;
while(dis > 10){
    if(fr == 1){
        time = dis/(spDog + sp1);
        dis = dis - (time * (sp1 + sp2));
        fr = 2;
    }
    else{
        time = dis/(spDog + sp2);
        dis = dis - (time * (sp1 + sp2));
        fr = 1;
    }
    count ++;
}
Console.Write($"Собака пробежит {count} раз");
