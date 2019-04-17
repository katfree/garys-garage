using System;
using System.Collections.Generic;

namespace garysgarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Purple",
                MaximumOccupancy = 2,
                BatteryKWh = 001.01
            };
            Zero fx = new Zero()
            {
                MainColor = "Yellow",
                MaximumOccupancy = 4,
                BatteryKWh = 12312.123
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Grey",
                MaximumOccupancy = 5,
                BatteryKWh = 313.12
            };

            List<IElectricPowered> electricVehicles = new List<IElectricPowered>();

            electricVehicles.Add(fx);
            electricVehicles.Add(fxs);
            electricVehicles.Add(modelS);

            electricVehicles.ForEach(gv => gv.ChargeBattery());

            /*
                Create some gas vehicles, add them to a List
                and then iterate the List to fill all of their
                fuel tanks.
            */
            Ram ram = new Ram()
            {
                MainColor = "Red",
                MaximumOccupancy = 2,
                FuelCapacity = 22.23
            };
            Cessna cessna150 = new Cessna()
            {
                MainColor = "Blue",
                MaximumOccupancy = 2,
                FuelCapacity = 55.23
            };

            List<IGasPowered> gasVehicles = new List<IGasPowered>() {
                ram, cessna150
            };

            gasVehicles.ForEach(gv => gv.RefuelTank());


            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            fx.Drive();
            fx.Turn();
            fx.Stop();
            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            ram.Drive();
            ram.Turn();
            ram.Stop();
            cessna150.Drive();
            cessna150.Turn();
            cessna150.Stop();
        }
    }
}
