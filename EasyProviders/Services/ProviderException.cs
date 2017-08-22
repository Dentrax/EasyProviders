#region License
// ====================================================
// EasyProviders Copyright(C) 2017 Furkan Türkal
// This program comes with ABSOLUTELY NO WARRANTY; This is free software,
// and you are welcome to redistribute it under certain conditions; See
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion

using System;

namespace EasyProviders.Services {
    internal class ProviderException : Exception {
        public ProviderException() {
        }

        public ProviderException(string message) : base(message) {
        }

        public ProviderException(string message, Exception innerException) : base(message, innerException) {
        }
    }
}