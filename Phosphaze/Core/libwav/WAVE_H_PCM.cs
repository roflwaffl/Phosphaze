//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class WAVE_H_PCM : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal WAVE_H_PCM(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(WAVE_H_PCM obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~WAVE_H_PCM() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libwavPINVOKE.delete_WAVE_H_PCM(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public WAVE_H header {
    set {
      libwavPINVOKE.WAVE_H_PCM_header_set(swigCPtr, WAVE_H.getCPtr(value));
      if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = libwavPINVOKE.WAVE_H_PCM_header_get(swigCPtr);
      WAVE_H ret = (cPtr == global::System.IntPtr.Zero) ? null : new WAVE_H(cPtr, false);
      if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public WAVE_CHUNK chunks {
    set {
      libwavPINVOKE.WAVE_H_PCM_chunks_set(swigCPtr, WAVE_CHUNK.getCPtr(value));
      if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = libwavPINVOKE.WAVE_H_PCM_chunks_get(swigCPtr);
      WAVE_CHUNK ret = (cPtr == global::System.IntPtr.Zero) ? null : new WAVE_CHUNK(cPtr, false);
      if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public WAVE_H_PCM() : this(libwavPINVOKE.new_WAVE_H_PCM(), true) {
    if (libwavPINVOKE.SWIGPendingException.Pending) throw libwavPINVOKE.SWIGPendingException.Retrieve();
  }

}
