using System;

class MainClass {
  public static double CylinderVolume(double radius, double height){
    double volume = 3.14*radius*radius*height;
    return volume;
  }
  public static void Main (string[] args) {
    Console.WriteLine ("Input Cylinder radius");
    double radius = Convert.ToDouble(Console.ReadLine());
  
    Console.WriteLine ("Input Cylinder height");
    double height = Convert.ToDouble(Console.ReadLine());
    double volume = CylinderVolume(radius, height);
    Console.WriteLine("Cylinder Volume = "+ volume);
  }
}