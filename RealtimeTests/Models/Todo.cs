﻿using System;
using Postgrest.Attributes;
using Postgrest.Models;

namespace RealtimeTests.Models
{
    [Table("Todos")]
    public class Todo : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("details")]
        public string Details { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }
    }
}
