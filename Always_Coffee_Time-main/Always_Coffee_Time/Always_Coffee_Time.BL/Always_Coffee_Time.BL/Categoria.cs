using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Always_Coffee_Time.BL
{ 
 public class Categoria
{
    public int Id { get; set; }

    //[Required(ErrorMessage = "Ingrese la categoria")]
    public string Descripcion { get; set; }
}
}