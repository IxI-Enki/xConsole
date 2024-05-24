using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xConsole
{
  internal class Menu
  {
    #region fields
    private char _cursor = '▶';
    private Point _startPoint;
    private Line[]? _menuLines = null;
    private int _choice = 1;
    private Size _size = new Size(1, 1);
    private C.Color _chosenColor = new C.Color { RGBValues = [0, 255, 0], /*IsForeground = false */};
    #endregion fields

    #region properties
    public C.Color ChosenColor { get => _chosenColor; }
    public char Char => _cursor;
    public int MenuHeight => MenuLines.Length;
    public int MenuWidth => Size.Width;
    public Size Size { get; set; }
    public Point StartPoint { get; set; }
    public Line[] MenuLines { get; set; }
    public int Choice { get; set; }
    #endregion properties

    #region constructors
    public Menu(Point startPoint, params string[] menuLinesText)
      : this(startPoint)
    {
      MenuLines = new Menu.Line[menuLinesText.Length];
      for (int i = 0; i < menuLinesText.Length; i++)
      {
        Line newLine = new(menuLinesText[i]);
        MenuLines[i] = newLine;
      }
    }
    public Menu(Point startPoint, Line[] menuLines)
      : this(startPoint)
    { MenuLines = menuLines; }

    public Menu(Point startPoint)
    { StartPoint = startPoint; }

    #endregion constructors
    public void AddMenuToScreen(Screen screen)
    {
      int hIdx = 0;
      for (int h = this.StartPoint.Y; h < this.StartPoint.Y + this.MenuLines.Length; h++)
      {
        int counter = 0;
        for (int w = this.StartPoint.X; w < this.StartPoint.X + this.MenuLines[hIdx].ToString().Length; w++)
        {
          screen.ScreenElements[w, h].PrintChar
            = this.MenuLines[hIdx].ToCharArray()[counter++];
        }
        hIdx++;
      }
    }
    public void Loop(Screen screen)
    {
      Console.CursorVisible = false;
      bool run = true;
      do
      {
        if (Console.KeyAvailable)
        {
          ConsoleKeyInfo keyInfo = Console.ReadKey(true);

          // CheckShortcuts(keyInfo, out bool pressedShortcut, out run);
          // if (!pressedShortcut)

          switch (keyInfo.Key)
          {
            //  -  -  -  -  - ↑↑↑ -  -  -  -  -  
            case ConsoleKey.UpArrow:
              {
                Clear(screen);
                Choice--;
                Choice = (Choice < 0) ?
                      this.MenuHeight - 1 : Choice;
              }
              break;
            //  -  -  -  -  - ↓↓↓ -  -  -  -  -  
            case ConsoleKey.DownArrow:
              {
                Clear(screen);
                Choice++;
                Choice = (Choice <= this.MenuHeight - 1) ?
                                                Choice : 0;
              }
              break;
            //  -  -  -  -  -ENTER-  -  -  -  - 
            case ConsoleKey.Enter:
              // CheckExecutions(MenuLines[Choice].ExecutionIdx, out run);
              break;
            //  -  -  -  -  - ESC -  -  -  -  - 
            case ConsoleKey.Escape:
              //  Clear();
              run = false;
              return;
          }
        }
        Draw(screen);
      } while (run);
    }
    public void Clear(Screen screen)
    {
      screen.ScreenElements[StartPoint.X - 1, StartPoint.Y + Choice].PrintChar = ' ';
      screen.ScreenElements[StartPoint.X - 1, StartPoint.Y + Choice].ForegroundColor = new C.Color { RGBValues = [31, 37, 45] };
    }

    public void Draw(Screen screen)
    {
      screen.ScreenElements[StartPoint.X - 1, StartPoint.Y + Choice].PrintChar = _cursor;
      screen.ScreenElements[StartPoint.X - 1, StartPoint.Y + Choice].ForegroundColor = ChosenColor;
      Console.SetCursorPosition(0, 0);
      screen.Print(1);
    }
    private void CheckShortcuts(ConsoleKeyInfo keyInfo, out bool pressedShortcut, out bool run)
    {
      run = true;
      pressedShortcut = false;
      switch (keyInfo.Key)
      {
        case ConsoleKey.A:
          break;
        case ConsoleKey.B:
          break;
        case ConsoleKey.C:
          break;
        case ConsoleKey.D:
          break;
        case ConsoleKey.E:
          break;
        case ConsoleKey.F:
          break;
        case ConsoleKey.G:
          break;
        case ConsoleKey.H:
          break;
        case ConsoleKey.I:
          break;
        case ConsoleKey.J:
          break;
        case ConsoleKey.K:
          break;
        case ConsoleKey.L:
          break;
        case ConsoleKey.M:
          break;
        case ConsoleKey.N:
          break;
        case ConsoleKey.O:
          break;
        case ConsoleKey.P:
          break;
        case ConsoleKey.Q:
          break;
        case ConsoleKey.R:
          break;
        case ConsoleKey.S:
          break;
        case ConsoleKey.T:
          break;
        case ConsoleKey.U:
          break;
        case ConsoleKey.V:
          break;
        case ConsoleKey.W:
          break;
        // EXIT: 
        case ConsoleKey.D0:
        case ConsoleKey.X:
          pressedShortcut = true;
          run = false;
          break;
        case ConsoleKey.Y:
          break;
        case ConsoleKey.Z:
          break;
        // NUMBERS:
        case ConsoleKey.D1:

          break;
        case ConsoleKey.D2:

          break;
        case ConsoleKey.D3:

          break;
        case ConsoleKey.D4:

          break;
        case ConsoleKey.D5:

          break;
        case ConsoleKey.D6:

          break;
        case ConsoleKey.D7:

          break;

      }
    }

    #region embeded class
    internal class Line
    {
      #region fields
      private string _text;
      #endregion fields

      #region properties
      public string Text { get; set; }
      #endregion properties

      #region constructors
      public Line(string text)
      { Text = text; }
      #endregion constructors

      #region overrides
      public override string ToString()
        => Text;
      public char[] ToCharArray()
        => Text.ToCharArray();
      #endregion overrides
    }
    #endregion embeded class
  }
}
