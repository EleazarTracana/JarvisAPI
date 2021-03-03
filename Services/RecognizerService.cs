using NetJarvisAPI.Models;
using NetJarvisAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetJarvisAPI.Services
{
    public class RecognizerService : IRecognizerService
    {
        private readonly IRecognizerRepository repository;
        public RecognizerService(RecognizerRepository _repository)
        {
            repository = _repository;
        }
        public Task<IEnumerable<RecognizedHuman>> GetHumans()
        {
            return repository.Humans();
        }
    }
}
