using HotelListingApi.Data;
using HotelListingApi.Repo.IGenericRepository;
using HotelListingApi.Repo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApi.Repo.Implementation
{
    public class Unitofwork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Country> _Countries;
        private IGenericRepository<Hotel>  _Hotels;
        public Unitofwork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Country> Countries => _Countries ??= new GenericRepository <Country>(_context);

        public IGenericRepository<Hotel> Hotels => _Hotels ??= new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        } 
    }
}
