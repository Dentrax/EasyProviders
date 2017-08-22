using System;

namespace EasyProviders.Services.Social.Platform.Facebook {
    public sealed class FacebookPlugin : SocialPlugin, ISocialPlatform {

        private readonly string[] m_requiredFacebookPermissions = new string[] { "public_profile", "user_friends", "publish_actions" };

        public static bool IsSupported {
            get { return false;  }
        }

        public override string PlayerID { get; protected set; }
        public override bool IsSignedIn { get; protected set; }

        public override bool IsLoginSystemSupported { get { return true; } }
        public override bool IsPublishSystemSupported { get { return true; } }
        public override bool IsAchievementSystemSupported { get { return true; } }
        public override bool IsLeaderboardSystemSupported { get { return true; } }
        public override bool IsScoreSystemSupported { get { return true; } }
        public override bool IsFriendSystemSupported { get { return true; } }
        public override bool IsRecommendSystemSupported { get { return true; } }

        public override void Load() {
        }

        public override void Release() {
            throw new NotImplementedException();
        }

        public void RegisterEventHandlers() {
            throw new NotImplementedException();
        }

        public void RemoveEventHandlers() {
            throw new NotImplementedException();
        }

        public override bool TrySignIn(out bool isSignedIn) {
            isSignedIn = false;
            return false;
        }

        public override bool TrySignOut(out bool isSignedOut) {
            isSignedOut = false;
            return false;
        }

        public override bool TryShowAchievements(out bool isShowed) {
            isShowed = false;
            return false;
        }

        public override bool TryShowLeaderboards(out bool isShowed) {
            isShowed = false;
            return false;
        }

        public override bool TryLoadFriends(out bool isLoaded) {
            isLoaded = false;
            return false;
        }

        public override bool TryLoadAchievements(out bool isLoaded) {
            isLoaded = false;
            return false;
        }

        public override bool TryReportAchievement(string id, float percent, out bool isReported) {
            isReported = false;
            return false;
        }

        public override bool TryReportScore(int newScore, bool isNewHighScore, out bool isReported) {
            isReported = false;
            return false;
        }
    }
}

