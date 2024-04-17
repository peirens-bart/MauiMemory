using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMemory.Services
{
    public interface ICounterService
    {
        int Count { get; }
        void Add();
        void Reset();
        bool HasMaxReached();
    }
}
