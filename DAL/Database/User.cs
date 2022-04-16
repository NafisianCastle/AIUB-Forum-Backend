//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User(object unknown)
        {
            this.Admins = new HashSet<Admin>();
            this.AnswerComments = new HashSet<AnswerComment>();
            this.Answers = new HashSet<Answer>();
            this.AnswerVotes = new HashSet<AnswerVote>();
            this.Badges = new HashSet<Badge>();
            this.Comments = new HashSet<Comment>();
            this.Companies = new HashSet<Company>();
            this.Moderators = new HashSet<Moderator>();
            this.Posts = new HashSet<Post>();
            this.Tokens = new HashSet<Token>();
            this.Votes = new HashSet<Vote>();
        }
    
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string AboutMe { get; set; }
        public Nullable<int> Views { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> Reputation { get; set; }
        public byte[] ProfilePic { get; set; }
        public string UserType { get; set; }
        public Nullable<int> ApplyCount { get; set; }
        public byte[] CV { get; set; }
    
        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<AnswerComment> AnswerComments { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<AnswerVote> AnswerVotes { get; set; }
        public virtual ICollection<Badge> Badges { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Moderator> Moderators { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
