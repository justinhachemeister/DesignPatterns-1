﻿using System;
using DesignPatterns.SoftwareDesignPattern.Creational.AbstractFactory.ProductFamily1;

namespace DesignPatterns.SoftwareDesignPattern.Creational.AbstractFactory {
  public class AbstractFactoryPatternSample : IDesignPatternSample {
    public void ShowSample() {
      IAbstractFactory factory = new ConcreteFactory();

      var product1 = factory.CreateProductA();
      var product2 = factory.CreateProductB();

      Console.WriteLine($"{nameof(IAbstractFactory)} {nameof(ConcreteFactory)} creates {nameof(IProductA)} {factory.CreateProductA().GetType().Name}");
      Console.WriteLine($"{nameof(IAbstractFactory)} {nameof(ConcreteFactory)} creates {nameof(IProductB)} {factory.CreateProductB().GetType().Name}");
    }
  }
}
