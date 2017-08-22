using System;

namespace EasyProviders.Services.Store {
    public sealed class SteamStorePlugin : StorePlugin, IStorePlatform {
        public override void FetchProducts(Action<bool> callback) {
            throw new NotImplementedException();
        }

        public override void PurchaseProduct(string productId, StoreConsumeType consumeType, Func<string, bool> confirmCallback, Action<StoreErrorType> failureCallback) {
            throw new NotImplementedException();
        }

        public override void RestorePurchases(Action<bool, string[]> callback) {
            throw new NotImplementedException();
        }
    }
}
