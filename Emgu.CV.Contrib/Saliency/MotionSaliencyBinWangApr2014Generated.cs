//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------



using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV.Saliency
{
   public static partial class SaliencyInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveMotionSaliencyBinWangApr2014GetImageWidth(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveMotionSaliencyBinWangApr2014SetImageWidth(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveMotionSaliencyBinWangApr2014GetImageHeight(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveMotionSaliencyBinWangApr2014SetImageHeight(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
	 
     [return: MarshalAs(CvInvoke.BoolMarshalType)] 
     internal static extern bool cveMotionSaliencyBinWangApr2014Init(
        IntPtr obj);
     
   }

   public partial class MotionSaliencyBinWangApr2014
   {

     /// <summary>
     /// Image width
     /// </summary>
     public int ImageWidth
     {
        get { return SaliencyInvoke.cveMotionSaliencyBinWangApr2014GetImageWidth(_ptr); } 
        set { SaliencyInvoke.cveMotionSaliencyBinWangApr2014SetImageWidth(_ptr, value); }
     }
     
     /// <summary>
     /// Image height
     /// </summary>
     public int ImageHeight
     {
        get { return SaliencyInvoke.cveMotionSaliencyBinWangApr2014GetImageHeight(_ptr); } 
        set { SaliencyInvoke.cveMotionSaliencyBinWangApr2014SetImageHeight(_ptr, value); }
     }
     
     /// <summary>
     /// This function allows the correct initialization of all data structures that will be used by the algorithm.
     /// </summary>
     public bool Init( )
     {
        return SaliencyInvoke.cveMotionSaliencyBinWangApr2014Init(_ptr); 
     }
     
   }
}
