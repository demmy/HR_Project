using BotLibrary.Entities.Enum;
using BotLibrary.Entities.Setup;
using System;
using System.Collections.Generic;

namespace BotLibrary.Entities
{
    public class Vacancy : BaseEntity 
    {
        public string Name { get; set; }
        public Level Level {get; set;}
        public string Description { get; set; }
        public Department Department { get; set; }
        public virtual Location Location { get; set; }
        public User Responsible { get; set; }
        public List<Skill> RequiredSkills { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public List<Language> RequiredLanguages { get; set; }
        public TypeOfEmployment TypeOfEmployment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public VacancyStatus Status { get; set; }
        public List<CandidateStageInfo> CandidatesProgress { get; set; }
        public bool MasterVacancy { get; set; }
        public List<File> Files { get; set; }
        public int ChildredVacanciesCount {get; set;}
        public bool IsDeadlineAddedToCalendar { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
