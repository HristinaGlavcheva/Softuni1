﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VaporStore.Data.Models
{
    public class GameTag
    {
        [Key]
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }

        public virtual Game Game { get; set; }

        [Key]
        [ForeignKey(nameof(Tag))]
        public int TagId { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
