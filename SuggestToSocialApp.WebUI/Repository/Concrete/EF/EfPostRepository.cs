using Microsoft.EntityFrameworkCore;
using SuggestToSocialApp.WebUI.Entity;
using SuggestToSocialApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Repository.Concrete.EF
{
    public class EfPostRepository : EfGenericRepository<Post>,IPostRepository
    {
        public EfPostRepository(SuSoContext context) : base(context)
        {

        }
        public SuSoContext SuSoContext
        {
            get { return context as SuSoContext; }
        }
    }
}
