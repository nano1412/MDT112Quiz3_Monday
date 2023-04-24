using System;

class Program{
  static void Main(string[] args){
    // virables
    int n = int.Parse(Console.ReadLine());
    string[] item = new string[n];
    string[] type = new string[n];

    // loop input
    for(int i = 0; i < n; i++){
      item[i] = Console.ReadLine();
      type[i] = Console.ReadLine();
    }

    // loop display
    bool isInloop = true;
    while(isInloop){
      string sort = Console.ReadLine();
      isInloop = Filter(item,type,sort);
    }
    Console.WriteLine("End");
  }
  static bool Filter(string[] item, string[] type, string sort){
    int counter = 0;
    for(int i = 0;i < type.Length; i++){
      if(sort == type[i] || sort == "ShowAll"){
        Console.WriteLine(item[i]);
        if(sort == "ShowAll"){
          Console.WriteLine(type[i]);
        }
        Console.WriteLine();
      } else {
        counter++;
      }
    }
    return counter < type.Length;
  }
}