using NetJarvisAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetJarvisAPI.Repositories
{
    public interface IRecognizerRepository
    {
        Task<IEnumerable<RecognizedHuman>> Humans();
    }
}
