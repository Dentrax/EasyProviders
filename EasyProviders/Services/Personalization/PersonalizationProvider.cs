using System;
using FT.Cubeedra.Services.Personalization.Plugin;

namespace EasyProviders.Services.Personalization {
    public sealed class PersonalizationProvider : ServiceProvider, IPersonalizationProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {

            }
        }
        public AgeGatePlugin AgeGate { get; private set; }

        public PersonalizationProvider() {
            this.AgeGate = new AgeGatePlugin();
        }

        ~PersonalizationProvider() { }


        public override void Initialize(ServiceProvider.InitializeContext context) {
            if (!this.WasInitialized) {
                if (!this.AgeGate.WasLoaded) this.AgeGate.Load();

                this.WasInitialized = true;
            }
        }

        public override void Terminate() {
            if (this.WasInitialized) {
                if (this.AgeGate.WasLoaded) this.AgeGate.Release();

                GC.SuppressFinalize(this);
                this.WasInitialized = false;
            }
        }

        public override void Start() {
        }

        public override void Stop() {
        }
    }
}

