using System;

namespace SimCorp.IMS.Framework
{
    public class Model
    {

        public Model(int ModelId,
                     string ModelName)
        {
            modelId = ModelId;
            modelName = ModelName;
        }

        public string GetModel() {
            return modelName;
        }

        private string modelName;

        public string ModelName
        {
            get { return modelName; }
            set { modelName = value; }
        }

        private int modelId;
        public int ModelId { get; set; }
    }
}
