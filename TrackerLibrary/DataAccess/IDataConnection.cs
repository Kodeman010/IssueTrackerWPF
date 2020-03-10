﻿using System.Collections.Generic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAcess
{
    public interface IDataConnection
    {
        IssueModel CreateIssue(IssueModel model);
        PersonModel CreatePerson(PersonModel model, string password);
        List<SeverityModel> GetSeverities();
        List<PersonModel> GetPeople();
        List<IssueModel> GetIssues();
    }
}