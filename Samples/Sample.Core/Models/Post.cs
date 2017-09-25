using System;
using System.Runtime.Serialization;

namespace Sample.Core.Models
{
    public class Post
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}
