using System;
using System.Linq;
using System.Collections.Generic;

namespace EasyProviders.Services.Store {
    public abstract class StorePlugin : ServicePlugin {

        public bool CanMakePurchases { get; protected set; }

        public bool DidFetchProducts {
            get { return this.AllProducts != null && this.AllProducts.Count > 0; }
        }

        public bool IsFetchingProducts { get; protected set; }

        public bool IsPurchasingProduct { get; protected set; }

        public bool IsRestoringPurchases { get; protected set; }

        public bool InternetRequired { get; protected set; }

        public List<string> AllProducts { get; protected set; }

        public delegate void PurchaseDelegate(string productId, bool successful);
        public delegate void ConfirmPurchaseDelegate(string productId, string receiptId, string statusCode, bool successful);
        public delegate void PurchaseProgressDelegate(PurchaseState purchaseState, string productId, string receiptId = null, string statusCode = null);

        public StorePlugin.PurchaseProgressDelegate OnPurchaseProgress { get; protected set; }

        public abstract void FetchProducts(Action<bool> callback);
        public abstract void PurchaseProduct(string productId, StoreConsumeType consumeType, Func<string, bool> confirmCallback, Action<StoreErrorType> failureCallback);
        public abstract void RestorePurchases(Action<bool, string[]> callback);
     
        public StorePlugin() { }

        ~StorePlugin() { }

       
        public override void Load() {
            if (!this.WasLoaded) {
            

                this.WasLoaded = true;
            }
        }

        public override void Release() {
            if (this.WasLoaded) {

                GC.SuppressFinalize(this);
                this.WasLoaded = false;
            }
        }

    }
}
