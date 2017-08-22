using System;
using EasyProviders.Services;
using EasyProviders.Services.Accessibility;

namespace EasyProviders.Services.Accessibility {
    public sealed class AccessibilityProvider : ServiceProvider, IAccessibilityProvider {
        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {

            }
        }

        public AccessibilityProvider() { }

        ~AccessibilityProvider() { }

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

