//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class StatBeatDetection : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StatBeatDetection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StatBeatDetection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StatBeatDetection() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libwavPINVOKE.delete_StatBeatDetection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public StatBeatDetection(Wave wave, ulong hnsPrecision, ulong hnsBufferDuration) : this(libwavPINVOKE.new_StatBeatDetection__SWIG_0(Wave.getCPtr(wave), hnsPrecision, hnsBufferDuration), true) {
    if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
  }

  public StatBeatDetection(Wave wave, ulong hnsPrecision) : this(libwavPINVOKE.new_StatBeatDetection__SWIG_1(Wave.getCPtr(wave), hnsPrecision), true) {
    if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
  }

  public StatBeatDetection(Wave wave) : this(libwavPINVOKE.new_StatBeatDetection__SWIG_2(Wave.getCPtr(wave)), true) {
    if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
  }

  public void release() {
    libwavPINVOKE.StatBeatDetection_release(swigCPtr);
    if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int length() {
    int ret = libwavPINVOKE.StatBeatDetection_length(swigCPtr);
    if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasNext() {
    bool ret = libwavPINVOKE.StatBeatDetection_hasNext(swigCPtr);
    if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double next() {
    double ret = libwavPINVOKE.StatBeatDetection_next(swigCPtr);
    if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getPrecision() {
    int ret = libwavPINVOKE.StatBeatDetection_getPrecision(swigCPtr);
    if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
