namespace MobilePhone;

internal class MobilePhone1
{
    private string _name;
    private double _cost;
    private double _memory;

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public double Cost
    {
        get
        {
            return _cost;
        }
    }

    public double Memory
    {
        get
        {
            return _memory;
        }
    }

    public MobilePhone1(string name, double cost, double memory)
    {
        _name = name;
        _cost = cost;
        _memory = memory;
    }

    public virtual double Q(){
        return _cost / _memory;
        }

    public override string ToString()
    {
        return $"Название: {_name}, стоимость: {_cost}, память: {_memory}, функция Q: {Q()}";
    }
}