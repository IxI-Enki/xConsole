#region header ( class: Box - general information )
// - This region stores info about the author and the program( version, features,.. )
/*
 *    ╔══════════════════════╦═══════════════════════════════════════════════════════════════════╗
 *    ║   HTBLA - Leonding   ║ ┏━━━━━━━━━━━━━━━┯━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ║█
 *    ╠═════════╤════════════╣ ┃▷ DESCRIPTION  │                                               ┃ ║█
 *    ║  Name   │  Jan Ritt  ║ ┃               │                                               ┃ ║█
 *    ╟─────────┼────────────╢ ┃               │                                               ┃ ║█
 *    ║  Class  │  4 ACIFT   ║ ┠───────────────┼───────────────────────────────────────────────┨ ║█
 *    ╟─────────┼────────────╢ ┃▷ SYNTAX       │ Box.                                          ┃ ║█
 *    ║  Year   │  2024      ║ ┃ ►             │                                               ┃ ║█
 *    ╟─────────┴────────────╢ ┃               │                                               ┃ ║█
 *    ║  Last edit:  5.2024  ║ ┃               │                                               ┃ ║█
 *    ╚══════════════════════╣ ┃  ╌╌╌╌╌╌╌╌╌╌╌╌╌┼╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌ ┃ ║█
 *      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀║ ┃ ► VERSION:    │ 1.2                                           ┃ ║█
 *                           ║ ┗━━━━━━━━━━━━━━━┷━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛ ║█
 *    ┏━━━━━━━━━━━━━━━━━┓    ╚═══════════════════════════════════════════════════════════════════╝█
 *    ┃   Development   ┃      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
 *    ┣━━━━━━━━━━━━━━━━━╇━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
 *    ┃ ▷ KNOWN ISSUES  │                                                                        ┃█
 *    ┠─────────────────┼────────────────────────────────────────────────────────────────────────┨█
 *    ┃ ▷ NEXT UP       │                                                                        ┃█
 *    ┃    ► _here_     │                                                                        ┃█
 *    ┃  ╌╌╌╌╌╌╌╌╌╌╌╌╌  │ ╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌  ┃█
 *    ┃    ► _here_     │                                                                        ┃█
 *    ┗━━━━━━━━━━━━━━━━━┷━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛█
 *      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
*/
#endregion
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace xConsole
{
  class Box
  {
    static int nextBoxID = 0;

    #region fields
    private C.Color _boxLineColor = new C.Color { RGBValues = [0, 200, 55] };
    private C.Color _boxLineBackgroundColor;
    private C.Color _boxBackgroundColor;
    private Size _defaultBoxSize;
    #endregion fields

    #region constructors
 
    public Box()
    {
      BoxID = nextBoxID++;
      NoShadow = false;
      NoInternalShadow = false;

      BoxSize
        = DefaultBoxSize;

      StartPoint
        = new Point(1, 1);
      BoxChars
        = new BoxChar();
          BoxLineColor
            = DefaultBoxLineColor;
      BoxLineBackgroundColor
        = DefaultBoxLineBackgroundColor;
      BoxBackgroundColor
        = DefaultBoxBackgroundColor;
      BoxName
        = BoxID.ToString();
      BoxGradient
        = DefaultBoxGradient;
    }
    #endregion constructors

    #region properties
    public C.Gradient BoxGradient { get; set; }
    public bool NoShadow { get; set; }
    public bool NoInternalShadow { get; set; }
    public string BoxName { get; set; }
    public Point CenterPoint
      => new Point(BoxSize.Width / 2, BoxSize.Height / 2);
    public Size BoxSize { get; set; }
    public Size DefaultBoxSize
    { get => _defaultBoxSize = new Size(this.BoxSize.Width, this.BoxSize.Height); set => _defaultBoxSize = value; }
    public Point StartPoint { get; set; }
    public Point EndPoint
      => StartPoint + BoxSize;
    public C.Color BoxLineColor
    { get; set; }
    public C.Color BoxLineBackgroundColor { get; set; }
    public C.Color BoxBackgroundColor { get; set; }
    public int BoxID { get; set; }
    public BoxChar BoxChars { get; set; }

    #region DEFAULTCOLORS
    private C.Color DefaultBoxLineColor
      => new C.Color { RGBValues = [0, 200, 55] };
    private C.Color DefaultBoxLineBackgroundColor
     => new C.Color { IsForeground = false, RGBValues = [16, 83, 45] };
    private C.Color DefaultBoxBackgroundColor
      => new C.Color { IsForeground = false, RGBValues = [22,27,34] };
    private C.Gradient DefaultBoxGradient
      => new C.Gradient
      (
        new C.Color { RGBValues = [12, 95, 48] },
        new C.Color { RGBValues = [0, 0, 0] },
        BoxSize.Width + BoxSize.Height + 1
      );
    #endregion DEFAULTCOLORS

    #endregion properties

    public class BoxChar
    {
      #region properties
      public char[] CharSet;
      #endregion properties

      #region fields
      public static char[] DefaultCharSet
                       = ['╵', '└', '│', '┘', '╶', '┌', '─', '╷', '┐', '╴'],
                           RoundedCharSet
                       = ['╵', '╰', '│', '╯', '╶', '╭', '─', '╷', '╮', '╴'],
                           ThickCharSet
                       = ['╹', '┗', '┃', '┛', '╺', '┏', '━', '╻', '┓', '╸',],
                           DoubleCharSet
                       = ['⁉', '╚', '║', '╝', '⁉', '╔', '═', '⁉', '╗', '⁉',]
                           ;

      #endregion fields

      #region constructors
      public BoxChar(char[] charSet = null)
          =>
            CharSet
              = charSet == null ? ThickCharSet : charSet;
      // = DefaultCharSet;
      #endregion constructors
    }
  }
}