using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Skr3D.Application.ViewModels
{
    public class OrderViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Order Name is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }

        public List<OrderItemViewModel> Items { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string Street { get; set; }


    }
}
