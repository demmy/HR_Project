﻿using Domain.Entities.Enum;
using Domain.Entities.Setup;

namespace Domain.Entities
{
    public class LanguageSkill : BaseEntity
    {
        public virtual Language Language { get; set; }
        public LanguageLevel LanguageLevel { get; set; }
    }
}
