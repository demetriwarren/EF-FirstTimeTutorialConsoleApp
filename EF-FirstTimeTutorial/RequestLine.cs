using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FirstTimeTutorial;

public class RequestLine
{
    public int Id { get; set; }
    public int Quantity { get; set; }

    public int RequestId { get; set; }      //references the table that the FK pulls from. 
    public virtual Request? Request { get; set; }

    public int ProductId { get; set; }
    public virtual Product? Product { get; set; }
}  