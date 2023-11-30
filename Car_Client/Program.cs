public interface Builder
{
    public void reset();
    public void setSeats(int number);
    public void setEngine(int engine);
    public void setTripComputer();
    public void setGPS();
}

public class Director : Builder
{
    public void makeSUV(Builder builder)
    {
        //makeSUV
    }

    public void makeSportsCar(Builder builder)
    {
        //makeSportsCar
    }
    public void reset()
    {
        //reset
    }

    public void setEngine(int engine)
    {
        //setEngine
    }

    public void setGPS()
    {
        //setGPS
    }

    public void setSeats(int number)
    {
        //setSeats
    }

    public void setTripComputer()
    {
        //setTripComputer
    }
}

public class Client
{
    public Director director = new Director();
    CarBuilder builder = new CarBuilder();

    public void Foo()
    {
        director.makeSportsCar(builder);
        Car car = builder.getResult();
    }
}

public class CarBuilder : Builder
{
    public Car car = new Car();

    public void reset()
    {
        //reset
    }

    public void setEngine(int engine)
    {
        //setEngine
    }

    public void setGPS()
    {
        //setGPS
    }

    public void setSeats(int number)
    {
        //setSeats
    }

    public void setTripComputer()
    {
        //setTripComputer
    }

    public Car getResult() { return new Car(); }


}

public class Car
{

}

public class CarManualBuilder : Builder
{
    public Manual manual = new Manual();
    public void reset()
    {
        this.manual = new Manual();
    }

    public void setEngine(int engine)
    {
        //setEngine
    }

    public void setGPS()
    {
        //setGPS
    }

    public void setSeats(int number)
    {
        //setSeats
    }

    public void setTripComputer()
    {
        //setTripComputer
    }

    public Manual getResult() { return manual; }
}

public class Manual
{

}