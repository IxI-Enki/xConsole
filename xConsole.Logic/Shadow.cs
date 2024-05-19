using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Element.Logic
{
  public class Shadow
  {
    #region constructors 
    public Shadow()
    {
      South = false;
      North = false;
      East = false;
      West = false;
    }
    #endregion constructors

    #region properties
    public bool South { get; set; }
    public bool West { get; set; }
    public bool East { get; set; }
    public bool North { get; set; }
    #endregion properties

    #region overrides
    public override string ToString()
    {
      string result = "";
      char[] orientations = ['↑', '↗', '→', '↘', '↓', '↙', '←', '↖'];  // ↑↗→↘↓↙←↖

      if (North && !East && !South && !West) result = orientations[0].ToString();
      if (North && East && !South && !West) result = orientations[1].ToString();
      if (!North && East && !South && !West) result = orientations[2].ToString();
      if (!North && East && South && !West) result = orientations[3].ToString();
      if (!North && !East && South && !West) result = orientations[4].ToString();
      if (!North && !East && South && West) result = orientations[5].ToString();
      if (!North && !East && !South && West) result = orientations[6].ToString();
      if (North && !East && !South && West) result = orientations[7].ToString();

      return result;
    }
    #endregion overrides
  }
}