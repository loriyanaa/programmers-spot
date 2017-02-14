﻿using System.ComponentModel.DataAnnotations;
using ProgrammersSpot.Business.Common;
using ProgrammersSpot.Business.Models.Users;

namespace ProgrammersSpot.Business.Models.Reviews
{
    public class Review : IReview
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(Constants.MinReviewLength)]
        [MaxLength(Constants.MaxReviewLength)]
        public string Content { get; set; }

        public bool IsDeleted { get; set; }

        public string AuthorId { get; set; }

        public virtual User Author { get; set; }
    }
}
