namespace EasyProviders.Services.Notification {
    public struct Notification {

        public string Type;

        public string Message;

        public Notification(string type, string message) {
            this.Type = type;
            this.Message = message;
        }
    }
}

