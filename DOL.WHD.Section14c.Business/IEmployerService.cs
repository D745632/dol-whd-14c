﻿using DOL.WHD.Section14c.Domain.Models;
using DOL.WHD.Section14c.Domain.Models.Submission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOL.WHD.Section14c.Business
{
    public interface IEmployerService
    {
        Employer FindExistingEmployer(Employer employer);
        bool ValidateEmployer(Employer employer);
    }
}
