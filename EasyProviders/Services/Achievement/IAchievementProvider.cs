using System;

namespace EasyProviders.Services.Achievement {
    public interface IAchievementProvider : IServiceProvider {
        void AddProgress(Enum type, int value);
        void SetProgress(Enum type, int value);
    }
}