public class Circle : Shape

{

private double _radius;

 

public Circle(string color, double radius) : base(color)

{

_radius = radius;

}

 

// method to override

// area = pi * (r**2)

public override double GetArea()

{

return Math.PI * _radius * _radius;

}

}

