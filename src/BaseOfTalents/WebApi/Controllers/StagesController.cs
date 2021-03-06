﻿using Data.EFData.Design;
using Domain.Entities.Setup;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Controllers
{
    public class StagesController : BoTController<Stage, Stage>
    {
        public StagesController(IRepositoryFacade facade) : base(facade)
        {
            _currentRepo = _repoFacade.StageRepository;
        }
    }
}