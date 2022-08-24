﻿using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiFramewirk.Interfaces
{
    public interface IGroupService
    {
        Task<Group> AddStudentsToGroup(string groupId, List<string> students);
        Task<Group> AddGroup(Group group);
        Task<Group> DeleteGroup(string Id);
        Task<List<Group>> GetAllGroups();
        Task<Group> GetGroup(string Id);
        Task<Group> UpdateGroup(Group request);
    }
}
