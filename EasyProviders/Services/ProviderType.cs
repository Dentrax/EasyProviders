#region License
// ====================================================
// EasyProviders Copyright(C) 2017 Furkan Türkal
// This program comes with ABSOLUTELY NO WARRANTY; This is free software,
// and you are welcome to redistribute it under certain conditions; See
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyProviders.Services {
    public enum ProviderType {
        Accessibility,
        Achievement,
        Advertising,
        Analytics,
        Audio,


        Country,
        Device,
        Globalization,
        Graphic,
        Holiday,
        IO,
        Internationalization,
        Localization,
        Multilingualization,

        Network,
        Notification,
        Personalization,


        Settings,
        UserService,
        Highscore,
        GameService,
        ABTest,
        SaveGameManager,
        RewardedVideoManager,
        ChallengeManager,
        EventManager,
        DailyChallengeManager,
        Verification,

        Social,
        Storage,
        Store,
        NONE
    }
}
