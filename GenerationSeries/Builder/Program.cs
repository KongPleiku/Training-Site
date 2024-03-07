using System.Collections;

namespace Builder;
class Program
{
    static void Main(string[] args)
    {
        PlaneBuilder planeBuilder = new PlaneBuilder();
        Director director = new Director();

        director.Builder = planeBuilder;

        Plane newPLane =  new Plane();

        director.build();

        newPLane = planeBuilder.getProduct();

        Console.Read();
    }
}

public interface IBuilder{
    void BuildEngine();
    void BuildTire();
    void BuildSeat();
}

public class PlaneBuilder: IBuilder{
    Plane product = new Plane();
    public PlaneBuilder(){
        this.Reset();
    }
    public void Reset(){
        this.product = new Plane();
    }
    public void BuildEngine(){
        this.product.AddPart("V8");
    }
    public void BuildTire(){
        this.product.AddPart("TOYO TIRE");
    }
    public void BuildSeat(){
        this.product.AddPart("luxury");
    }

    public Plane getProduct(){
        Plane result = this.product;
        this.Reset();
        return result;
    }
}

public class Plane{
    ArrayList part_list = new ArrayList();

    public void AddPart(Object part){
        this.part_list.Add(part);
    }
}

public class Director{
    IBuilder builder;

    public IBuilder Builder{
        set {
            this.builder = value;
        }
        get{
            return this.builder;
        }
    }

    public void build(){
        this.builder.BuildEngine();
        this.builder.BuildSeat();
        this.builder.BuildTire();
    }

}

