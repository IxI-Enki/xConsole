using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xConsole
{
    class Element
  {
    #region constructor
    public Element()
    {
      ElementId = nextElementId++;
      this.ForegroundColor = new C.Color();
      this.BackgroundColor = new C.Color() { IsForeground = false };
    }
    #endregion constructor

    #region methods
    internal void Print()
    {
      Console.SetCursorPosition(this.WIdx, this.HIdx);
      Console.Write(
        this.BackgroundColor.AnsiEsc
        +
        this.ForegroundColor.AnsiEsc
        +
        this.PrintChar
        +
        C.Reset
        );
    }
    #endregion methods

    #region properties
    public bool IsInsideBox { get; set; }
    public int ElementId
    {
      get => _elementId;
      set => _elementId = value < 0 ? -1 : value;
    }
    public char PrintChar { get; set; }
    public int WIdx { get; set; }
    public int HIdx { get; set; }
    public C.Color ForegroundColor { get; set; }
    public C.Color BackgroundColor { get; set; }
    #endregion properties

    #region overrides
    public override string ToString()
      => (this.ElementId == -1 ? 'x' : this.PrintChar).ToString();
    #endregion overrides

    #region fields
    static int nextElementId = 0;
    private int _elementId;
    #endregion fields
  }
}