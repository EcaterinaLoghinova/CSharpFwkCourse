using System;

namespace MobilePhone
{
    public class Model {

        public Model(int modelId) {
            ModelId = modelId;
        }
        public int ModelId { get; private set; }
        public string Brand { get; set; }
        public int Series { get; set; }

    }
}
