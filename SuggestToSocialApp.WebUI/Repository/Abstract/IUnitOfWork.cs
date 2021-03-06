﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository postRepository { get; }
        ICategoryRepository categoryRepository { get; }
        ISubjectRepository subjectRepository { get; }
        int SaveChanges();
    }
}
