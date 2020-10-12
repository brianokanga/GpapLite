using System;
using System.Collections.Generic;
using System.Text;
using GpapLite.Data.Data;
using GpapLite.Data.Repository.IRepository;

namespace GpapLite.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GpapDbContext _db;

        public UnitOfWork(GpapDbContext db)
        {
            _db = db;
            //County = new CountyRepository(_db);
            //SubCounty = new SubCountyRepository(_db);
            //Location = new LocationRepository(_db);
            //Specie = new SpecieRepository(_db);
            //SpecieInformation = new SpecieInformationRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        //public ICountyRepository County { get; private set; }
        //public ISubCountyRepository SubCounty { get; private set; }
        //public ILocationRepository Location { get; private set; }
        //public ISpecieRepository Specie { get; private set; }
        //public ISpecieInformationRepository SpecieInformation { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
