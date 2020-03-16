using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Skr3D.Application.ViewModels
{
    public class OrderItemViewModel
    {

        [Required(ErrorMessage = "The Item Name is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }



    }
}
