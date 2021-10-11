﻿using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL.Interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventDTO>> GetEvents(DateTime dateTime);
    }
}