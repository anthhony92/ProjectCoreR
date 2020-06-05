using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectCore.Logica.Models.BindingModel
{


    public class ProjectsCreateBindingModel
    {

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Title")]
        public String Title { get; set; }

        [Required(ErrorMessage = "The field Details is required")]
        [Display(Name = "Details")]
        public String Details { get; set; }

        [Required(ErrorMessage = "The field ExpectedCompletionDate is required")]
        [Display(Name = "ExpectedCompletionDate")]
        public DateTime? ExpectedCompletionDate { get; set; }



    }

    public class ProjectsEditBindingModel
    {
        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Title")]
        public String Title { get; set; }

        [Required(ErrorMessage = "The field Details is required")]
        [Display(Name = "Details")]
        public String Details { get; set; }

        [Required(ErrorMessage = "The field ExpectedCompletionDate is required")]
        [Display(Name = "ExpectedCompletionDate")]
        public DateTime? ExpectedCompletionDate { get; set; }



    }


}
