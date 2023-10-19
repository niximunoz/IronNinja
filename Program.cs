Buffet buffet1 = new Buffet();
SweetTooth ninja1 = new SweetTooth();
SpiceHound ninja2 = new SpiceHound();
Console.WriteLine("Ninja 1:");
while (!ninja1.IsFull)
{
    ninja1.Consume(buffet1.Serve());
}
Console.WriteLine("Ninja 2:");
while (!ninja2.IsFull)
{
    ninja2.Consume(buffet1.Serve());
}