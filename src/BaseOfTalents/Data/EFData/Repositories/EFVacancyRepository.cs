﻿using Domain.Entities;
using Domain.Entities.Enum;
using Domain.Entities.Setup;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Data.EFData.Repositories
{
    public class EFVacancyRepository : EFBaseEntityRepository<Vacancy>, IVacancyRepository
    {
       
    }
}
