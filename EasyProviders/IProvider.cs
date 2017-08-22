namespace EasyProviders {
    public interface IProvider {
        bool IsStarted { get; }
        void Start();
        void Stop();
    }
}
