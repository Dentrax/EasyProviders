using System;

namespace EasyProviders.Services.Analytics {
    internal class SerializeSizeLimitAttribute : Attribute {
        private int v1;
        private bool v2;

        public SerializeSizeLimitAttribute(int v1, bool v2) {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}