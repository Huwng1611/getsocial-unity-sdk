using System;
using System.Collections.Generic;

namespace GetSocialSdk.Core
{
    interface IGetSocialNativeBridge
    {

        #region initialization

        bool IsInitialized { get; }

        void Init(Action onSuccess, Action<GetSocialError> onFailure);

        #endregion


        #region general

        string GetNativeSdkVersion();

        string GetLanguage();

        bool SetLanguage(string languageCode);

        bool SetGlobalErrorListener(Action<GetSocialError> onError);

        bool RemoveGlobalErrorListener();

        #endregion


        #region smart_invites

        InviteChannel[] InviteChannels { get; }

        void SendInvite(string channelId, Action onComplete, Action onCancel, Action<GetSocialError> onFailure);

        void SendInvite(string channelId, InviteContent customInviteContent,
            Action onComplete, Action onCancel, Action<GetSocialError> onFailure);

        void SendInvite(string channelId, InviteContent customInviteContent, CustomReferralData customReferralData,
            Action onComplete, Action onCancel, Action<GetSocialError> onFailure);

        bool RegisterInviteChannelPlugin(string channelId, InviteChannelPlugin inviteChannelPlugin);

        void GetReferralData(Action<ReferralData> onSuccess, Action<GetSocialError> onFailure);

        #endregion

        #region push_notifications

        void RegisterForPushNotifications();

        void SetNotificationActionListener(Func<NotificationAction, bool> listener);

        #endregion

        #region user_management

        bool SetOnUserChangedListener(Action listener);

        bool RemoveOnUserChangedListener();

        string UserId { get; }

        bool IsUserAnonymous { get; }

        Dictionary<string, string> UserAuthIdentities { get; }

        string DisplayName { get; }

        void SetDisplayName(string displayName, Action onComplete, Action<GetSocialError> onFailure);

        string AvatarUrl { get; }

        void SetAvatarUrl(string avatarUrl, Action onComplete, Action<GetSocialError> onFailure);

        void AddAuthIdentity(AuthIdentity authIdentity,
            Action onComplete, Action<GetSocialError> onFailure, Action<ConflictUser> onConflict);

        void RemoveAuthIdentity(string providerId, Action onSuccess, Action<GetSocialError> onFailure);

        void SwitchUser(AuthIdentity authIdentity,
            Action onSuccess, Action<GetSocialError> onFailure);

        #endregion

        #region social_graph

        void AddFriend (string userId, Action<int> onSuccess, Action<GetSocialError> onFailure);

        void RemoveFriend (string userId, Action<int> onSuccess, Action<GetSocialError> onFailure);

        void IsFriend (string userId, Action<bool> onSuccess, Action<GetSocialError> onFailure);

        void GetFriendsCount(Action<int> onSuccess, Action<GetSocialError> onFailure);

        void GetFriends (int offset, int limit, Action<List<PublicUser>> onSuccess, Action<GetSocialError> onFailure);

        #endregion

        #region activity_feed

        void GetAnnouncements(string feed, Action<List<ActivityPost>> onSuccess, Action<GetSocialError> onFailure);

        void GetActivities(ActivitiesQuery query, Action<List<ActivityPost>> onSuccess,
            Action<GetSocialError> onFailure);

        void GetActivity(string activityId, Action<ActivityPost> onSuccess, Action<GetSocialError> onFailure);

        void PostActivityToFeed(string feed, ActivityPostContent content,
            Action<ActivityPost> onSuccess,
            Action<GetSocialError> onFailure);

        void PostCommentToActivity(string activityId, ActivityPostContent comment, Action<ActivityPost> onSuccess,
            Action<GetSocialError> onFailure);

        void LikeActivity(string activityId, bool isLiked, Action<ActivityPost> onSuccess,
            Action<GetSocialError> onFailure);

        void GetActivityLikers(string activityId, int offset, int limit, Action<List<PublicUser>> onSuccess,
            Action<GetSocialError> onFailure);

        #endregion


        #region access_helpers

        void Reset();

        void SetHadesConfiguration(int hadesConfigurationType);

        int GetCurrentHadesConfiguration();

        #endregion

    }
}