using System;
using System.Collections.Generic;

namespace EasyProviders.Services.Social {
    public abstract class SocialPlugin : ServicePlugin {

        public abstract string PlayerID { get; protected set; }
        public List<SocialUser> Friends { get; protected set; }

        public abstract bool IsSignedIn { get; protected set; }
        public abstract bool IsLoginSystemSupported { get; }
        public abstract bool IsPublishSystemSupported { get; }
        public abstract bool IsAchievementSystemSupported { get; }
        public abstract bool IsLeaderboardSystemSupported { get; }
        public abstract bool IsScoreSystemSupported { get; }
        public abstract bool IsFriendSystemSupported { get; }
        public abstract bool IsRecommendSystemSupported { get; }

        public SocialPlugin() { }

        ~SocialPlugin() { }


        public event Action<SocialPlugin> onSocialSignInSuccess;

        public event Action<SocialPlugin> onSocialSignInFail;

        public event Action<SocialPlugin> onSocialSignOutSuccess;

        public event Action<SocialPlugin> onSocialSignOutFail;

        public event Action<SocialPlugin> onSocialFriendsLoaded;

        public event Action<SocialPlugin> onSocialAchievementsLoaded;

        public event Action<SocialPlugin> onSocialUserUpdated;

        public event Action<SocialPlugin> onSocialUserPhotoDownloaded;

        public event Action<SocialPlugin, string, float> onSocialReportAchievement;

        public event Action<SocialPlugin, int, bool> onSocialReportScore;


        public abstract bool TrySignIn(out bool isSignedIn);

        public abstract bool TrySignOut(out bool isSignedOut);

        public abstract bool TryShowAchievements(out bool isShowed);

        public abstract bool TryShowLeaderboards(out bool isShowed);

        public abstract bool TryLoadFriends(out bool isLoaded);

        public abstract bool TryLoadAchievements(out bool isLoaded);

        public abstract bool TryReportAchievement(string id, float percent, out bool isReported);

        public abstract bool TryReportScore(int newScore, bool isNewHighScore, out bool isReported);

        protected void OnSocialFriendsLoaded(SocialPlugin plugin) {
            if (this.onSocialFriendsLoaded != null) this.onSocialFriendsLoaded(plugin);
        }

        protected void OnSocialAchievementsLoaded(SocialPlugin plugin) {
            if (this.onSocialAchievementsLoaded != null) this.onSocialAchievementsLoaded(plugin);
        }

        protected void OnSocialReportAchievement(SocialPlugin plugin, string id, float percent) {
            if (this.onSocialReportAchievement != null) this.onSocialReportAchievement(plugin, id, percent);
        }

        protected void OnSocialReportScore(SocialPlugin plugin, int newScore, bool isNewHighScore) {
            if (this.onSocialReportScore != null) this.onSocialReportScore(plugin, newScore, isNewHighScore);
        }

        protected void OnSocialUserUpdated(SocialPlugin plugin) {
            if (this.onSocialUserUpdated != null) this.onSocialUserUpdated(plugin);
        }

        protected void OnSocialUserPhotoDownloaded(SocialPlugin plugin) {
            if (this.onSocialUserPhotoDownloaded != null) this.onSocialUserPhotoDownloaded(plugin);
        }

        protected void OnSocialSignInSuccess(SocialPlugin plugin) {
            if (this.onSocialSignInSuccess != null) this.onSocialSignInSuccess(plugin);
        }

        protected void OnSocialSignInFail(SocialPlugin plugin) {
            if (this.onSocialSignInFail != null) this.onSocialSignInFail(plugin);
        }

        protected void OnSocialSignOutSuccess(SocialPlugin plugin) {
            if (this.onSocialSignOutSuccess != null) this.onSocialSignOutSuccess(plugin);
        }

        protected void OnSocialSignOutFail(SocialPlugin plugin) {
            if (this.onSocialSignOutFail != null) this.onSocialSignOutFail(plugin);
        }

    }
}

