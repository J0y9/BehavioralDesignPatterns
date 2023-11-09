// See https://aka.ms/new-console-template for more information

using ChainOfResponsibility;

var softwareHandler = new SoftwareHandler();
var hardwareHandler = new HardwareHandler();
var networkHandler = new NetworkHandler();

softwareHandler.NextTicketHandler = hardwareHandler;
hardwareHandler.NextTicketHandler = networkHandler;

var ticket1 = "Software";
var ticket2 = "Hardware";
var ticket3 = "Network";

var ticketSystem = new TicketSystem(softwareHandler);
ticketSystem.HandleTicket(ticket1);
ticketSystem.HandleTicket(ticket2);
ticketSystem.HandleTicket(ticket3);