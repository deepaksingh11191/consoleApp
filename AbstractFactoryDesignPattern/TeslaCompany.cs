using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern;

public class TeslaCompany : VehicleCompany
{
    public override IBike CreateBike()
    {
        return new TeslaBike();
    }

    public override ICar CreateCar()
    {
        return new TeslaCar();
    }
}
