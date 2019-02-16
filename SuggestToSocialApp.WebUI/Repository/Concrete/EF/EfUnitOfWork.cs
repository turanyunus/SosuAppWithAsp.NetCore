using SuggestToSocialApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Repository.Concrete.EF
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly SuSoContext suSoContext;
        public EfUnitOfWork(SuSoContext _suSoContext)
        {
            suSoContext = _suSoContext ?? throw new ArgumentNullException("suSoContext can not be null");
        }
        private IPostRepository _postRepository;
        private ICategoryRepository _categoryRepository;
        private ISubjectRepository _subjectRepository;

        public IPostRepository postRepository
        {
            get
            {
                return _postRepository ?? (_postRepository = new EfPostRepository(suSoContext));
            }
        }
        public ICategoryRepository categoryRepository
        {
            get
            {
                return _categoryRepository ?? (_categoryRepository = new EfCategoryRepository(suSoContext));
            }
        }

        public ISubjectRepository subjectRepository
        {
            get
            {
                return _subjectRepository ?? (_subjectRepository = new EfSubjectRepository(suSoContext));
            }
        }
        public int SaveChanges()
        {
            try
            {
                return suSoContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Dispose()
        {
            suSoContext.Dispose();
        }

    }
}
