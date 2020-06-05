using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectCore.Logica.Models.ViewModel
{
    public class TasksIndexViewModel
    {


        [Display(Name = "Id")]
        public int? Id { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Details")]
        public string Details { get; set; }

        [Display(Name = "ExpirationDate")]
        public DateTime? ExpirationDate { get; set; }

        [Display(Name = "IsCompleted")]
        public bool? IsCompleted { get; set; }

        [Display(Name = "Effort")]
        public int? Effort { get; set; }

        [Display(Name = "RemainingWork")]
        public int? RemainingWork { get; set; }


        [Display(Name = "StateName")]
        public string StateName { get; set; }

        [Display(Name = "ActivityName")]
        public string ActivityName { get; set; }

        [Display(Name = "PriorityName")]
        public string PriorityName { get; set; }


    }

    public class TasksGetTasksCalendarViewModel
    {
        [Display(Name = "Id")]
        public int? Id { get; set; }

        [Display(Name = "Start")]
        public string Start { get; set; }

        [Display(Name = "End")]
        public string End { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        [Display(Name = "Allday")]
        public bool Allday { get; set; }

        [Display(Name = "TextColor")]
        public string TextColor { get; set; }
    }


}
