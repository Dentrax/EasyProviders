using System;

namespace EasyProviders.Services.Achievement {
    public sealed class AchievementProvider : ServiceProvider, IAchievementProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {
            public InitializeContext() : base() {

            }
        }

        public AchievementProvider() { }

        ~AchievementProvider() { }

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

        public void AddProgress(Enum type, int value) {
            throw new NotImplementedException();
        }

        public void SetProgress(Enum type, int value) {
            throw new NotImplementedException();
        }
    }
}
