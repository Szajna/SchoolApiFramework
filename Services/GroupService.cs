﻿using SchoolApiFramewirk.Data;
using SchoolApiFramewirk.Interfaces;
using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SchoolApiFramewirk.Services
{
    public class GroupService : IGroupService
    {
        private readonly DataContext _context;

        public GroupService(DataContext context)
        {
            _context = context;
        }

        public async Task<Group> AddGroup(Group group)
        {
            _context.Groups.Add(group);
            await _context.SaveChangesAsync();
            return group;
        }

        public async Task<Group> AddStudentsToGroup(string groupId, List<string> students)
        {
            var groupRequest = await _context.Groups.FindAsync(groupId);

            foreach (var studentId in students)
            {
                foreach (var student in _context.Students)
                {
                    if (student.Id == studentId)
                    {
                        groupRequest.Students.Add(student);
                    }
                }
            }

            await _context.SaveChangesAsync();

            return groupRequest;
        }

        public async Task<Group> DeleteGroup(string Id)
        {
            var DbGroup = await _context.Groups.FindAsync(Id);

            _context.Groups.Remove(DbGroup);

            await _context.SaveChangesAsync();
            return DbGroup;
        }

        public async Task<List<Group>> GetAllGroups()
        {
            return await _context.Groups.ToListAsync();
        }

        public async Task<Group> GetGroup(string Id)
        {
            var group = await _context.Groups.FindAsync(Id);

            var students = await _context.Students.Where(x => x.GroupId == group.Id).ToListAsync();
            group.Students = students;

            return group;
        }

        public async Task<Group> UpdateGroup(Group request)
        {
            var DbGroup = await _context.Groups.FindAsync(request.Id);

            DbGroup.Name = request.Name;
            DbGroup.Year = request.Year;
            DbGroup.Supervisor = request.Supervisor;

            await _context.SaveChangesAsync();
            return request;
        }
    }
}