using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TouristAppV3.Model
{
    [DataContract]
    class CommentModelHotel
    {
        [DataMember]
        public string writeComment { get; set; }
    }
}
