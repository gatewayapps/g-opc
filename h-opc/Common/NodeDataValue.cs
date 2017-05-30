using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hylasoft.Opc.Common
{
  public class NodeDataValue<T>
  {
    public Node Node { get; set; }
    public DateTime SourceTimestamp { get; set; }
    public DateTime ServerTimestamp { get; set; }
    public T Value { get; set; }
    public NodeDataQuality Quality { get; set; }
  }
}
