using System;

namespace EasyProviders.Services.Store {
    public sealed class StoreProvider : ServiceProvider, IStoreProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {
               
            }
        }

        public StoreProvider() { }

        ~StoreProvider() { }


        public override void Initialize(ServiceProvider.InitializeContext context) {
            if (!this.WasInitialized) {

                InitializeContext init = context as InitializeContext;


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

        public void RequestIAPInfo() {
        }

        public bool ProductRequestSucceeded() {
            return false;
        }

        public void FetchProducts(Action<bool> callback) {
            throw new NotImplementedException();
        }

        public void PurchaseProduct(string productId, StoreConsumeType consumeType, Func<string, bool> confirmCallback, Action<StoreErrorType> failureCallback) {
            throw new NotImplementedException();
        }

        public void RestorePurchases(Action<bool, string[]> callback) {
            throw new NotImplementedException();
        }

    }
}
