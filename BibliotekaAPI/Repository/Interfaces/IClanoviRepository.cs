﻿using BibliotekaAPI.Models;
using System;

namespace BibliotekaAPI.Repository.Interfaces
{
    public interface IClanoviRepository
    {
        void Add(Clan clan);
        IQueryable<Clan> GetAll();
        Clan GetById(int id);
        void Update(Clan clan);
        void Delete(Clan clan);
    }
}
