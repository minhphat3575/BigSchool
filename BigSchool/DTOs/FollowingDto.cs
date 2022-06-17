using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.DTOs
{
    public class FollowingDto
    {
        private readonly ApplicationDbContext _dbContext;
        public string FolloweeId { get; set; }
    }
}