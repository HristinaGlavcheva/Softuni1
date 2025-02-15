﻿using System;

namespace Git.ViewModels.Repositories
{
    public class RepositoryViewModel
    {
        public string Name { get; set; }

        public string Owner { get; set; }

        public DateTime Created { get; set; }

        public int Commits { get; set; }
    }
}
