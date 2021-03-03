using Microsoft.EntityFrameworkCore;
using NetJarvisAPI.Database;
using NetJarvisAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetJarvisAPI.Repositories
{
    public class RecognizerRepository : BaseRepository, IRecognizerRepository 
    {
         public RecognizerRepository(JarvisContext _context) :base(_context)
         {
         }
         // Get all humans in the database
         public async Task<IEnumerable<RecognizedHuman>> Humans()
         {
            return await context.RecognizedHumans.ToListAsync();
         }
    }
}
