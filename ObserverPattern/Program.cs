// See https://aka.ms/new-console-template for more information

using ObserverPattern;

var newsPublisher = new NewsPublisher();

var subscriber1 = new NewsSubscriber();
var subscriber2 = new NewsSubscriber();

newsPublisher.AddObserver(subscriber1);
newsPublisher.AddObserver(subscriber2);
newsPublisher.PublishNews("NEWS: Heavy Raining Tomorrow");