using StrategyPattern;
var paypalPayment = new ProcessPayment(new Paypal());
paypalPayment.Pay();

var creditCardPayment = new ProcessPayment(new CreditCard());
creditCardPayment.Pay();
