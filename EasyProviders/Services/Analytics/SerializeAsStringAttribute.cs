using System;

namespace EasyProviders.Services.Analytics {
    internal class SerializeAsStringAttribute : Attribute {
        private string v;

        public SerializeAsStringAttribute(string v) {
            this.v = v;
        }
    }
}