#region header ( class: C - general information )
// - This region stores info about the author and the program( version, features,.. )
/*
 *    ╔══════════════════════╦═══════════════════════════════════════════════════════════════════╗
 *    ║   HTBLA - Leonding   ║ ┏━━━━━━━━━━━━━━━┯━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ║█
 *    ╠═════════╤════════════╣ ┃▷ DESCRIPTION  │                                               ┃ ║█
 *    ║  Name   │  Jan Ritt  ║ ┃               │                                               ┃ ║█
 *    ╟─────────┼────────────╢ ┃               │                                               ┃ ║█
 *    ║  Class  │  4 ACIFT   ║ ┠───────────────┼───────────────────────────────────────────────┨ ║█
 *    ╟─────────┼────────────╢ ┃▷ SYNTAX       │ C.                                            ┃ ║█
 *    ║  Year   │  2024      ║ ┃ ► Color.      │                                               ┃ ║█
 *    ╟─────────┴────────────╢ ┃ ► Gradient.   │                                               ┃ ║█
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

#region using
// - imported Libraries

using System;                                       // Basic system operations
using Microsoft;
using System.Collections.Generic;                   // Collections for working with lists, dictionaries, etc.
using System.Linq;                                  // LINQ for querying collections in a concise way
using System.Text;                                  // String manipulation and StringBuilder
using System.IO;                                    // Input and output operations, file handling
using System.Net;                                   // Networking functionality
using System.Threading;                             // Threading for managing threads and concurrency
using System.Data;                                  // Data access and manipulation (ADO.NET)
using System.Xml;                                   // XML processing
// using Microsoft.Extensions.Configuration;           // Configuration management in .NET Core applications
// using Microsoft.AspNetCore.Mvc;                     // ASP.NET Core MVC
// using Microsoft.EntityFrameworkCore;                // Entity Framework Core for database access
// using Newtonsoft.Json;                              // JSON serialization and deserialization
// using Microsoft.VisualStudio.TestTools.UnitTesting; // Unit testing with MSTest
using System.Text.RegularExpressions;               // Regular expressions
using System.Reflection;                            // Reflection for working with metadata
using System.Windows;                               // Windows Presentation Foundation (WPF) for desktop applications
using System.Net.Http;                              // HTTP client for making HTTP requests
using System.Text.Json;                             // JSON serialization and deserialization (System.Text.Json in .NET Core)
using System.Dynamic;                               // Working with dynamic objects
// using Microsoft.Extensions.DependencyInjection;     // Dependency Injection in ASP.NET Core
using System.Runtime.Serialization;                 // Serialization for binary data
using System.Globalization;                         // Working with dates and times
using System.Threading.Tasks;                       // Working with parallel programming tasks
using System.ComponentModel;                        // Component-based development
using System.Diagnostics;                           // Process and performance monitoring
using System.Security.Cryptography;                 // Cryptographic operations
using System.Web;                                   // Web-related functionality (Note: More common in ASP.NET Framework)
using System.Runtime.InteropServices;               // Interoperability with unmanaged code
using System.Net.Mail;                              // Sending emails
using System.Net.Sockets;                           // Network programming
// using System.Windows.Forms;                         // Windows Forms for desktop applications
using System.Collections.Concurrent;                // Concurrent collections
using System.ServiceModel;                          // Windows Communication Foundation (WCF)
// using System.Web.Mvc;                               // ASP.NET MVC (Note: More common in ASP.NET Framework)
using System.Data.SqlClient;                        // SQL Server data access
using System.Drawing;                               // Basic drawing and imaging
using System.Configuration;                         // Configuration management (Note: More common in older versions of .NET)
// using System.Windows.Controls;                      // WPF controls
using System.Runtime.CompilerServices;              // Compiler services (e.g., async/await)
#endregion

namespace xConsole
{
  class C
  {
    #region constants
    public static string Reset = "\u001B[0m";
    #endregion constants

    public class Color
    {
      #region constructors
      public Color()
      {
        RedValue = 255;
        BlueValue = 0;
        GreenValue = 0;
        IsForeground = true;
      }
      #endregion constructors

      #region properties
      public string AnsiEsc
        => "\u001B[" + (IsForeground ? "3" : "4") + "8;2;" + this.ToString() + "m";
      public bool IsForeground
      {
        get => _isForeground;
        set => _isForeground = value;
      }
      public int RedValue
      {
        get => _redValue;
        set => _redValue = (value >= 0 && value <= 255) ? value : 0;
      }
      public int GreenValue
      {
        get => _greenValue;
        set => _greenValue = (value >= 0 && value <= 255) ? value : 0;
      }
      public int BlueValue
      {
        get => _blueValue;
        set => _blueValue = (value >= 0 && value <= 255) ? value : 0;
      }
      public int[] RGBValues
      {
        get
        {
          _rgbValues[0] = RedValue;
          _rgbValues[1] = GreenValue;
          _rgbValues[2] = BlueValue;

          return _rgbValues;
        }
        set
        {
          if (value.Length == 3)
          {
            _redValue = value[0];
            _greenValue = value[1];
            _blueValue = value[2];

            _rgbValues = value;
          }
        }
      }
      #endregion properties

      #region overrides
      public override string ToString()
        => string.Join(';', RGBValues);
      #endregion overrides

      #region fields
      private int[] _rgbValues
        = new int[3];
      private int _redValue,
                   _greenValue,
                   _blueValue;
      private bool _isForeground;
      private string _ansiEsc;
      #endregion fields
    }
    public class Gradient
    {
      #region constructors
      public Gradient(Color startColor, Color endColor, int length)
      {
        this.StartColor = startColor;
        this.EndColor = endColor;

        this.Length = length;

        this.DrawGradient();
      }
      #endregion constructors

      #region methods
      public void DrawGradient()
      {
        this.GradientColors = new Color[this.Length];

        int gradientCounter = this.Length;

        int[] RGBGradientDifferences
          = [
            (this.StartColor.RedValue - this.EndColor.RedValue) / gradientCounter,      //
            (this.StartColor.GreenValue - this.EndColor.GreenValue) / gradientCounter,  //
            (this.StartColor.BlueValue - this.EndColor.BlueValue) / gradientCounter     //
          ];
        this.GradientColors[0] = this.StartColor;

        for (int g = 1; g < gradientCounter; g++)
        {
          Color nextGradient = new Color();
          nextGradient.RedValue = GradientColors[g - 1].RedValue - (RGBGradientDifferences[0]);
          nextGradient.GreenValue = GradientColors[g - 1].GreenValue - (RGBGradientDifferences[1]);
          nextGradient.BlueValue = GradientColors[g - 1].BlueValue - (RGBGradientDifferences[2]);
          this.GradientColors[g] = nextGradient;
        }
        this.GradientColors[this.Length - 1] = this.EndColor;
      }
      #endregion methods

      #region properties
      public bool IsAdditive { get; set; }
      public Color StartColor { get; set; }
      public Color EndColor { get; set; }
      public int Length
      {
        get => _length;
        set => _length = (value > 2 ? value : 2);
      }
      public Color[] GradientColors { get; set; }
      #endregion properties

      #region fields
      private bool _isAdditive = true;
      private int _length;
      private Size _size;
      #endregion fields
    }

    // THEMED VALUES
    public class Presets
    {
      public static int[] GIT_Line = [132, 141, 151],
                          GIT_Medium = [19, 37, 45],
                          GIT_Dark = [1, 4, 9];
    }

  }
}