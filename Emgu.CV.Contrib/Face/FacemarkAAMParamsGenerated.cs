//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------



using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV.Face
{
   public static partial class FaceInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern void cveFacemarkAAMParamsGetModelFile(IntPtr obj, IntPtr str);
	 [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern void cveFacemarkAAMParamsSetModelFile(IntPtr obj, IntPtr str);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveFacemarkAAMParamsGetM(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveFacemarkAAMParamsSetM(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveFacemarkAAMParamsGetN(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveFacemarkAAMParamsSetN(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveFacemarkAAMParamsGetNIter(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveFacemarkAAMParamsSetNIter(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveFacemarkAAMParamsGetVerbose(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveFacemarkAAMParamsSetVerbose(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveFacemarkAAMParamsGetSaveModel(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveFacemarkAAMParamsSetSaveModel(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveFacemarkAAMParamsGetMaxM(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveFacemarkAAMParamsSetMaxM(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveFacemarkAAMParamsGetMaxN(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveFacemarkAAMParamsSetMaxN(
        IntPtr obj,  
        int val);
     
   }

   public partial class FacemarkAAMParams
   {

     /// <summary>
     /// filename where the trained model will be saved
     /// </summary>
     public String ModelFile
     {
        get 
        { 
           using (CvString s = new CvString())
           {  
              FaceInvoke.cveFacemarkAAMParamsGetModelFile(_ptr, s); 
              return s.ToString();
           }
        } 
		set
		{
		   using (CvString s = new CvString(value))
           {  
              FaceInvoke.cveFacemarkAAMParamsSetModelFile(_ptr, s); 
           }
		}
     }
     
     /// <summary>
     /// M
     /// </summary>
     public int M
     {
        get { return FaceInvoke.cveFacemarkAAMParamsGetM(_ptr); } 
        set { FaceInvoke.cveFacemarkAAMParamsSetM(_ptr, value); }
     }
     
     /// <summary>
     /// N
     /// </summary>
     public int N
     {
        get { return FaceInvoke.cveFacemarkAAMParamsGetN(_ptr); } 
        set { FaceInvoke.cveFacemarkAAMParamsSetN(_ptr, value); }
     }
     
     /// <summary>
     /// Number of iteration
     /// </summary>
     public int NIter
     {
        get { return FaceInvoke.cveFacemarkAAMParamsGetNIter(_ptr); } 
        set { FaceInvoke.cveFacemarkAAMParamsSetNIter(_ptr, value); }
     }
     
     /// <summary>
     /// show the training print-out
     /// </summary>
     public bool Verbose
     {
        get { return FaceInvoke.cveFacemarkAAMParamsGetVerbose(_ptr); } 
        set { FaceInvoke.cveFacemarkAAMParamsSetVerbose(_ptr, value); }
     }
     
     /// <summary>
     /// flag to save the trained model or not
     /// </summary>
     public bool SaveModel
     {
        get { return FaceInvoke.cveFacemarkAAMParamsGetSaveModel(_ptr); } 
        set { FaceInvoke.cveFacemarkAAMParamsSetSaveModel(_ptr, value); }
     }
     
     /// <summary>
     /// The maximum value of M
     /// </summary>
     public int MaxM
     {
        get { return FaceInvoke.cveFacemarkAAMParamsGetMaxM(_ptr); } 
        set { FaceInvoke.cveFacemarkAAMParamsSetMaxM(_ptr, value); }
     }
     
     /// <summary>
     /// The maximum value of N
     /// </summary>
     public int MaxN
     {
        get { return FaceInvoke.cveFacemarkAAMParamsGetMaxN(_ptr); } 
        set { FaceInvoke.cveFacemarkAAMParamsSetMaxN(_ptr, value); }
     }
     
   }
}
