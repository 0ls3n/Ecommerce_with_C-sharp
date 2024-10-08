﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Project.Models.Domain_Classes
{
    public abstract class Model // This class ensures that all models that have to go to the database have an Id
    {
        [Key]
        public int Id { get; set; }
    }
}
