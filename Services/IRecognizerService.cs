using NetJarvisAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetJarvisAPI.Services
{
    public interface IRecognizerService
    {
        Task<IEnumerable<RecognizedHuman>> GetHumans();
    }
}
