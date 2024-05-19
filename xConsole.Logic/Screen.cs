#region header ( class: Screen - general information )
// - This region stores info about the author and the program( version, features,.. )
/*
 *    ╔══════════════════════╦═══════════════════════════════════════════════════════════════════╗
 *    ║   HTBLA - Leonding   ║ ┏━━━━━━━━━━━━━━━┯━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ║█
 *    ╠═════════╤════════════╣ ┃▷ DESCRIPTION  │ Used to Save and Print ScreenElements         ┃ ║█
 *    ║  Name   │  Jan Ritt  ║ ┃               │                                               ┃ ║█
 *    ╟─────────┼────────────╢ ┃               │                                               ┃ ║█
 *    ║  Class  │  4 ACIFT   ║ ┠───────────────┼───────────────────────────────────────────────┨ ║█
 *    ╟─────────┼────────────╢ ┃▷ SYNTAX       │ Screen([int width],[int height])              ┃ ║█
 *    ║  Year   │  2024      ║ ┃ ► .Print()    │                                               ┃ ║█
 *    ╟─────────┴────────────╢ ┃ ► .AddBoxToScreen()                                           ┃ ║█
 *    ║  Last edit:  5.2024  ║ ┃ ► .Window()   │                                               ┃ ║█
 *    ╚══════════════════════╣ ┃  ╌╌╌╌╌╌╌╌╌╌╌╌╌┼╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌ ┃ ║█
 *      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀║ ┃ ► VERSION:    │ 1.0                                           ┃ ║█
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
  class Screen
  {
    #region constructors
    public Screen(int width, int height)
    {
      this.ScreenWidth = width;
      this.ScreenHeight = height;
      InitiateScreen(ScreenWidth, ScreenHeight);
    }
    public Screen()
      =>
        InitiateScreen(ScreenWidth, ScreenHeight);
    #endregion constructors

    #region methods
    private void InitiateDebugScreen()
    {
      // GRADIENT OF START TEXTFIELD:
      C.Color red = new C.Color { RGBValues = [255, 100, 0] };
      C.Color green = new C.Color { RGBValues = [120, 255, 0] };
      int length = 8;
      C.Gradient gradientStartDebug
        = new C.Gradient(red, green, length);
      this.DebugTextStartGradient = gradientStartDebug;

      // GRADIENT OF END TEXTFIELD:
      C.Color blue = new C.Color { RGBValues = [0, 0, 220] };
      green = new C.Color { RGBValues = [0, 160, 60] };
      C.Gradient gradientEndDebug
         = new C.Gradient(blue, green, length);
      this.DebugTextEndGradient = gradientEndDebug;

      // GRADIENT OF COORDS TEXTFIELD:
      C.Color blue2 = new C.Color { RGBValues = [0, 100, 100] };
      length = 2;
      this.DebugTextXGradient
        = new C.Gradient(green, blue2, length);
      this.DebugTextYGradient
        = new C.Gradient(blue2, green, length);

      // GRADIENT OF SUN TEXTFIELD:
      C.Color Shadow0 = new C.Color { RGBValues = [255, 255, 0] };
      C.Color Shadow1 = new C.Color { RGBValues = [200, 188, 0] };
      this.DebugTextShadowOrientationGradient
        = new C.Gradient(Shadow0, Shadow1, length);
    }
    private void InitiateScreen(int screenWidth, int screenHeight)
    {
      ScreenElements = new Element[ScreenWidth, ScreenHeight];

      this.ShadowOrientation = new Shadow();
      this.ShadowColor = new C.Color { RGBValues = [182, 182, 182] };

      InitiateDebugScreen();

      for (int h = 0; h < ScreenHeight; h++)
        for (int w = 0; w < ScreenWidth; w++)
        {
          Element e = new Element();
          ScreenElements[w, h] = e;
          e.WIdx = w;
          e.HIdx = h;
          e.PrintChar = ' ';
          e.ForegroundColor
            = new C.Color { RGBValues = [0, 0, 0] };
          e.BackgroundColor
            = new C.Color { RGBValues = [215, 215, 215], IsForeground = false };

          if (w == CenterPoint.Y && h == CenterPoint.X)
          {
            e.PrintChar
              = '╳'; //
            e.ForegroundColor
              = new C.Color { RGBValues = [0, 120, 0] };
          }
        }
      ScreenBoxes = new Box[255];
    }
    private string PrintElements(Element element)
      => new string(
        element.BackgroundColor.AnsiEsc
        +
        element.ForegroundColor.AnsiEsc
        +
        element.PrintChar
        +
        C.Reset);
    private void Print(TextField textField)
      =>
        textField.Print(this);
    // - - - - - - - - - - - - - - - - - - - - - - - - 
    static public Box Window(Size size, Point startPoint, string boxName = "", bool noShadow = false)
    {
      Box newBox = new Box
      {
        BoxSize
          = size,
        StartPoint
          = startPoint
      };
      if (boxName != "")
        newBox.BoxName = boxName;
      if (noShadow)
        newBox.NoShadow = true;
      return newBox;
    }
    public void Print(byte debug = 0)
    {
      Console.OutputEncoding = Encoding.UTF8;
      Console.CursorVisible = false;

      DrawShadows();

      string screen = "";
      int start = 180;

      for (int h = 0; h < ScreenHeight; h++)
      {
        string line = "";
        for (int w = 0; w < ScreenWidth; w++)
        {
          //   ColorCenter(w, h);
          line += PrintElements(ScreenElements[w, h]);
        }
        line += "\n";
        screen += line;
      }

      //  Console.Clear();
      Console.Write(screen);

      if (debug == 0)
        TextFieldDebug();

      void ColorCenter(int w, int h)
        => ScreenElements[w, h].BackgroundColor.RGBValues = IsInCenter(w, h) ? [255, 0, 0] : [220, 220, 120];
      bool IsInCenter(int w, int h)
        => w > 1 && w < ScreenWidth - 2 && h > 0 && h < ScreenHeight - 1;

      void DrawShadows()
      {
        foreach (Box b in ScreenBoxes)
        {
          if (b != null)
          {
            if (!b.NoShadow)
            {
              if (ShadowOrientation.South)
                DrawShadowHorizontal(b);
              if (ShadowOrientation.North)
                DrawShadowHorizontal(b, 1);
              if (ShadowOrientation.East)
                DrawShadowVertical(b);
              if (ShadowOrientation.West)
                DrawShadowVertical(b, 1);
            }
            if (!b.NoInternalShadow)
            {
              C.Color internalShadowColor = new C.Color
              {
                RGBValues = [20, 23, 30],
                //    IsForeground = false
              };
              int start = b.StartPoint.X + 1;
              ScreenElements[start, b.StartPoint.Y + 1].PrintChar = '▛';
              ScreenElements[start, b.StartPoint.Y + 1].ForegroundColor = internalShadowColor;

              for (int w = start + 1; w < b.StartPoint.X + b.BoxSize.Width - 1; w++)
              {
                ScreenElements[w, b.StartPoint.Y + 1].PrintChar = '▀';
                ScreenElements[w, b.StartPoint.Y + 1].ForegroundColor = internalShadowColor;
              }
              for (int h = b.StartPoint.Y + 2; h < b.StartPoint.Y + b.BoxSize.Height - 1; h++)
              {
                ScreenElements[b.StartPoint.X + 1, h].PrintChar = '▌';
                ScreenElements[b.StartPoint.X + 1, h].ForegroundColor = internalShadowColor;
              }
            }
          }
        }
        void DrawShadowHorizontal(Box b, int northModifier = 0)
        {
          int northSouth = northModifier == 0 ? b.StartPoint.Y + b.BoxSize.Height : b.StartPoint.Y - 1;
          int boxWidth = b.BoxSize.Width;

          for (int w = b.StartPoint.X; w < b.StartPoint.X + boxWidth; w++)
          {
            ScreenElements[w, northSouth].PrintChar = northModifier == 0 ? '▀' : '▄';
            ScreenElements[w, northSouth].ForegroundColor = ShadowColor;
          }
          if (this.ShadowOrientation.East)
          {
            ScreenElements[b.StartPoint.X, b.EndPoint.Y].PrintChar = northModifier == 0 ? '▝' : '▗';
            ScreenElements[b.EndPoint.X, b.EndPoint.Y].PrintChar = northModifier == 0 ? '▘' : '▖';
            ScreenElements[b.EndPoint.X, b.EndPoint.Y].ForegroundColor = ShadowColor;
          }
        }
        void DrawShadowVertical(Box b, int westModifier = 0)
        {
          int westEast = westModifier == 0 ? b.StartPoint.X + b.BoxSize.Width : b.StartPoint.X - 1;
          int boxHeight = b.BoxSize.Height;
          for (int h = b.StartPoint.Y; h < b.StartPoint.Y + boxHeight; h++)
          {
            ScreenElements[westEast, h].PrintChar = westModifier == 0 ? '▌' : '▐';
            ScreenElements[westEast, h].ForegroundColor = ShadowColor;
          }
          if (this.ShadowOrientation.South)
          {
            ScreenElements[(westModifier == 0 ? b.EndPoint.X : b.StartPoint.X - 1), b.StartPoint.Y].PrintChar = westModifier == 0 ? '▖' : '▗';
            ScreenElements[(westModifier == 0 ? b.EndPoint.X : b.StartPoint.X - 1), b.EndPoint.Y].PrintChar = westModifier == 0 ? '▘' : '▝';
            ScreenElements[(westModifier == 0 ? b.EndPoint.X : b.StartPoint.X - 1), b.EndPoint.Y].ForegroundColor = ShadowColor;
            ScreenElements[(westModifier == 0 ? b.EndPoint.X : b.EndPoint.X - 1), b.EndPoint.Y].PrintChar = '▘';
          }
        }
      }
    }
    public void TextFieldDebug()
    {
      PrintStartPointDebug();
      PrintEndPointDebug();
      PrintDebugCoordinates();
      PrintShadowDebug();

      void PrintShadowDebug()
      {
        Point S = new Point(0, 3);
        this.DebugTextX
          = new TextField("☀" + this.ShadowOrientation.ToString(), 1, S, this, this.DebugTextShadowOrientationGradient);
        this.Print(DebugTextX);
      }
      void PrintDebugCoordinates()
      {
        Point X = new Point(0, 1);
        this.DebugTextX
          = new TextField("X→", 1, X, this, this.DebugTextXGradient);
        this.Print(DebugTextX);

        Point Y = new Point(0, 2);
        this.DebugTextY
          = new TextField("Y↓", 1, Y, this, this.DebugTextYGradient);
        this.Print(DebugTextY);
      }
      void PrintEndPointDebug()
      {
        C.Color debugStartColor = new C.Color { RGBValues = [0, 50, 255] };
        C.Color debugEndColor = new C.Color { RGBValues = [0, 255, 88] };

        string text = $"P⁽{SupScript(EndPoint.X - 1)}·{SupScript(EndPoint.Y - 1)}⁾→€";
        this.DebugTextEndGradient = new C.Gradient(debugStartColor, debugEndColor, text.Length);

        Point debugPoint = new Point(EndPoint.X - text.Length, EndPoint.Y - 1);

        this.DebugTextEndPoint
          = new TextField(text, 1, debugPoint, this, this.DebugTextEndGradient);
        this.Print(DebugTextEndPoint);
      }
      void PrintStartPointDebug()
      {
        this.DebugTextStartPoint
          = new TextField($"$←P⁽{SupScript(StartPoint.X)}·{SupScript(StartPoint.Y)}⁾", 1, this.StartPoint, this, this.DebugTextStartGradient);
        this.Print(DebugTextStartPoint);
      }

      string SupScript(int n)
      {
        string toSupScript = n.ToString();
        char[] digits = toSupScript.ToCharArray();
        char[] supScriptChars = ['⁰', '¹', '²', '³', '⁴', '⁵', '⁶', '⁷', '⁸', '⁹'];
        toSupScript = "";
        for (int i = 0; i < digits.Length; i++)
        {
          switch (digits[i])
          {
            case '0':
              toSupScript += supScriptChars[0];
              break;

            case '1':
              toSupScript += supScriptChars[1];
              break;

            case '2':
              toSupScript += supScriptChars[2];
              break;

            case '3':
              toSupScript += supScriptChars[3];
              break;

            case '4':
              toSupScript += supScriptChars[4];
              break;

            case '5':
              toSupScript += supScriptChars[5];
              break;

            case '6':
              toSupScript += supScriptChars[6];
              break;

            case '7':
              toSupScript += supScriptChars[7];
              break;

            case '8':
              toSupScript += supScriptChars[8];
              break;

            case '9':
              toSupScript += supScriptChars[9];
              break;
          }
        }
        return toSupScript;
      }
    }
    public void AddBoxToScreen(Box box)
    {
      if (box == null) box = new Box();

      int startPointW = box.StartPoint.X,
          startPointH = box.StartPoint.Y,
          width = box.BoxSize.Width,
          height = box.BoxSize.Height,
          centerPointW = (startPointW + width / 2),
          centerPointH = (startPointH + height / 2);
      int n = 1;
      bool hasGradient = box.BoxGradient != null;

      Corners();
      Horizontal();
      Vertical();
      InsideBox();
      BoxName();

      void InsideBox()
      {
        for (int w = startPointW + 1; w < startPointW + width - 1; w++)
          for (int h = startPointH + 1; h < startPointH + height - 1; h++)
          {
            ScreenElements[w, h].IsInsideBox = true;
            ScreenElements[w, h].BackgroundColor = box.BoxBackgroundColor;
          }
        ScreenElements[centerPointW, centerPointH].PrintChar
          = '╳'; //
        C.Color foreground = new C.Color
        {
          RGBValues = [255, 0, 255]
        };
        ScreenElements[centerPointW, centerPointH].ForegroundColor = foreground;

        if (width % 2 == 0)
        {
          ScreenElements[centerPointW - 1, centerPointH].PrintChar
            = '╳'; //
          C.Color foregroundCenterPoint = new C.Color
          {
            RGBValues = [220, 0, 220]
          };
          ScreenElements[centerPointW - 1, centerPointH].ForegroundColor
            = foregroundCenterPoint;
        }
      }
      void Vertical()
      {
        for (int i = 0; i < 2; i++)
        {
          int drawWidth = i == 0 ? startPointW : startPointW + width - 1;
          n = i == 0 ? 1 : width;
          for (int h = startPointH + 1; h < startPointH + height - 1; h++)
          {
            ScreenElements[drawWidth, h].PrintChar
              = box.BoxChars.CharSet[2];

            ScreenElements[drawWidth, h].ForegroundColor
              = box.BoxLineColor;
            ScreenElements[drawWidth, h].BackgroundColor.RGBValues
              = hasGradient ? box.BoxGradient.GradientColors[n++].RGBValues : box.BoxLineBackgroundColor.RGBValues;
          }
        }
      }
      void Horizontal()
      {
        for (int i = 0; i < 2; i++)
        {
          int drawHeight = i == 0 ? startPointH : startPointH + height - 1;
          for (int w = startPointW + 1; w < startPointW + width - 1; w++)
          {
            ScreenElements[w, drawHeight].PrintChar
         = box.BoxChars.CharSet[6];
            ScreenElements[w, drawHeight].ForegroundColor
              = box.BoxLineColor;
            ScreenElements[w, drawHeight].BackgroundColor.RGBValues
              = hasGradient ? box.BoxGradient.GradientColors[n++].RGBValues : box.BoxLineBackgroundColor.RGBValues;
          }
          n = height;
        }
      }
      void Corners()
      {
        ScreenElements[startPointW, startPointH].PrintChar
         = box.BoxChars.CharSet[5];
        ScreenElements[startPointW, startPointH].ForegroundColor
          = box.BoxLineColor;
        ScreenElements[startPointW, startPointH].BackgroundColor.RGBValues
          = hasGradient ? box.BoxGradient.GradientColors[0].RGBValues : box.BoxLineBackgroundColor.RGBValues;

        ScreenElements[startPointW + width - 1, startPointH].PrintChar
          = box.BoxChars.CharSet[8];
        ScreenElements[startPointW + width - 1, startPointH].ForegroundColor
          = box.BoxLineColor;
        ScreenElements[startPointW + width - 1, startPointH].BackgroundColor.RGBValues
          = hasGradient ? box.BoxGradient.GradientColors[width].RGBValues : box.BoxLineBackgroundColor.RGBValues;

        ScreenElements[startPointW, startPointH + height - 1].PrintChar
           = box.BoxChars.CharSet[1];
        ScreenElements[startPointW, startPointH + height - 1].ForegroundColor
          = box.BoxLineColor;
        ScreenElements[startPointW, startPointH + height - 1].BackgroundColor.RGBValues
          = hasGradient ? box.BoxGradient.GradientColors[height].RGBValues : box.BoxLineBackgroundColor.RGBValues;

        ScreenElements[startPointW + width - 1, startPointH + height - 1].PrintChar
             = box.BoxChars.CharSet[3];
        ScreenElements[startPointW + width - 1, startPointH + height - 1].ForegroundColor
          = box.BoxLineColor;
        ScreenElements[startPointW + width - 1, startPointH + height - 1].BackgroundColor.RGBValues
          = hasGradient ? box.BoxGradient.GradientColors[width + height - 2].RGBValues : box.BoxLineBackgroundColor.RGBValues;
      }
      void BoxName()
      {
        string boxName = (box.BoxName.Length + 2) > width ? "[.]" : ("[" + box.BoxName + "]");
        boxName = box.BoxName == "-" ? "" : ("[" + box.BoxName + "]");
        int boxIdx = 0;
        C.Color foregroundName
          = new C.Color { RGBValues = [132,141,151] };
        C.Color foregroundName2
          = new C.Color { RGBValues = [255,255,255] };
        C.Color lineBC
          = new C.Color { IsForeground = false, RGBValues = [1, 4, 9] };

        for (int w = startPointW + 1; w < boxName.Length + startPointW + 1; w++)
        {
          ScreenElements[w, startPointH].PrintChar = boxName[boxIdx++];
          ScreenElements[w, startPointH].BackgroundColor = lineBC;

          if (w == startPointH + boxName.Length + 1 || w == startPointW + 1)
            ScreenElements[w, startPointH].ForegroundColor = foregroundName;
          else
            ScreenElements[w, startPointH].ForegroundColor = foregroundName2;
        }
      }
      ScreenBoxes[box.BoxID] = box;
    }

    public void CreateBox(Box box)
    { AddBoxToScreen(box); }



    public void CreateMenu(Menu menu)
    { menu.AddMenuToScreen(this); }
    /*
    public void AddMenuToScreen(Menu menu)
    {
      int hIdx = 0;
      for (int h = menu.StartPoint.Y; h < menu.StartPoint.Y + menu.MenuLines.Length; h++)
      {
        int counter = 0;
        for (int w = menu.StartPoint.X; w < menu.StartPoint.X + menu.MenuLines[hIdx].ToString().Length; w++)
        {
          ScreenElements[w, h].PrintChar
            = menu.MenuLines[hIdx].ToCharArray()[counter++];
        }
        hIdx++;
      }
    }*/
    #endregion methods

    #region properties

    #region DEBUG-FIELDS
    public TextField DebugTextStartPoint { get; set; }
    public C.Gradient DebugTextStartGradient { get; set; }
    public TextField DebugTextEndPoint { get; set; }
    public C.Gradient DebugTextEndGradient { get; set; }
    public TextField DebugTextX { get; set; }
    public C.Gradient DebugTextXGradient { get; set; }
    public TextField DebugTextY { get; set; }
    public C.Gradient DebugTextYGradient { get; set; }
    public TextField DebugTextShadowOrientation { get; set; }
    public C.Gradient DebugTextShadowOrientationGradient { get; set; }
    #endregion DEBUG-FIELDS

    public Shadow ShadowOrientation { get; set; }
    public C.Color ShadowColor { get; set; }
    public Element[,] ScreenElements
    {
      get => _screenElements;
      set => _screenElements = value;
    }
    public int ScreenWidth
    {
      get => _screenWidth;
      set => _screenWidth = value >= 9 ? value : 9;
    }
    public int ScreenHeight
    {
      get => _screenHeight;
      set => _screenHeight = value >= 5 ? value : 5;
    }
    public Point StartPoint { get; set; }
    public Point EndPoint { get => StartPoint + Size; }
    public Size Size { get => new Size(ScreenWidth, ScreenHeight); }
    public Point CenterPoint
      => new Point(Size.Height / 2, Size.Width / 2);
    public Box[] ScreenBoxes { get; set; }
    #endregion properties

    #region fields
    private Element[,] _screenElements;
    private int _screenWidth = 9;
    private int _screenHeight = 5;
    #endregion fields
  }
}