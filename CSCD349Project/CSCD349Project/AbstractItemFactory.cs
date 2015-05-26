using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
  public abstract class AbstractItemFactory
  {
    public AbstractItemFactory(){}
    public abstract GameItem GetRandomItem();
  }
}
