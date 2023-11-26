using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV
{
  public class task
  {
    public int taskid { get; set; }
    public string? nametask { get; set; }
    public string? status { get; set; }
    public DateTime datecreate { get; set; }
    public string? assigned_user { get; set; }
    public bool received { get; set; }  


  }
}
