
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string? Mail { get; set; }
        public string? WebSite { get; set; }
        public string? Title { get; set; }
        public bool? Favorites { get; set; }
        public bool? BlockedNumber { get; set; }

    }
}
