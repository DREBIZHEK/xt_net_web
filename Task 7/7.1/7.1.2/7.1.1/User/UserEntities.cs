using Award.Entites;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Entities
{
    public class UserEntities
    {
        public List<AwardEntites> awards = new List<AwardEntites>();
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
