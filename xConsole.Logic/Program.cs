#region header ( class: Main - general information )
// - This region stores info about the author and the program( version, features,.. )
/*
 *    ╔══════════════════════╦═══════════════════════════════════════════════════════════════════╗
 *    ║   HTBLA - Leonding   ║ ┏━━━━━━━━━━━━━━━┯━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ║█
 *    ╠═════════╤════════════╣ ┃▷ DESCRIPTION  │                                               ┃ ║█
 *    ║  Name   │  Jan Ritt  ║ ┃               │                                               ┃ ║█
 *    ╟─────────┼────────────╢ ┃               │                                               ┃ ║█
 *    ║  Class  │  4 ACIFT   ║ ┠───────────────┼───────────────────────────────────────────────┨ ║█
 *    ╟─────────┼────────────╢ ┃▷ SYNTAX       │ Class                                         ┃ ║█
 *    ║  Year   │  2024      ║ ┃ ► _nameHere_  │                                               ┃ ║█
 *    ╟─────────┴────────────╢ ┃               │                                               ┃ ║█
 *    ║  Last edit:  5.2024  ║ ┃               │                                               ┃ ║█
 *    ╚══════════════════════╣ ┃  ╌╌╌╌╌╌╌╌╌╌╌╌╌┼╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌╌ ┃ ║█
 *      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀║ ┃ ► _nameHere_  │                                               ┃ ║█
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

using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace xConsole
{
  class Program
  {
    static void Main()
      =>
    TEST_Menu();
    // TEST_BoxAnimation();
    // TEST_BoxGradientThree();
    // TEST_BoxGradientsTwo();
    // TEST_BoxGradients();
    // TEST_Boxes();
    // TEST_ShadowOrientation();
    // TEST_BiggerScreen();
    // TEST_ColorGradientTwo();
    // TEST_ColorGradient();
    // TEST_Screen();
    // TEST_Elements();
    // TEST_ElementsColor();

    #region TESTS
    //---------------------------------------------------------------------------------------
    static private void TEST_ElementsColor()
    {
      byte r = 0, g = 90, b = 0;
      for (int i = 0; i < Console.WindowWidth; i++)
      //    for (int j = 0; j < Console.WindowHeight; j++)
      {
        Element e = new Element();
        e.BackgroundColor.RedValue = r;
        e.BackgroundColor.GreenValue = g;
        e.BackgroundColor.BlueValue = b;
        r += (b < 100) ? (byte)0 : (byte)1;
        b += 1;
        g -= (b < (byte)30) ? (byte)1 : (byte)0;
        Console.Write(e.BackgroundColor.AnsiEsc + " ");
      }
      Console.ReadLine();
    }
    //---------------------------------------------------------------------------------------
    static private void TEST_Elements()
    {
      Element e1 = new Element();

      Console.Write
        (
          $"\n ElementId: "
          +
          e1.ElementId
        );
      Console.Write
        (
          $"\n Element{e1.ElementId}.Char: "
      +
      e1.PrintChar
      );

      Element e2 = new Element();
      e2.PrintChar = 'Ü';

      Console.Write
        (
          $"\n ElementId: "
          +
          e2.ElementId
        );
      Console.Write
        (
          $"\n Element{e2.ElementId}.Char: "
          +
          e2.PrintChar
        );

      e2.ForegroundColor.RGBValues = [0, 255, 255];
      e2.BackgroundColor.RGBValues = [0, 255, 0];
      e2.BackgroundColor.IsForeground = false;

      Console.Write
        (
          e2.BackgroundColor.AnsiEsc
          +
          e2.ForegroundColor.AnsiEsc
          +
            $"\n Element{e2.ElementId}.ForegroundColor: "
            +
            e2.ForegroundColor
          +
          C.Reset
        );

      Console.ReadLine();
    }
    //---------------------------------------------------------------------------------------
    static private void TEST_Screen()
    {
      Console.OutputEncoding = Encoding.UTF8;
      // Screen screen = new Screen(88, 20);
      Screen screen = new Screen();

      screen.Print();

      Console.WriteLine();
    }
    //---------------------------------------------------------------------------------------
    static private void TEST_ColorGradient()
    {
      Console.OutputEncoding = Encoding.UTF8;
      Screen screen = new Screen();

      // StartColor:
      C.Color red = new C.Color();
      red.RGBValues = [255, 0, 0];
      // EndColor:
      C.Color green = new C.Color();
      green.RGBValues = [120, 200, 0];
      // GradientLength:
      int length = 8;
      C.Gradient gradient
        = new C.Gradient(red, green, length);

      // GRADIENT OF START-TEXTFIELD:
      screen.DebugTextStartGradient = gradient;
    }
    static private void TEST_ColorGradientTwo()
    {
      Console.OutputEncoding = Encoding.UTF8;
      Screen screen = new Screen();

      // StartColor:
      C.Color red = new C.Color();
      red.RGBValues = [255, 0, 0];
      // EndColor:
      C.Color green = new C.Color();
      green.RGBValues = [120, 200, 0];
      // GradientLength:
      int length = 8;
      C.Gradient gradientStartDebug
        = new C.Gradient(red, green, length);

      // GRADIENT OF START TEXTFIELD:
      screen.DebugTextStartGradient = gradientStartDebug;

      // StartColor:
      C.Color blue = new C.Color();
      blue.RGBValues = [0, 0, 220];

      // EndColor:
      green = new C.Color();
      green.RGBValues = [0, 160, 60];
      // GradientLength:
      C.Gradient gradientEndDebug
         = new C.Gradient(blue, green, length);

      // GRADIENT OF END TEXTFIELD:
      screen.DebugTextEndGradient = gradientEndDebug;

      // GRADIENT OF COORDS
      length = 2;
      C.Color blue2 = new C.Color();
      blue2.RGBValues = [0, 100, 100];
      screen.DebugTextXGradient = new C.Gradient(green, blue2, length);
      screen.DebugTextYGradient = new C.Gradient(blue2, green, length);

      // PRINT SCREEN:
      screen.Print();

      Console.ReadLine();
    }
    //---------------------------------------------------------------------------------------
    static private void TEST_BiggerScreen()
    {
      Console.OutputEncoding = Encoding.UTF8;
      Screen screen = new Screen(33, 7);

      // StartColor:
      C.Color red = new C.Color();
      red.RGBValues = [255, 0, 0];
      // EndColor:
      C.Color green = new C.Color();
      green.RGBValues = [120, 200, 0];
      // GradientLength:
      int length = 8;
      C.Gradient gradientStartDebug
        = new C.Gradient(red, green, length);

      // GRADIENT OF START TEXTFIELD:
      screen.DebugTextStartGradient = gradientStartDebug;

      // StartColor:
      C.Color blue = new C.Color();
      blue.RGBValues = [0, 0, 220];

      // EndColor:
      green = new C.Color();
      green.RGBValues = [0, 160, 60];
      // GradientLength:
      C.Gradient gradientEndDebug
         = new C.Gradient(blue, green, length);

      // GRADIENT OF END TEXTFIELD:
      screen.DebugTextEndGradient = gradientEndDebug;

      // GRADIENT OF COORDS
      length = 2;
      C.Color blue2 = new C.Color();
      blue2.RGBValues = [0, 100, 100];
      screen.DebugTextXGradient = new C.Gradient(green, blue2, length);
      screen.DebugTextYGradient = new C.Gradient(blue2, green, length);

      // PRINT SCREEN:
      screen.Print();

      Console.ReadLine();
    }
    //---------------------------------------------------------------------------------------
    static private void TEST_ShadowOrientation()
    {
      Console.OutputEncoding = Encoding.UTF8;
      Screen screen = new Screen(33, 13);
      // StartColor:
      C.Color red = new C.Color();
      red.RGBValues = [255, 100, 0];
      // EndColor:
      C.Color green = new C.Color();
      green.RGBValues = [120, 255, 0];
      // GradientLength:
      int length = 8;
      C.Gradient gradientStartDebug
        = new C.Gradient(red, green, length);

      // GRADIENT OF START TEXTFIELD:
      screen.DebugTextStartGradient = gradientStartDebug;

      // StartColor:
      C.Color blue = new C.Color();
      blue.RGBValues = [0, 0, 220];

      // EndColor:
      green = new C.Color();
      green.RGBValues = [0, 160, 60];
      // GradientLength:
      C.Gradient gradientEndDebug
         = new C.Gradient(blue, green, length);

      // GRADIENT OF END TEXTFIELD:
      screen.DebugTextEndGradient = gradientEndDebug;

      // GRADIENT OF COORDS
      length = 2;
      C.Color blue2 = new C.Color();
      blue2.RGBValues = [0, 100, 100];
      screen.DebugTextXGradient = new C.Gradient(green, blue2, length);
      screen.DebugTextYGradient = new C.Gradient(blue2, green, length);

      // SHADOW GRADIENT:
      C.Color Shadow0 = new C.Color();
      Shadow0.RGBValues = [255, 255, 0];
      C.Color Shadow1 = new C.Color();
      Shadow1.RGBValues = [200, 188, 0];

      screen.DebugTextShadowOrientationGradient = new C.Gradient(Shadow0, Shadow1, length);

      screen.ShadowOrientation.South = true;
      screen.ShadowOrientation.East = true;

      // PRINT SCREEN:
      screen.Print();

      Console.ReadLine();
    }
    //---------------------------------------------------------------------------------------
    static private void TEST_Boxes()
    {
      Console.OutputEncoding = Encoding.UTF8;
      Screen screen = new Screen(33, 13);
      screen.ShadowColor = new C.Color
      {
        RGBValues = [160, 160, 100]
      };

      Box testBox0 = Screen.Window(
        new Size(11, 7),
        new Point(4, 3),
        "TestBox"
        //,  true
        );
      //    testBox0.BoxChars.CharSet = Box.BoxChar.DoubleCharSet;

      /*
      Box testBox1 = Screen.Window(
        new Size(10, 5),
        new Point(17, 2),
        " $ "
        //,  true
        );
      testBox1.BoxLineColor.RGBValues = [200, 40, 0];
      testBox1.BoxChars.CharSet = Box.BoxChar.RoundedCharSet;

      /*
      Box testBox2 = Screen.Window(
       new Size(10, 3),
       new Point(17, 8),
       " Hub "
       //,  true
       );

      testBox2.BoxLineBackgroundColor.RGBValues = [255, 200, 0];
      testBox2.BoxLineColor.RGBValues = [0, 0, 0];
      testBox2.BoxChars.CharSet = Box.BoxChar.ThickCharSet;
      */
      // StartColor:
      C.Color red = new C.Color
      {
        RGBValues = [255, 100, 0]
      };
      // EndColor:
      C.Color green = new C.Color
      {
        RGBValues = [120, 255, 0]
      };
      // GradientLength:
      int length = 8;
      C.Gradient gradientStartDebug
        = new C.Gradient(red, green, length);

      // GRADIENT OF START TEXTFIELD:
      screen.DebugTextStartGradient = gradientStartDebug;

      // StartColor:
      C.Color blue = new C.Color
      {
        RGBValues = [0, 0, 220]
      };

      // EndColor:
      green = new C.Color
      {
        RGBValues = [0, 160, 60]
      };
      // GradientLength:
      C.Gradient gradientEndDebug
         = new C.Gradient(blue, green, length);

      // GRADIENT OF END TEXTFIELD:
      screen.DebugTextEndGradient = gradientEndDebug;

      // GRADIENT OF COORDS TEXTFIELD:
      length = 2;
      C.Color blue2 = new C.Color();
      blue2.RGBValues = [0, 100, 100];
      screen.DebugTextXGradient = new C.Gradient(green, blue2, length);
      screen.DebugTextYGradient = new C.Gradient(blue2, green, length);

      // GRADIENT OF SUN TEXTFIELD:
      C.Color Shadow0 = new C.Color();
      Shadow0.RGBValues = [255, 255, 0];
      C.Color Shadow1 = new C.Color();
      Shadow1.RGBValues = [200, 188, 0];
      screen.DebugTextShadowOrientationGradient = new C.Gradient(Shadow0, Shadow1, length);

      screen.ShadowOrientation.South = true;
      screen.ShadowOrientation.East = true;

      // PRINT SCREEN:
      screen.AddBoxToScreen(testBox0);
      // screen.AddBoxToScreen(testBox1);
      // screen.AddBoxToScreen(testBox2);
      screen.Print();

      // PrintAdd();
      void PrintAdd()
      {
        Console.SetCursorPosition(5, 4);
        Console.Write("hier");
        Console.SetCursorPosition(5, 5);
        Console.Write("könnte");
        Console.SetCursorPosition(5, 6);
        Console.Write("ihre");
        Console.SetCursorPosition(5, 7);
        Console.Write("Werbung");
        Console.SetCursorPosition(5, 8);
        Console.Write("stehen.");

        Console.SetCursorPosition(18, 3);
        Console.Write("$ Raid $");
        Console.SetCursorPosition(18, 4);
        Console.Write(" Shadow ");
        Console.SetCursorPosition(18, 5);
        Console.Write("Legends$");

        Console.SetCursorPosition(18, 9);
        Console.Write("PornHub ");
      }

      Console.ReadLine();
    }
    //---------------------------------------------------------------------------------------
    static private void TEST_BoxGradients()
    {
      int width = 48, height = 13;
      Screen screen = new Screen(width, height);
      Box testBox0 = Screen.Window
        (
          new Size(width - 12, height - 8),
          new Point(4, 2),
          "-"
        );
      //    testBox0.BoxChars.CharSet = Box.BoxChar.DoubleCharSet;

      screen.ShadowOrientation.South = true;
      screen.ShadowOrientation.East = true;

      testBox0.BoxGradient
        = new C.Gradient
        (
          new C.Color { RGBValues = [12, 95, 48] },
          new C.Color { RGBValues = [0, 100, 140] },
          width + height - 2
        );

      testBox0.BoxLineColor
        = new C.Color
        {
          RGBValues
          // = [0, 73, 43]
          = [120, 240, 120]
        };

      testBox0.BoxName = "Graded Box";

      // PRINT SCREEN:
      screen.AddBoxToScreen(testBox0);
      screen.Print();

      Console.ReadLine();
    }
    static private void TEST_BoxGradientsTwo()
    {
      int width = 48, height = 13;
      Screen screen = new Screen(width, height);
      screen.ShadowOrientation.South = true;
      screen.ShadowOrientation.East = true;

      Box1();
      Box2();
      Box3();

      void Box1()
      {
        Box testBox0 = Screen.Window
          (
            new Size(width - 12, height - 8),
            new Point(4, 2),
            "-"
          );
        //      testBox0.BoxChars.CharSet = Box.BoxChar.DoubleCharSet;

        testBox0.BoxGradient
        = new C.Gradient
        (
          new C.Color { RGBValues = [12, 95, 48] },
          new C.Color { RGBValues = [0, 0, 0] },
          testBox0.BoxSize.Width + testBox0.BoxSize.Height
        );

        testBox0.BoxLineColor
          = new C.Color { RGBValues = [120, 240, 120] };

        testBox0.BoxName = "Graded Box";
        screen.AddBoxToScreen(testBox0);
      }
      void Box2()
      {
        Box testBox0 = Screen.Window
          (
            new Size(6, 3),
            new Point(4, 8),
            "-"
          );
        //    testBox0.BoxChars.CharSet = Box.BoxChar.RoundedCharSet;

        testBox0.BoxGradient
        = new C.Gradient
        (
          new C.Color { RGBValues = [255, 255, 255] },
          new C.Color { RGBValues = [0, 200, 0] },
          testBox0.BoxSize.Width + testBox0.BoxSize.Height
        );

        testBox0.BoxLineColor
          = new C.Color { RGBValues = [240, 80, 0] };

        // testBox0.BoxName = "Graded Box";
        screen.AddBoxToScreen(testBox0);
      }
      void Box3()
      {
        Box testBox0 = Screen.Window
          (
            new Size(16, 3),
            new Point(16, 8),
            " Thick "
          );
        //    testBox0.BoxChars.CharSet = Box.BoxChar.ThickCharSet;

        testBox0.BoxGradient
        = new C.Gradient
        (
          new C.Color { RGBValues = [55, 200, 200] },
          new C.Color { RGBValues = [55, 0, 44] },
          testBox0.BoxSize.Width + testBox0.BoxSize.Height
        );

        testBox0.BoxLineColor
          = new C.Color { RGBValues /* = [0, 73, 43] */= [240, 0, 0] };

        screen.AddBoxToScreen(testBox0);
      }

      // PRINT SCREEN:
      screen.Print();
      Console.ReadLine();
    }
    static private void TEST_BoxGradientThree()
    {
      int
        width = 48,
        height = 13;
      Screen screen
        = new(width, height);
      screen.ShadowOrientation.South
        = true;
      screen.ShadowOrientation.East
        = true;

      Box One = new Box
      {
        BoxSize = new Size(width - 13, 9),
        StartPoint = new Point(3, 2),
        BoxName = "",
        BoxChars = new Box.BoxChar(charSet: Box.BoxChar.DoubleCharSet),
        BoxGradient = null
      };
      screen.CreateBox(One);

      screen.CreateBox
      (
        new Box
        {
          BoxSize = new Size(3, 9),
          StartPoint = new Point(39, 2),
          BoxChars = new Box.BoxChar(charSet: Box.BoxChar.RoundedCharSet),
          BoxName = "-",
          NoShadow = true,
          NoInternalShadow = true,
          //    BoxGradient = null
          BoxGradient = new C.Gradient(new C.Color { RGBValues = [250, 250, 250] }, new C.Color { RGBValues = [0, 0, 0] }, 12)
        }
      );

      screen.CreateBox
      (
        new Box
        {
          BoxSize = new Size(3, 9),
          StartPoint = new Point(42, 2),
          BoxChars = new Box.BoxChar(charSet: Box.BoxChar.RoundedCharSet),
          BoxName = "-",
          NoShadow = true,
          NoInternalShadow = true,
          BoxGradient = new C.Gradient(new C.Color { RGBValues = [253, 253, 253] }, new C.Color { RGBValues = [0, 0, 0] }, 12)
        }
      );

      screen.CreateBox
      (
        new Box()
        {
          BoxSize = new Size(3, 12),
          StartPoint = new Point(45, 0),
          BoxChars = new Box.BoxChar(charSet: Box.BoxChar.DefaultCharSet),
          BoxName = "-",
          NoShadow = true,
          NoInternalShadow = true,
          BoxLineColor
            = new C.Color { RGBValues = [255, 55, 0] },
          BoxGradient
            = new C.Gradient(new C.Color { RGBValues = [255, 255, 255] }, new C.Color { RGBValues = [0, 0, 0] }, 14)
        }
      );
      screen.Print();
      Console.ReadLine();
    }
    //---------------------------------------------------------------------------------------
    static private void TEST_BoxAnimation()
    {
      int
      width = 48,
      height = 13;
      Screen screen
        = new(width, height);
      screen.ShadowOrientation.South
        = true;
      screen.ShadowOrientation.East
        = true;

      bool run = true;
      int[] rgbValue = [250, 250, 250],
            endValue = [0, 0, 0];
      int difference = 10;
      int max = 255;
      int min = 0;

      Console.Clear();

      Box newBox = new Box()
      {
        BoxSize = new Size(18, 6),
        StartPoint = new Point(3, 2),
        BoxChars = new Box.BoxChar(charSet: Box.BoxChar.DefaultCharSet),
        BoxName = "Test Box",
        NoShadow = true,
        NoInternalShadow = true,
        BoxLineColor
             = new C.Color { RGBValues = [255, 55, 0] },
        BoxGradient
             = new C.Gradient(new C.Color { RGBValues = rgbValue }, new C.Color { RGBValues = endValue }, 44)
      };

      do
      {
        newBox.BoxGradient = new C.Gradient(new C.Color { RGBValues = rgbValue }, new C.Color { RGBValues = endValue }, 44);
        screen.CreateBox(newBox);
        Console.SetCursorPosition(0, 0);

        screen.Print(1);

        rgbValue = [max - difference, min + difference, max - difference];
        endValue = [min + difference, max - difference, min + difference];

        difference = (difference + 10) % 250;

        if (difference >= 240)
        {
          int[] swap = rgbValue;
          rgbValue = endValue;
          endValue = swap;

          int swapp = min;
          min = max;
          max = swapp;

          difference = -difference;
        }
      } while (run);

      Console.ReadLine();
    }
    //---------------------------------------------------------------------------------------
    static private void TEST_Menu()
    {
      Screen screen = new(23, 10);
      screen.ShadowOrientation.South = true;
      screen.ShadowOrientation.East = true;

      Menu newMenu = new Menu(new Point(5, 4), "New", "Off");
      //   newMenu.StartPoint = new Point(4, 4);
      Box newBox = new Box()
      {
        BoxSize = new Size(18, 6),
        StartPoint = new Point(3, 2),
        BoxChars
          = new Box.BoxChar(charSet: Box.BoxChar.DefaultCharSet),
        BoxName = "Thema-Git-dark",
        NoShadow = false,
        NoInternalShadow = false,
        BoxLineColor
          = new C.Color
          {
            RGBValues = [132, 141, 151]
          },
        BoxGradient
          = new C.Gradient
            (
              new C.Color
              {
                RGBValues = [1, 4, 9]
              },
              new C.Color
              {
                RGBValues = [31, 37, 45]
              },
              29
            )
      };
      screen.CreateBox(newBox);

      screen.CreateMenu(newMenu);
      screen.Print();

      newMenu.Loop();

      Console.ReadLine();
    }
    #endregion TESTS
  }
}