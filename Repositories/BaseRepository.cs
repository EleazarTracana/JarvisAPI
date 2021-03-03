using NetJarvisAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetJarvisAPI.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly JarvisContext context;

        public BaseRepository(JarvisContext _context)
        {
            this.context = _context;
        }
    }
}
