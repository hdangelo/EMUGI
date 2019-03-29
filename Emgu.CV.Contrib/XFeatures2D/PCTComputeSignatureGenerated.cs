//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------



using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV.XFeatures2D
{
   public static partial class XFeatures2DInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cvePCTSignaturesGetGrayscaleBits(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetGrayscaleBits(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cvePCTSignaturesGetWindowRadius(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetWindowRadius(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cvePCTSignaturesGetWeightX(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetWeightX(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cvePCTSignaturesGetWeightY(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetWeightY(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cvePCTSignaturesGetWeightL(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetWeightL(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cvePCTSignaturesGetWeightA(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetWeightA(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cvePCTSignaturesGetWeightB(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetWeightB(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cvePCTSignaturesGetWeightEntropy(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetWeightEntropy(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cvePCTSignaturesGetIterationCount(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetIterationCount(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cvePCTSignaturesGetMaxClustersCount(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetMaxClustersCount(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cvePCTSignaturesGetClusterMinSize(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetClusterMinSize(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cvePCTSignaturesGetJoiningDistance(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetJoiningDistance(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cvePCTSignaturesGetDropThreshold(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetDropThreshold(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern PCTSignatures.PointDistributionType cvePCTSignaturesGetDistanceFunction(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cvePCTSignaturesSetDistanceFunction(
        IntPtr obj,  
        PCTSignatures.PointDistributionType val);
     
   }

   public partial class PCTSignatures
   {

     /// <summary>
     /// Color resolution of the greyscale bitmap represented in allocated bits (i.e., value 4 means that 16 shades of grey are used). The greyscale bitmap is used for computing contrast and entropy values.
     /// </summary>
     public int GrayscaleBits
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetGrayscaleBits(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetGrayscaleBits(_ptr, value); }
     }
     
     /// <summary>
     /// Size of the texture sampling window used to compute contrast and entropy. (center of the window is always in the pixel selected by x,y coordinates of the corresponding feature sample).
     /// </summary>
     public int WindowRadius
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetWindowRadius(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetWindowRadius(_ptr, value); }
     }
     
     /// <summary>
     /// Weights (multiplicative constants) that linearly stretch individual axes of the feature space. (x,y = position. L,a,b = color in CIE Lab space. c = contrast. e = entropy)
     /// </summary>
     public float WeightX
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetWeightX(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetWeightX(_ptr, value); }
     }
     
     /// <summary>
     /// Weights (multiplicative constants) that linearly stretch individual axes of the feature space. (x,y = position. L,a,b = color in CIE Lab space. c = contrast. e = entropy)
     /// </summary>
     public float WeightY
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetWeightY(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetWeightY(_ptr, value); }
     }
     
     /// <summary>
     /// Weights (multiplicative constants) that linearly stretch individual axes of the feature space. (x,y = position. L,a,b = color in CIE Lab space. c = contrast. e = entropy)
     /// </summary>
     public float WeightL
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetWeightL(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetWeightL(_ptr, value); }
     }
     
     /// <summary>
     /// Weights (multiplicative constants) that linearly stretch individual axes of the feature space. (x,y = position. L,a,b = color in CIE Lab space. c = contrast. e = entropy)
     /// </summary>
     public float WeightA
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetWeightA(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetWeightA(_ptr, value); }
     }
     
     /// <summary>
     /// Weights (multiplicative constants) that linearly stretch individual axes of the feature space. (x,y = position. L,a,b = color in CIE Lab space. c = contrast. e = entropy)
     /// </summary>
     public float WeightB
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetWeightB(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetWeightB(_ptr, value); }
     }
     
     /// <summary>
     /// Weights (multiplicative constants) that linearly stretch individual axes of the feature space. (x,y = position. L,a,b = color in CIE Lab space. c = contrast. e = entropy)
     /// </summary>
     public float WeightEntropy
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetWeightEntropy(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetWeightEntropy(_ptr, value); }
     }
     
     /// <summary>
     /// Number of iterations of the k-means clustering. We use fixed number of iterations, since the modified clustering is pruning clusters (not iteratively refining k clusters).
     /// </summary>
     public int IterationCount
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetIterationCount(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetIterationCount(_ptr, value); }
     }
     
     /// <summary>
     /// Maximal number of generated clusters. If the number is exceeded, the clusters are sorted by their weights and the smallest clusters are cropped.
     /// </summary>
     public int MaxClustersCount
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetMaxClustersCount(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetMaxClustersCount(_ptr, value); }
     }
     
     /// <summary>
     /// This parameter multiplied by the index of iteration gives lower limit for cluster size. Clusters containing fewer points than specified by the limit have their centroid dismissed and points are reassigned.
     /// </summary>
     public int ClusterMinSize
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetClusterMinSize(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetClusterMinSize(_ptr, value); }
     }
     
     /// <summary>
     /// Threshold euclidean distance between two centroids. If two cluster centers are closer than this distance, one of the centroid is dismissed and points are reassigned.
     /// </summary>
     public float JoiningDistance
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetJoiningDistance(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetJoiningDistance(_ptr, value); }
     }
     
     /// <summary>
     /// Remove centroids in k-means whose weight is lesser or equal to given threshold.
     /// </summary>
     public float DropThreshold
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetDropThreshold(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetDropThreshold(_ptr, value); }
     }
     
     /// <summary>
     /// Distance function selector used for measuring distance between two points in k-means.
     /// </summary>
     public PCTSignatures.PointDistributionType DistanceFunction
     {
        get { return XFeatures2DInvoke.cvePCTSignaturesGetDistanceFunction(_ptr); } 
        set { XFeatures2DInvoke.cvePCTSignaturesSetDistanceFunction(_ptr, value); }
     }
     
   }
}
