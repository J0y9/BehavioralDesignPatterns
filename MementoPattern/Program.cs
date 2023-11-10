// See https://aka.ms/new-console-template for more information

using MementoPattern;

var originator = new Originator();
var careTaker = new CareTaker();

originator.State = "on";
careTaker.Mementos.Add(originator.SaveState());
originator.State = "off";
careTaker.Mementos.Add(originator.SaveState());
originator.RestoreState(careTaker.Mementos[0]);

Console.WriteLine(originator.State);