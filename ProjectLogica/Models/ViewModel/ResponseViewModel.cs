using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCore.Logica.Models.ViewModel
{
    public class ResponseViewModel
    {

        public bool IsSuccessful { get; set; }
            public List<string> Errors { get; set; }

    }
}
