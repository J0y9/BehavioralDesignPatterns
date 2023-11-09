// See https://aka.ms/new-console-template for more information

using StatePattern;

var vendingMachine = new VendingMachine(new Ready());
vendingMachine.InsertMoney();
vendingMachine.SelectItem();
vendingMachine.DispenseItem();