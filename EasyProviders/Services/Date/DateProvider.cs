using System;

namespace EasyProviders.Services.Date {
    public sealed class DateProvider : ServiceProvider, IDateProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {

            }
        }

        public DateProvider() { }

        ~DateProvider() { }

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
            throw new NotImplementedException();
        }

        public override void Stop() {
            throw new NotImplementedException();
        }
    }
}
