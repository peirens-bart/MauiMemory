using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMemory.Services
{
    public class CounterService: ICounterService
    {
        private int _count = 0;

        public int Count => _count;

        public void Add()
        {
            _count++;
        }

        public bool HasMaxReached()
        {
            return _count == 10;
        }

        public void Reset()
        {
            _count = 0;
        }
    }
}
