using System;

namespace EasyProviders.Services.Storage {
    public sealed class StorageProvider : ServiceProvider, IStorageProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {

            }
        }

        public StorageProvider() { }

        ~StorageProvider() { }

        public bool CanSave { get; set; }


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
    }
}
