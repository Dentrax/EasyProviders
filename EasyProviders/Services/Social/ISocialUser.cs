using System;

namespace EasyProviders.Services.Social {
    public interface ISocialUser {
        void Login(Action onDone, Action<bool> onFail);

        void Logout(Action onDone, Action<bool> onFail);

        bool IsLoggedIn();

        void UpdateScore();

        void RefreshFriends();
    }
}
