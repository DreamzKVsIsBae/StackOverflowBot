using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace StackOverflowBot.StackExchange.Models
{
    public class SearchResponse
    {
        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("quota_max")]
        public long QuotaMax { get; set; }

        [JsonProperty("quota_remaining")]
        public long QuotaRemaining { get; set; }
    }

    public class Item
    {
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("is_answered")]
        public bool IsAnswered { get; set; }

        [JsonProperty("view_count")]
        public long ViewCount { get; set; }

        [JsonProperty("answer_count")]
        public long AnswerCount { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("last_activity_date")]
        public long LastActivityDate { get; set; }

        [JsonProperty("creation_date")]
        public long CreationDate { get; set; }

        [JsonProperty("last_edit_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastEditDate { get; set; }

        [JsonProperty("question_id")]
        public long QuestionId { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("closed_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? ClosedDate { get; set; }

        [JsonProperty("closed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedReason { get; set; }

        [JsonProperty("accepted_answer_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AcceptedAnswerId { get; set; }
    }

    public class Owner
    {
        [JsonProperty("reputation")]
        public long Reputation { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("user_type")]
        public string UserType { get; set; }

        [JsonProperty("profile_image")]
        public Uri ProfileImage { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("accept_rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? AcceptRate { get; set; }
    }
}
