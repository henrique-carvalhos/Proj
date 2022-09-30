using Extranet.Application.Services.Interfaces;
using Extranet.Application.ViewModels;
using Extranet.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extranet.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly ExtranetDbContext _dbContext;
        public SkillService(ExtranetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SkillViewModel> GetAll()
        {
            var skills = _dbContext.Skills;

            var skillsViewModel = skills
                .Select(s => new SkillViewModel(s.Id, s.Description))
                .ToList();

            return skillsViewModel;
        }
    }
}
