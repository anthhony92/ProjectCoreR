﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectCore.Logica.BL
{
   public class Activities
    {


        public List<Models.BD.Activities> GetActivities()
        {
            DAL.Models.ProjectCoreContext _context = new DAL.Models.ProjectCoreContext();

            //Linq
            var listActivities = (from _activities in _context.Activities                        
                               where _activities.Active == true
                               select new Models.BD.Activities
                               {

                                   Id = _activities.Id,
                                   Name = _activities.Name,
                                   Active = _activities.Active


                               }).ToList();


            return listActivities;

        }

    }
}
