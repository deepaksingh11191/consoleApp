using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern;

public class TataCompany : VehicleCompany
{
    public override IBike CreateBike()
    {
        return new TataBike();
    }

    public override ICar CreateCar()
    {
        return new TataCar();
    }
}
