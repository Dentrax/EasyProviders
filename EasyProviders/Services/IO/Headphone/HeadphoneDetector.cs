namespace EasyProviders.Services.IO.Headphone {
    public class HeadphoneDetector {

        public void Init() {
        }

        private void OnNativeHeadphoneEvent(string message) {
            bool connected = (message == "true");
        }

        public bool IsPluggedIn() {
            return false;
        }

        private void OnDestroy() {
        }
    }

}
