﻿using System;
using System.Collections.Generic;

namespace MVC4ServicesBook.Data.Model
{
    public class User
    {
        public virtual Guid UserId { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual byte[] Timestamp { get; set; }

        private readonly IList<Task> _tasks = new List<Task>();
        public virtual IList<Task> Tasks
        {
            get { return _tasks; }
        }
    }
}