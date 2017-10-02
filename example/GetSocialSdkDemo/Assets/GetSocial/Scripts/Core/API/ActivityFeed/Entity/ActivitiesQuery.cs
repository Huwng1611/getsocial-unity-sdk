﻿using System;
using System.Collections.Generic;
using GetSocialSdk.MiniJSON;

namespace GetSocialSdk.Core
{
    /// <summary>
    /// Builder for a query to retrieve activity posts or comments.
    /// </summary>
    public sealed class ActivitiesQuery : IGetSocialBridgeObject<ActivitiesQuery>
    {
        /// <summary>
        /// Set of filtering options for <see cref="WithFilter(Filter, long)"/> method
        /// </summary>
        public enum Filter
        {
            /// <summary>
            /// No filter will be applied to the query.
            /// </summary>
            NoFilter,

            /// <summary>
            /// Query will provide all older activities.
            /// </summary>
            Older,

            /// <summary>
            /// Query will provide all newer activities.
            /// </summary>
            Newer
        }

        public const string GlobalFeed = "g-global";
        public const int DefaultLimit = 10;

        readonly ActivityPost.Type _type;
        readonly string _feed;
        readonly string _parentActivityId;

        int _limit = DefaultLimit;
        Filter _filter = Filter.NoFilter;
        string _filteringActivityId;
        string _filterUserId;
        bool _isFriendsFeed;

        ActivitiesQuery(ActivityPost.Type type, string feed, string parentActivityId)
        {
            _type = type;
            _feed = feed;
            _parentActivityId = parentActivityId;
        }

        public static ActivitiesQuery PostsForFeed(string feed)
        {
            return new ActivitiesQuery(ActivityPost.Type.Post, feed, null);
        }

        public static ActivitiesQuery PostsForGlobalFeed()
        {
            return new ActivitiesQuery(ActivityPost.Type.Post, GlobalFeed, null);
        }

        public static ActivitiesQuery CommentsToPost(string activityId)
        {
            return new ActivitiesQuery(ActivityPost.Type.Comment, null, activityId);
        }

        public ActivitiesQuery WithLimit(int limit)
        {
            _limit = limit;
            return this;
        }

        public ActivitiesQuery WithFilter(Filter filter, string activityId)
        {
            _filter = filter;
            _filteringActivityId = activityId;
            return this;
        }

        public ActivitiesQuery FilterByUser(String userId)
        {
            _filterUserId = userId;
            return this;
        }

        public ActivitiesQuery FriendsFeed(bool isFriendsFeed)
        {
            _isFriendsFeed = isFriendsFeed;
            return this;
        }

#if UNITY_ANDROID
        public UnityEngine.AndroidJavaObject ToAJO()
        {
            var activitiesQueryClass = new UnityEngine.AndroidJavaClass("im.getsocial.sdk.activities.ActivitiesQuery");
            var activitiesQuery = _type == ActivityPost.Type.Post
                ? activitiesQueryClass.CallStaticAJO("postsForFeed", _feed)
                : activitiesQueryClass.CallStaticAJO("commentsToPost", _parentActivityId);

            activitiesQuery.CallAJO("withLimit", _limit);
            activitiesQuery.CallAJO("filterByUser", _filterUserId);
            activitiesQuery.CallAJO("friendsFeed", _isFriendsFeed);
            if (_filter != Filter.NoFilter)
            {
                var filterClass = new UnityEngine.AndroidJavaClass("im.getsocial.sdk.activities.ActivitiesQuery$Filter");
                var filter = filterClass.CallStaticAJO("valueOf", _filter.ToString().ToUpper());
                activitiesQuery.CallAJO("withFilter", filter, _filteringActivityId);
            }
            return activitiesQuery;
        }

        public ActivitiesQuery ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            throw new NotImplementedException("ActivitiesQuery is never received from Android");
        }
#elif UNITY_IOS

        public string ToJson()
        {
            var jsonDic = new Dictionary<string, object>
            {
                {"Feed", _feed},
                {"Type", (int) _type},
                {"ParentActivityId", _parentActivityId},
                {"Limit", _limit},
                {"Filter", (int) _filter},
                {"FilteringActivityId", _filteringActivityId},
                {"FilterUserId", _filterUserId},
                {"FriendsFeed", _isFriendsFeed}
            };
            return GSJson.Serialize(jsonDic);
        }

        public ActivitiesQuery ParseFromJson(Dictionary<string, object> json)
        {
            throw new NotImplementedException("ActivitiesQuery is never received from iOS");
        }

#endif
    }
}