//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------



using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV.Plot
{
   public static partial class PlotInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePlot2dSetMinX(
        IntPtr obj,  
        double val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePlot2dSetMinY(
        IntPtr obj,  
        double val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePlot2dSetMaxX(
        IntPtr obj,  
        double val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePlot2dSetMaxY(
        IntPtr obj,  
        double val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePlot2dSetPlotLineWidth(
        IntPtr obj,  
        int val);
     
   }

   public partial class Plot2d
   {

     /// <summary>
     /// Min X
     /// </summary>
     public void SetMinX(double value)
     {
        PlotInvoke.cvePlot2dSetMinX(_ptr, value); 
     }
     
     /// <summary>
     /// Min Y
     /// </summary>
     public void SetMinY(double value)
     {
        PlotInvoke.cvePlot2dSetMinY(_ptr, value); 
     }
     
     /// <summary>
     /// Max X
     /// </summary>
     public void SetMaxX(double value)
     {
        PlotInvoke.cvePlot2dSetMaxX(_ptr, value); 
     }
     
     /// <summary>
     /// Max Y
     /// </summary>
     public void SetMaxY(double value)
     {
        PlotInvoke.cvePlot2dSetMaxY(_ptr, value); 
     }
     
     /// <summary>
     /// Plot line width
     /// </summary>
     public void SetPlotLineWidth(int value)
     {
        PlotInvoke.cvePlot2dSetPlotLineWidth(_ptr, value); 
     }
     
   }
}
