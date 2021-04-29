using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }

        public ICollection<UserLike> LikedByUsers { get; set; }
        public ICollection<UserLike> LikedUsers { get; set; }
        
        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessagesReceived { get; set; }

        public ICollection<AppUserRole> UserRoles { get; set; }

        // public AppUser(int id, string userName, DateTime dateOfBirth, string knownAs, DateTime created, DateTime lastActive, string gender, string introduction, string lookingFor, string interests, string city, string country) 
        // {
        //     this.Id = id;
        //     this.UserName = userName;
        //     this.DateOfBirth = dateOfBirth;
        //     this.KnownAs = knownAs;
        //     this.Created = created;
        //     this.LastActive = lastActive;
        //     this.Gender = gender;
        //     this.Introduction = introduction;
        //     this.LookingFor = lookingFor;
        //     this.Interests = interests;
        //     this.City = city;
        //     this.Country = country;
   
        // }

    }
}