using GetSocialSdk.MiniJSON;

namespace GetSocialSdk.Core
{
    /// <summary>
    /// Builder for a query to retrieve topics.
    /// </summary>
    public sealed class TopicsQuery 
    {
        [JsonSerializationKey("searchTerm")]
        internal string SearchTerm;

        [JsonSerializationKey("followerId")]
        internal UserId FollowerId;

        TopicsQuery(string searchTerm)
        {
            this.SearchTerm = searchTerm;
        }
        
        /// <summary>
        /// Find topics by name or description.
        /// </summary>
        /// <param name="searchTerm">topics name/description or part of it.</param>
        /// <returns>new query</returns>
        public static TopicsQuery Find(string searchTerm) {
            return new TopicsQuery(searchTerm);
        }

        /// <summary>
        /// Get all topics.
        /// </summary>
        /// <returns>new query.</returns>
        public static TopicsQuery All() {
            return new TopicsQuery("");
        }

        /// <summary>
        /// Get topics followed by a certain user.
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>new query.</returns>
        public static TopicsQuery FollowedBy(UserId userId)
        {
            var query = All();
            query.FollowerId = userId;
            return query;
        }

    }
}
