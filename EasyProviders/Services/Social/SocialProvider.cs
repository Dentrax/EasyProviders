using System;

namespace EasyProviders.Services.Social {
    public sealed class SocialProvider : ServiceProvider, ISocialProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {

            }
        }

        public SocialProvider() { }

        ~SocialProvider() { }


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
