using System;

namespace EasyProviders.Services.Globalization {
    public sealed class GlobalizationProvider : ServiceProvider, IGlobalizationProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {

            }
        }

        public GlobalizationProvider() {
        }

        ~GlobalizationProvider() { }


        public override void Initialize(ServiceProvider.InitializeContext context) {
            if (!this.WasInitialized) {

                this.WasInitialized = true;
            }
        }

        public override void Terminate() {
            if (this.WasInitialized) {

                GC.SuppressFinalize(this);
                this.WasInitialized = false;
            }
        }

        public override void Start() {
        }

        public override void Stop() {
        }

        public void Test() {
            Console.WriteLine("Hello from GlobalizationProvider::Test()");
        }

    }
}

