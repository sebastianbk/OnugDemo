using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnugDemo.Models
{
    public interface IBlogRepo
    {
        BlogPost GetPost();
    }
}
