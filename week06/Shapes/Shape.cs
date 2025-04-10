public class Shape

{

    private string _color;

    

    // constructor

    public Shape(string color)

    {

    _color = color;

    }

    

    // methods

    public string GetColor()

    {

    return _color;

    }

    

    public void SetColor(string colorSet)

    {

    _color = colorSet;

    }

    

    // public abstract double GetArea(); // an abstract method does not have {} at the end.
    public virtual double GetArea(){
        return 0.1;
    }

}