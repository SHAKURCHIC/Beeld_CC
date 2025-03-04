using System.Collections.Generic;

namespace Beeld_c
{
    public class Service
    {
        public string Name { get; set; }
        public string Description{ get; set; }
        public bool EstimatedTime{ get; set; }
        public bool EstimatedPrice{ get; set; }
        
        public int ViewCount { get; set; }

        public List<Review> Reviews { get; set; }
        
    }
}