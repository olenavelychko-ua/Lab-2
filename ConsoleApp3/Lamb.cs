using System;
using System.Collections.Generic;
using System.Text;
public class Lamb
{
    public int weight;
    public int height;
    public string color;

    public Lamb(int weight, int height, string color)
    {
        this.weight = weight;
        this.height = height;
        this.color = color;
    }

    public Lamb ShallowCopy()
    {
        return (Lamb)this.MemberwiseClone();
    }

    public Lamb DeepCopy()
    {
        Lamb dolly = new Lamb(this.weight, this.height, this.color);
        return dolly;
    }

    override public String ToString()
    {
        return "Lamb { weight:" + weight + ", height: " + height + ", color:" + color + " }";
    }
}
