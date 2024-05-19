using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xConsole
{
  class TextField
  {
    #region constructor
    public TextField(string toPrint, int height, Point StartPoint, Screen screen, C.Gradient gradient = null)
    {
      this.StartPoint = StartPoint;

      this.Width = toPrint.Length;
      this.Height = height;

      this.FieldElements = new Element[screen.ScreenWidth, screen.ScreenHeight];

      this.ToPrint = toPrint;

      this.ForegroundColor = new C.Color();
      this.BackgroundColor = new C.Color { IsForeground = false };

      this.GradientColor = gradient;

      InitiateTextFieldElements();
    }
    #endregion constructor

    #region methods
    public void Print(Screen screen)
    {
      foreach (Element e in FieldElements)
        if (e != null) e.Print();
    }
    private void InitiateTextFieldElements()
    {
      char[] toPrint = ToPrint.ToCharArray();
      int counter = 0;
      //     this.FieldElements = new Element[255, 255];
      for (int h = StartPoint.Y; h < this.Height + StartPoint.Y; h++)
        for (int w = StartPoint.X; w < this.Width + StartPoint.X; w++)
        {
          Element e = new Element();
          this.FieldElements[w, h] = e;
          e.WIdx = w;
          e.HIdx = h;
          e.PrintChar = toPrint[counter++];
          e.ForegroundColor.RGBValues = [0, 0, 0];
          e.BackgroundColor.RGBValues 
            = (this.GradientColor == null) 
            ? [255, 0, 0] 
            : this.GradientColor.GradientColors[counter - 1].RGBValues;
        }
    }
    #endregion methods

    #region properties
    public Point StartPoint { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public Element[,] FieldElements { get; set; }
    public C.Color ForegroundColor { get; set; }
    public C.Color BackgroundColor { get; set; }
    public C.Gradient GradientColor { get; set; }
    public string ToPrint { get => _toPrint; set => _toPrint = value; }
    #endregion properties

    #region fields
    private string _toPrint;
    #endregion fields
  }
}