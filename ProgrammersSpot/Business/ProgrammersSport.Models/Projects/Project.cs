﻿using ProgrammersSpot.Business.Common;
using ProgrammersSpot.Business.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace ProgrammersSpot.Business.Models.Projects
{
    public class Project : IProject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(Constants.MinProjectDescriptionLength)]
        [MaxLength(Constants.MaxProjectDescriptionLength)]
        public string Description { get; set; }

        [Required]
        public string LinkToProject { get; set; }

        public bool IsDeleted { get; set; }

        public string AuthorId { get; set; }

        public virtual RegularUser Author { get; set; }
    }
}
