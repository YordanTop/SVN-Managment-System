using DataBaseLayer.Models;
using ServiceLayer.Repositories;
using System;
using System.Collections.Generic;

namespace ServiceLayer.Services.CRUD_Services
{
    public class LineService:IService
    {
        private LineRepository _repository;

        public LineService(LineRepository repository)
        {
            this._repository = repository;
        }

        public void AddLine(Line line)
        {
            _repository.Add(line);
        }
        public void RemoveLine(Line line)
        {
            _repository.Delete(line);
        }

        public IEnumerable<Line> GetAll()
        {
            return _repository.GetAll();
        }

        public Line GetLineById(int id)
        {
            return _repository.GetById(id).Result;
        }

        public void UpdateLine(Line oldInfo, Line newInfo)
        {
            _repository.Update(oldInfo, newInfo);
        }

        public bool CheckStatus(Func<bool> status)
        {
            
                if (status.Invoke() == true)
                {
                    return true;
                }
            return false;
        }
        public void ChangeStatus(int index, bool status)
        {
            Line oldLine = GetLineById(index);

            Line newEntity = new Line()
            {
                Id = oldLine.Id,
                Name = oldLine.Name,
                AllStateStatus = status,
                Pctoline = oldLine.Pctoline,
            };

            _repository.Update(oldLine, newEntity);
            
        }

        public List<Line> SearchResult(string input)
        {
            string collectInputResult = String.Empty;
            List<Line> result = new List<Line>();
            foreach(var line in _repository.GetAll())
            {
                if (line.Name.Contains(input))
                {
                    result.Add(line);
                }
            }
            return result;
        }

        public bool SearchForLine(string name)
        {
            foreach (var line in GetAll())
            {
                if (line.Name.Equals(name)) { return true; }
            }
            return false;
        }
    }
}
