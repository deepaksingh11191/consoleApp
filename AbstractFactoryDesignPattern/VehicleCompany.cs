using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern;

public abstract class VehicleCompany
{
    public abstract ICar CreateCar();
    public abstract IBike CreateBike();
}
