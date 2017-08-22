using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyProviders.Services.Audio {
    public sealed class AudioProvider : ServiceProvider, IAudioProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {

            }
        }

        public AudioProvider() { }

        ~AudioProvider() { }

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

        public void Play(string effect) {
            throw new NotImplementedException();
        }
    }
}
