﻿using System;
using Newtonsoft.Json;

namespace com.strava.api.Clubs
{
    /// <summary>
    /// A summary of a Strava Club. The ClubSummary contains less information than a Club.
    /// </summary>
    public class ClubSummary
    {
        /// <summary>
        /// The id of the club. The id is provided by Strava and can't be changed.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The level of detail of the Club.
        /// </summary>
        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }

        /// <summary>
        /// The name of the club.
        /// </summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// Url to a 62x62 pixel picture of the club. Use the ImageLoader class to load the picture.
        /// </summary>
        [JsonProperty("profile_medium")]
        public String ProfileMedium { get; set; }

        /// <summary>
        /// Url to a 124x124 pixel picture of the club. Use the ImageLoader class to load the picture.
        /// </summary>
        [JsonProperty("profile")]
        public String Profile { get; set; }
    }
}
