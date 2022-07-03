
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class MotoConveyor : Conveyor
    {
        public MotoConveyor()
        {
            _product = new Product("Мотоцикл");
        }

        public override void BuildDoors()
        {
            _product["doors"] = "0";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "70 л.с.";
        }

        public override void BuildFrame()
        {
            _product["frame"] = "рама мотоцикла";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "2";
        }
    }
}
