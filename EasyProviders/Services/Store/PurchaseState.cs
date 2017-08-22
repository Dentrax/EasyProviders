namespace EasyProviders.Services.Store {
    public enum PurchaseState {
        Unidentified,
        PurchasePending,
        Purchased,
        Success,
        Failed,
        Canceled,
        AlreadyOwned,
        ItemUnavailable,
        AwaitingVoucherConsumtion,
        ConsumingVoucher,
        VoucherConsumed,
        Done
    }
}


