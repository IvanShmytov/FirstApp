
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarPlant Factory = new CarPlant();
            Conveyor builder = new CarConveyor();
            Factory.Construct(builder);
            builder.Product.Show();

            builder = new MotoConveyor();
            Factory.Construct(builder);
            builder.Product.Show();

            builder = new ScooterConveyor();
            Factory.Construct(builder);
            builder.Product.Show();

        }


    }
}
