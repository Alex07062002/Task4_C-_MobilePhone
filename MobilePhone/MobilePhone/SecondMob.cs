namespace MobilePhone;

internal class SecondMob : MobilePhone1
{
    private int _sim;
    
    public int Sim { get; set; }

    public SecondMob(string name, double cost, double memory, int sim) : base(name, cost, memory)
    {
        _sim = sim;
    }

    public override double Q()
    {
        return base.Q() * _sim;
    }
    
    public override string ToString()
    {
        return $"Название: {Name}, стоимость: {Cost}, память: {Memory},количество sim: {_sim}, функция Q: {Q()}";
    }
    
    }