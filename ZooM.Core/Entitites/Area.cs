﻿using System.Collections.Generic;
using System.Linq;
using ZooM.Core.Exceptions;

namespace ZooM.Core.Entitites
{
    public class Area
    {
        public int AreaNo { get; }
        public IEnumerable<int> Cages => _cages;
        private readonly List<int> _cages;

        public Area(int no, IEnumerable<int> cages)
        {
            AreaNo = no;
            _cages = cages?.ToList() ?? new List<int>();
        }

        public void AddCage(int cageNo)
        {
            if(_cages.Contains(cageNo)) throw new DomainException("Klatka z takim numerem już istnieje");
            _cages.Add(cageNo);
        }

        public void RemoveCage(int cageNo)
        {
            if (!_cages.Contains(cageNo)) throw new DomainException("Klatka z takim numerem nie istnieje");
            _cages.Add(cageNo);
        }
    }
}