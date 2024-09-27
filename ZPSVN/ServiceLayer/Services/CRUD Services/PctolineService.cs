using DataBaseLayer.Models;
using DataRetrieving.SVN;
using ServiceLayer.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Services.CRUD_Services
{
    public class PctolineService: IService
    {
        private PctolineRepository _repository;
        public PctolineService(PctolineRepository repository)
        {
            this._repository = repository;
        }

        public void AddComputer(Pctoline computer)
        {
            _repository.Add(computer);
        }
        public void RemoveComputer(Pctoline computer)
        {
            _repository.Delete(computer);
        }

        public IEnumerable<Pctoline> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Pctoline> GetGroup(Line line)
        {
            var computerGroup = _repository.GetAll().Where(computer => computer.LineId == line.Id).ToList();

            return computerGroup;
        }

        public Pctoline GetUserById(int id)
        {
            return _repository.GetById(id).Result;
        }

        public void UpdateComputer(Pctoline oldInfo, Pctoline newInfo)
        {
            _repository.Update(oldInfo, newInfo);
        }

        public string RetriveModifications(int index)
        {
            List<Pctoline> list = _repository.GetAll();
            if (list == null)
                return null;


            for (int i = 0; i < list.Count; i++)
            {
                if (index == list[i].Id)
                {
                    SvnModificationData modData = new SvnModificationData(list[i].Repository, list[i].PcDirectory);
                    return modData.ModificationInfo;
                }
            }

            return null;
        }

        public bool CheckStatusById(int index)
        {
            var result = RetriveModifications(index);
            if (!result.Equals("") || result == null)
            {
                return false;
            }
            return true;
        }

        public bool CheckStatus(List<Pctoline> line)
        {
            foreach(var computer in line)
            {
                if (CheckStatusById(computer.Id) == false)
                {
                    return false;
                }
            }
            return true;
        }

        public bool SearchForComputer(Line line,string name)
        {
            foreach(var computer in GetGroup(line))
            {
                if(computer.Name.Equals(name)) {  return true; }
            }
            return false;
        }
    }
}
