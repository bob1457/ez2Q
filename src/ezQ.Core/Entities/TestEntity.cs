using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Interfaces;

namespace ezQ.Core.Entities
{
    public class TestEntity : IBaseEntity
    {
        private readonly IRepository<TestEntity> _repository;
        
        public long Id { get; set; }

        public string PropertyOne { get; set; }

        public string PropertyTwo { get; set; }

        public string ActionOne()
        {
            //Do something
            return "Action 1 done";
        }

        public TestEntity()
        {
            
        }

        public TestEntity(IRepository<TestEntity> repository )
        {
            this._repository = repository;
        }


        public string ActionTwo()
        {
            //Do something;
            return "Action 2 done";
        }

        public TestEntity Create()
        {
            var entity = new TestEntity();

            //Do something
            _repository.Add(entity);

            return entity;
        }

    }
}
