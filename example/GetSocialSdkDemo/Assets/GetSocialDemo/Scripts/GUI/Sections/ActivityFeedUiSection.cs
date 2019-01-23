using System;
using System.Collections.Generic;
using System.Linq;
using Assets.GetSocialDemo.Scripts.Utils;
using Facebook.Unity;
using GetSocialSdk.Core;
using UnityEngine;

#if USE_GETSOCIAL_UI
using GetSocialSdk.Ui;

public class ActivityFeedUiSection : DemoMenuSection
{
    string _feed = "default";

    protected override string GetTitle()
    {
        return "Activity Feed UI";
    }

    protected override void DrawSectionBody()
    {
        DemoGuiUtils.DrawButton("Global Feed", OpenGlobalFeed, true, GSStyles.Button);
        DemoGuiUtils.Space();
        
        DemoGuiUtils.DrawButton("My Global Feed", OpenMyGlobalFeed, true, GSStyles.Button);
        DemoGuiUtils.Space();
        
        DemoGuiUtils.DrawButton("My Custom Feed", OpenMyCustomFeed, true, GSStyles.Button);
        DemoGuiUtils.Space();
        
        DemoGuiUtils.DrawButton("My Friends Global Feed", OpenMyFriendsGlobalFeed, true, GSStyles.Button);
        DemoGuiUtils.Space();

        DemoGuiUtils.DrawButton("Open Activity Details", OpenActivityDetailsFunc(true), true, GSStyles.Button);
        DemoGuiUtils.Space();

        DemoGuiUtils.DrawButton("Open Activity Details(without feed)", OpenActivityDetailsFunc(false), true, GSStyles.Button);
        DemoGuiUtils.Space();

        // feed by id
        _feed = GUILayout.TextField(_feed, GSStyles.TextField);
        DemoGuiUtils.DrawButton("Feed By Id", OpenFeedWithId, true, GSStyles.Button);
    }

    private void OpenMyCustomFeed()
    {
        GetSocialUi.CreateActivityFeedView(_feed)
                    .SetWindowTitle("My Custom Feed")
#pragma warning disable 0618
                    .SetButtonActionListener(OnActivityActionClicked)
#pragma warning restore 0618
                    .SetActionListener(OnAction)
                    .SetFilterByUser(GetSocial.User.Id)
                    .Show();
    }

    private void OpenMyFriendsGlobalFeed()
    {
        GetSocialUi.CreateGlobalActivityFeedView()
            .SetWindowTitle("My Friends Feed")
#pragma warning disable 0618
            .SetButtonActionListener(OnActivityActionClicked)
#pragma warning restore 0618
            .SetActionListener(OnAction)
            .SetShowFriendsFeed(true)
            .Show();
    }

    private void OpenMyGlobalFeed()
    {
        OpenFiteredGlobalFeedAction("My Global Feed", GetSocial.User.Id);
    }

    private void OpenUserGlobalFeed(PublicUser user)
    {
        OpenFiteredGlobalFeedAction(user.DisplayName + " Global Feed", user.Id);
    }
    
    private void OpenFiteredGlobalFeedAction(string title, string userId)
    {
        GetSocialUi.CreateGlobalActivityFeedView()
            .SetWindowTitle(title)
#pragma warning disable 0618
            .SetButtonActionListener(OnActivityActionClicked)
#pragma warning restore 0618
            .SetActionListener(OnAction)
            .SetFilterByUser(userId)
            .SetReadOnly(true)
            .Show();
    }

    private void OpenFeedWithId()
    {
        GetSocialUi.CreateActivityFeedView(_feed)
            .SetWindowTitle(_feed + " Feed")
#pragma warning disable 0618
            .SetButtonActionListener(OnActivityActionClicked)
#pragma warning restore 0618
            .SetActionListener(OnAction)
            .Show();
    }

    private void OpenGlobalFeed()
    {
        GetSocialUi.CreateGlobalActivityFeedView()
            .SetWindowTitle("Unity Global")
            .SetViewStateCallbacks(() => _console.LogD("Global feed opened"), () => _console.LogD("Global feed closed"))
#pragma warning disable 0618
            .SetButtonActionListener(OnActivityActionClicked)
#pragma warning restore 0618
            .SetActionListener(OnAction)
            .SetMentionClickListener(OnMentionClicked)
            .SetAvatarClickListener(OnUserAvatarClicked)
            .SetTagClickListener(OnTagClicked)
            .SetUiActionListener(OnUiAction)
            .Show();
    }

    private void OnMentionClicked(string mention)
    {
        if (mention == MentionShortcuts.App)
        {
            DemoUtils.ShowPopup("Mention", "Application mention clicked.");
            return;
        }
        GetSocial.GetUserById(mention, OnUserAvatarClicked, error => _console.LogE("Failed to get user details, error:" + error.Message));
    }

    private void OnTagClicked(string tag) 
    {
        GetSocialUi.CreateGlobalActivityFeedView()
            .SetWindowTitle("Search #" + tag)
#pragma warning disable 0618
            .SetButtonActionListener(OnActivityActionClicked)
#pragma warning restore 0618
            .SetActionListener(OnAction)
            .SetReadOnly(true)
            .SetFilterByTags(tag)
            .Show();
    }

    private void OnUserAvatarClicked(PublicUser publicUser)
    {
        if (GetSocial.User.Id.Equals(publicUser.Id))
        {
            var popup = new MNPopup ("Action", "Choose Action");
            popup.AddAction("Show My Feed", OpenMyGlobalFeed);
            popup.AddAction("Cancel", () => { });
            popup.Show();
        }
        else
        {
            GetSocial.User.IsFriend(publicUser.Id, isFriend =>
            {
                if (isFriend)
                {
                    var popup = new MNPopup ("Action", "Choose Action");
                    popup.AddAction("Show " + publicUser.DisplayName + " Feed", () => OpenUserGlobalFeed(publicUser));
                    popup.AddAction("Remove from Friends", () => RemoveFriend(publicUser));
                    popup.AddAction("Cancel", () => { });
                    popup.Show();
                }
                else
                {
                    var popup = new MNPopup ("Action", "Choose Action");
                    popup.AddAction("Show " + publicUser.DisplayName + " Feed", () => OpenUserGlobalFeed(publicUser));
                    popup.AddAction("Add to Friends", () => AddFriend(publicUser));
                    popup.AddAction("Cancel", () => { });
                    popup.Show();
                }
            }, error => _console.LogE("Failed to check if friends with " + publicUser.DisplayName + ", error:" + error.Message));
        }
    }

    private void AddFriend(PublicUser user)
    {
        GetSocial.User.AddFriend(user.Id,
            friendsCount =>
            {
                var message = user.DisplayName + " is now your friend."; 
                _console.LogD(message);
                DemoUtils.ShowPopup("Info", message);
            },
            error => _console.LogE("Failed to add a friend " + user.DisplayName + ", error:" + error.Message));
    }

    private void RemoveFriend(PublicUser user)
    {
        GetSocial.User.RemoveFriend(user.Id,
            friendsCount =>
            {
                var message = user.DisplayName + " is not your friend anymore."; 
                _console.LogD(message);
                DemoUtils.ShowPopup("Info", message);
            },
            error => _console.LogE("Failed to remove a friend " + user.DisplayName + ", error:" + error.Message));
    }

    private Action OpenActivityDetailsFunc(bool showFeed)
    {
        return () =>
        {
            GetSocial.GetActivities(ActivitiesQuery.PostsForGlobalFeed().WithLimit(1), (posts) =>
            {
                if (posts.Count == 0)
                {
                    _console.LogW("No activities, post something to global feed!");
                    return;
                }
                GetSocialUi.CreateActivityDetailsView(posts.First().Id)
                    .SetWindowTitle("Unity Global")
                    .SetViewStateCallbacks(() => _console.LogD("Activity details opened"),
                        () => _console.LogD("Activity details closed"))
#pragma warning disable 0618
                    .SetButtonActionListener(OnActivityActionClicked)
#pragma warning restore 0618
                    .SetActionListener(OnAction)
                    .SetShowActivityFeedView(showFeed)
                    .SetUiActionListener((action, pendingAction) =>
                    {
                        Debug.Log("Action invoked: " + action);
                        pendingAction();
                    })
                    .Show();
            }, (error) => _console.LogE("Failed to get activities, error: " + error.Message));
        };
    }

    private void OnUiAction(UiAction action, Action pendingAction)
    {
        var forbiddenForAnonymous = new List<UiAction>()
        {
            UiAction.LikeActivity, UiAction.LikeComment, UiAction.PostActivity, UiAction.PostComment
        };
        if (forbiddenForAnonymous.Contains(action) && GetSocial.User.IsAnonymous)
        {
            var message = "Action " + action + " is not allowed for anonymous.";
#if UNITY_ANDROID
            MainThreadExecutor.Queue(() => {
                DemoUtils.ShowPopup("Info", message);
            });
#else
            DemoUtils.ShowPopup("Info", message);
#endif
            _console.LogD(message);
        }
        else
        {
            pendingAction();
        }
    }

    void OnActivityActionClicked(string actionId, ActivityPost post)
    {
        var message = string.Format("Activity feed button clicked, action type: {0}", actionId); 
        var popup = new MNPopup ("Info", message);
        popup.AddAction("OK", () => {});
        popup.Show();
        _console.LogD(message);
    }

    bool OnAction(GetSocialAction action)
    {
        return demoController.HandleAction(action);
    }
}

#endif