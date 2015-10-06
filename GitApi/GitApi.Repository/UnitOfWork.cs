using GitApi.Domain.Entities;
using GitApi.Repository;
using System;

namespace GitApi.Data
{

    public class UnitOfWork:IDisposable
    {
        private GitApiContext context = new GitApiContext();
        private IGenericRepository<Favoritos> favoritosRepository;

        public IGenericRepository<Favoritos> FavoritosRepository
        {
            get
            {
                if (this.favoritosRepository == null)
                    this.favoritosRepository = new GenericRepository<Favoritos>(context);

                return this.favoritosRepository;
            }
        }
        public void Save()
        {
            this.context.SaveChanges();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
