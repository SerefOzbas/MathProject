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
    public class AnswerService : IAnswerService
    {
        IAnswerDal _answerDal;
        public AnswerService(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }
        public void Delete(Answer entity)
        {
            _answerDal.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Answer answer = _answerDal.Get(a => a.ID == entityID);
            Delete(answer);
        }

        public Answer Get(int entityID)
        {
            return _answerDal.Get(a => a.ID == entityID);
        }

        public ICollection<Answer> GetAll()
        {
            return _answerDal.GetAll().ToList();
        }

        public void Insert(Answer entity)
        {
            _answerDal.Add(entity);
        }

        public void Update(Answer entity)
        {
            _answerDal.Update(entity);
        }
    }
}
