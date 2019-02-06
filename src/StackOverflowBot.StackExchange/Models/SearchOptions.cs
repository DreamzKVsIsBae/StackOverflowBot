using StackOverflowBot.StackExchange.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflowBot.StackExchange.Models
{
    public class SearchOptions
    {
        [HttpContent("order")]
        public string Order { get => "desc"; }

        [HttpContent("sort")]
        public string Sort { get => "activity"; }

        [HttpContent("site")]
        public string Site { get => "stackoverflow"; }

        [HttpContent("intitle")]
        public string InTitle { get; set; }
    }
}