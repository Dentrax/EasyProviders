using System;

namespace FT.Cubeedra.Services.Personalization.Plugin {
    public sealed class AgeGatePlugin : P13NPlugin {

        public delegate void AgeGatePluginDelegate();

        public event AgeGatePluginDelegate OnDidPass;
        public event AgeGatePluginDelegate OnDidNotPass;
        public event AgeGatePluginDelegate OnCancel;
        public event AgeGatePluginDelegate OnDidShow;


        public bool WasLoaded { get; private set; }
        public bool IsAsked { get; private set; }
        public bool IsPassed { get; private set; }

        public bool IsReady {
            get { return false; }
        }

        public string PluginID {
            get { return "EasyProviders.AgeGate"; }
        }

        public bool MustAskOrDidPass {
            get { return this.DidPass || this.MustAsk; }
        }

		public bool MustAsk {
            get { return !this.IsAsked; }
        }

		public bool DidPass
		{
			get { return this.IsPassed; }
            private set
			{
				this.DidAsk();
                if (this.IsPassed != value) {
                    this.IsPassed = value;
                }
			}
		}

        public AgeGatePlugin() {
            this.IsAsked = false;
            this.IsPassed = false;
        }

        ~AgeGatePlugin() { }

        public void Load() {
            if (!this.WasLoaded) {
                this.WasLoaded = true;
            }
        }
        public void Release() {
            if (this.WasLoaded) {

                GC.SuppressFinalize(this);
                this.WasLoaded = false;
            }
        }

        private void DidAsk() {
            if (!this.IsAsked) {
                this.IsAsked = true;
            }
        }

        public void RaiseOnDidPass() {
            this.DidPass = true;
            if (OnDidPass != null) OnDidPass();
        }

        public void RaiseOnDidNotPass() {
            this.DidPass = false;
            if (OnDidNotPass != null) OnDidNotPass();
        }

        public void RaiseOnCancel() {
            if (OnCancel != null) OnCancel();
        }

        public void RaiseOnDidShow() {
            if (OnDidShow != null) OnDidShow();
        }
    }
}

