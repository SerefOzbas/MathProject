using Bll.Abstract;
using Dal.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Concrete
{
    public class QuestionService : IQuestionService
    {
        IQuestionDal _questionDal;
        public QuestionService(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }
        public void Delete(Question entity)
        {
            _questionDal.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Question question = _questionDal.Get(a => a.ID == entityID);
            Delete(question);
        }

        public Question Get(int entityID)
        {
            return _questionDal.Get(a => a.ID == entityID);
        }

        public ICollection<Question> GetAll()
        {
            return _questionDal.GetAll().ToList();
        }

        public void Insert(Question entity)
        {
            _questionDal.Add(entity);
        }

        public void Update(Question entity)
        {
            _questionDal.Update(entity);
        }
    }
}
