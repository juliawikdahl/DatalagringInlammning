using Entityframework_Inlamning.Data;
using Entityframework_Inlamning.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_Inlamning.Services
{

    internal interface IErrandService
    {
        void CreateErrand(Errand errand);
        Errand GetId(int id);

        IEnumerable<Errand> GetAll();

        string ChangeState(State state);
        internal class ErrandService : IErrandService

        {
            private readonly SqlContext _context = new SqlContext();

            public void CreateErrand(Errand errand)
            {
                var _Errands = _context.Customers.Where(x => x.Id == errand.Id).FirstOrDefault();
                if (_Errands == null)
                {
                    _context.Errands.Add(errand);
                    _context.SaveChanges();
                }
            }

            public IEnumerable<Errand> GetAll()
            {
                return _context.Errands; 
            }

            public Errand GetId(int id)
            {
                return _context.Errands.Find(id);
            }

            public string ChangeState(State state)
            {
                switch (state)
                {
                    case State.NotRunning:
                        return "not running";


                    case State.UnderProcess:
                        return "under process";

                    case State.Stopped:
                        return "stopped";

                }
                return "";


            }

        }

    }


}