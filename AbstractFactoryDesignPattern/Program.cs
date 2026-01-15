// See https://aka.ms/new-console-template for more information

using AbstractFactoryDesignPattern;

VehicleCompany tesla = new TeslaCompany();
ICar teslaCar = tesla.CreateCar();
IBike teslaBike = tesla.CreateBike();

VehicleCompany tata= new TataCompany();
ICar tataCar = tata.CreateCar();
IBike tataBike = tata.CreateBike();


