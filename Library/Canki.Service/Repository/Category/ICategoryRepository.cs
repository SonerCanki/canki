﻿using Canki.Core.Repository;
using EF = Canki.Model.Entities;

namespace Canki.Service.Repository.Category
{
    public interface ICategoryRepository : IRepository<EF.Category>
    {
    }
}
