using System;
using System.Collections.Generic;
using Domain.Entities.Enum;
using Domain.Entities.Setup;

namespace Data.Migrations.Seed_Datas
{
    static class EventTypeSetup
    {
        public static List<EventType> EventTypes = new List<EventType>
        {
            new EventType()
            {
                Id = 1,
                Title = "",
                State = EntityState.Active,
                ImagePath = "",
                EditTime = DateTime.Now
            },
            new EventType()
            {
                Id = 2,
                Title = "",
                State = EntityState.Active,
                ImagePath = "",
                EditTime = DateTime.Now
            },
            new EventType()
            {
                Id = 3,
                Title = "",
                State = EntityState.Active,
                ImagePath = "",
                EditTime = DateTime.Now
            },
            new EventType()
            {
                Id = 4,
                Title = "",
                State = EntityState.Active,
                ImagePath = "",
                EditTime = DateTime.Now
            },
            new EventType()
            {
                Id = 5,
                Title = "",
                State = EntityState.Active,
                ImagePath = "",
                EditTime = DateTime.Now
            },
        };
    }
}
