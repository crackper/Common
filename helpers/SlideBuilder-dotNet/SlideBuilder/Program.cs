﻿namespace SlideBuilder
{
  public class Program
  {
    static void Main()
    {
      SlideConverterV2.ExtractPPTXtoMD(
          @"C:\Users\mvesheff\Desktop\TEST", // Source folder
          "CSharp-Fundamentals", // GitHub repo name
          "cs", // Code language 
          @"C:\Users\mvesheff\Desktop\TEST"); // destination folder
    }
  }
}
