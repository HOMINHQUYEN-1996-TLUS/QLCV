using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV
{
  public class ListUser
  {
    private static ListUser instance;

    private List<User> listaccountUser;

    public static ListUser Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new ListUser();
        }
        return instance;
      }
      set => instance = value;
    }

    public List<User> ListaccountUser { get => listaccountUser; set => listaccountUser = value; }

    private ListUser()
    {
      listaccountUser = new List<User>();
/*      listaccountUser.Add(new User("admin", "123456","admin"));
      listaccountUser.Add(new User("quyen", "100996","employee"));*/
    }

  }
}
