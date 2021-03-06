// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

//------------------------------------------------------------------------------
// <auto-generated>
//     Types declaration for CorApi.Portable.Win32 namespace.
//     This code was generated by a tool.
//     Date : 11/05/2017 11:23:37
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
#if true
namespace CorApi.Portable.Win32 {

// Disable warning : XML comment is not placed on a valid language element
#pragma warning disable 419
#pragma warning disable 1587
#pragma warning disable 1574
    /// <summary>	
    /// No documentation.	
    /// </summary>	
    /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream']/*"/>	
    /// <unmanaged>IStream</unmanaged>	
    /// <unmanaged-short>IStream</unmanaged-short>	
    [Guid("0000000c-0000-0000-C000-000000000046")]
    public partial class ComStream : CorApi.Portable.Win32.ComStreamBase, CorApi.Portable.Win32.IStream {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorApi.Portable.Win32.ComStream"/> class.
        /// </summary>
        /// <param name="nativePtr">The native pointer.</param>	
        public ComStream(IntPtr nativePtr) : base(nativePtr) {
        }

		/// <summary>
		/// Performs an explicit conversion from <see cref="System.IntPtr"/> to <see cref="CorApi.Portable.Win32.ComStream"/>. (This method is a shortcut to <see cref="SharpDX.CppObject.NativePointer"/>) 
		/// </summary>
		/// <param name="nativePointer">The native pointer.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static explicit operator CorApi.Portable.Win32.ComStream(IntPtr nativePointer)
		{
			return nativePointer == IntPtr.Zero ? null : new CorApi.Portable.Win32.ComStream(nativePointer);
		}
        
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="dlibMove">No documentation.</param>	
        /// <param name="dwOrigin">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::Seek']/*"/>	
        /// <unmanaged>HRESULT IStream::Seek([In] LARGE_INTEGER dlibMove,[In] SHARPDX_SEEKORIGIN dwOrigin,[Out, Optional] ULARGE_INTEGER* plibNewPosition)</unmanaged>	
        /// <unmanaged-short>IStream::Seek</unmanaged-short>	
        public long Seek(long dlibMove, System.IO.SeekOrigin dwOrigin) {
            unsafe {
                long libNewPositionRef;
                SharpDX.Result __result__;
                __result__= 
				CorDebug.LocalInterop.Calliint(_nativePointer, dlibMove, unchecked((int)dwOrigin), &libNewPositionRef,((void**)(*(void**)_nativePointer))[5]);		
                __result__.CheckError();
                return libNewPositionRef;
            }
        }
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="libNewSize">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::SetSize']/*"/>	
        /// <unmanaged>HRESULT IStream::SetSize([In] ULARGE_INTEGER libNewSize)</unmanaged>	
        /// <unmanaged-short>IStream::SetSize</unmanaged-short>	
        public void SetSize(long libNewSize) {
            unsafe {
                SharpDX.Result __result__;
                __result__= 
				CorDebug.LocalInterop.Calliint(_nativePointer, libNewSize,((void**)(*(void**)_nativePointer))[6]);		
                __result__.CheckError();
            }
        }
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="stmRef">No documentation.</param>	
        /// <param name="cb">No documentation.</param>	
        /// <param name="cbWrittenRef">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::CopyTo']/*"/>	
        /// <unmanaged>HRESULT IStream::CopyTo([In] IStream* pstm,[In] ULARGE_INTEGER cb,[Out] ULARGE_INTEGER* pcbRead,[Out] ULARGE_INTEGER* pcbWritten)</unmanaged>	
        /// <unmanaged-short>IStream::CopyTo</unmanaged-short>	
        internal long CopyTo_(System.IntPtr stmRef, long cb, out long cbWrittenRef) {
            unsafe {
                long cbReadRef;
                SharpDX.Result __result__;
                fixed (void* cbWrittenRef_ = &cbWrittenRef)
                    __result__= 
    				CorDebug.LocalInterop.Calliint(_nativePointer, (void*)stmRef, cb, &cbReadRef, cbWrittenRef_,((void**)(*(void**)_nativePointer))[7]);		
                __result__.CheckError();
                return cbReadRef;
            }
        }
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="grfCommitFlags">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::Commit']/*"/>	
        /// <unmanaged>HRESULT IStream::Commit([In] STGC grfCommitFlags)</unmanaged>	
        /// <unmanaged-short>IStream::Commit</unmanaged-short>	
        public void Commit(CorApi.Portable.Win32.CommitFlags grfCommitFlags) {
            unsafe {
                SharpDX.Result __result__;
                __result__= 
				CorDebug.LocalInterop.Calliint(_nativePointer, unchecked((int)grfCommitFlags),((void**)(*(void**)_nativePointer))[8]);		
                __result__.CheckError();
            }
        }
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::Revert']/*"/>	
        /// <unmanaged>HRESULT IStream::Revert()</unmanaged>	
        /// <unmanaged-short>IStream::Revert</unmanaged-short>	
        public void Revert() {
            unsafe {
                SharpDX.Result __result__;
                __result__= 
				CorDebug.LocalInterop.Calliint(_nativePointer,((void**)(*(void**)_nativePointer))[9]);		
                __result__.CheckError();
            }
        }
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="libOffset">No documentation.</param>	
        /// <param name="cb">No documentation.</param>	
        /// <param name="dwLockType">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::LockRegion']/*"/>	
        /// <unmanaged>HRESULT IStream::LockRegion([In] ULARGE_INTEGER libOffset,[In] ULARGE_INTEGER cb,[In] LOCKTYPE dwLockType)</unmanaged>	
        /// <unmanaged-short>IStream::LockRegion</unmanaged-short>	
        public void LockRegion(long libOffset, long cb, CorApi.Portable.Win32.LockType dwLockType) {
            unsafe {
                SharpDX.Result __result__;
                __result__= 
				CorDebug.LocalInterop.Calliint(_nativePointer, libOffset, cb, unchecked((int)dwLockType),((void**)(*(void**)_nativePointer))[10]);		
                __result__.CheckError();
            }
        }
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="libOffset">No documentation.</param>	
        /// <param name="cb">No documentation.</param>	
        /// <param name="dwLockType">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::UnlockRegion']/*"/>	
        /// <unmanaged>HRESULT IStream::UnlockRegion([In] ULARGE_INTEGER libOffset,[In] ULARGE_INTEGER cb,[In] LOCKTYPE dwLockType)</unmanaged>	
        /// <unmanaged-short>IStream::UnlockRegion</unmanaged-short>	
        public void UnlockRegion(long libOffset, long cb, CorApi.Portable.Win32.LockType dwLockType) {
            unsafe {
                SharpDX.Result __result__;
                __result__= 
				CorDebug.LocalInterop.Calliint(_nativePointer, libOffset, cb, unchecked((int)dwLockType),((void**)(*(void**)_nativePointer))[11]);		
                __result__.CheckError();
            }
        }
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="grfStatFlag">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::Stat']/*"/>	
        /// <unmanaged>HRESULT IStream::Stat([Out] STATSTG* pstatstg,[In] STATFLAG grfStatFlag)</unmanaged>	
        /// <unmanaged-short>IStream::Stat</unmanaged-short>	
        public CorApi.Portable.Win32.StorageStatistics GetStatistics(CorApi.Portable.Win32.StorageStatisticsFlags grfStatFlag) {
            unsafe {
                CorApi.Portable.Win32.StorageStatistics statstgRef;
                var statstgRef_ = new CorApi.Portable.Win32.StorageStatistics.__Native();
                SharpDX.Result __result__;
                __result__= 
				CorDebug.LocalInterop.Calliint(_nativePointer, &statstgRef_, unchecked((int)grfStatFlag),((void**)(*(void**)_nativePointer))[12]);		
                statstgRef = new CorApi.Portable.Win32.StorageStatistics();
                statstgRef.__MarshalFrom(ref statstgRef_);
                __result__.CheckError();
                return statstgRef;
            }
        }
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::Clone']/*"/>	
        /// <unmanaged>HRESULT IStream::Clone([Out] IStream** ppstm)</unmanaged>	
        /// <unmanaged-short>IStream::Clone</unmanaged-short>	
        public CorApi.Portable.Win32.IStream Clone() {
            unsafe {
                CorApi.Portable.Win32.IStream stmOut;
                IntPtr stmOut_ = IntPtr.Zero;
                SharpDX.Result __result__;
                __result__= 
				CorDebug.LocalInterop.Calliint(_nativePointer, &stmOut_,((void**)(*(void**)_nativePointer))[13]);		
                stmOut= (stmOut_ == IntPtr.Zero)?null:new CorApi.Portable.Win32.ComStream(stmOut_);	
                __result__.CheckError();
                return stmOut;
            }
        }
    }
    /// <summary>	
    /// No documentation.	
    /// </summary>	
    /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='ISequentialStream']/*"/>	
    /// <unmanaged>ISequentialStream</unmanaged>	
    /// <unmanaged-short>ISequentialStream</unmanaged-short>	
    [Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d")]
    public partial class ComStreamBase : SharpDX.ComObjectCallback, CorApi.Portable.Win32.IStreamBase {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorApi.Portable.Win32.ComStreamBase"/> class.
        /// </summary>
        /// <param name="nativePtr">The native pointer.</param>	
        public ComStreamBase(IntPtr nativePtr) : base(nativePtr) {
        }

		/// <summary>
		/// Performs an explicit conversion from <see cref="System.IntPtr"/> to <see cref="CorApi.Portable.Win32.ComStreamBase"/>. (This method is a shortcut to <see cref="SharpDX.CppObject.NativePointer"/>) 
		/// </summary>
		/// <param name="nativePointer">The native pointer.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static explicit operator CorApi.Portable.Win32.ComStreamBase(IntPtr nativePointer)
		{
			return nativePointer == IntPtr.Zero ? null : new CorApi.Portable.Win32.ComStreamBase(nativePointer);
		}
        
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="vRef">No documentation.</param>	
        /// <param name="cb">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='ISequentialStream::Read']/*"/>	
        /// <unmanaged>HRESULT ISequentialStream::Read([Out, Buffer] void* pv,[In] unsigned int cb,[Out, Optional] unsigned int* pcbRead)</unmanaged>	
        /// <unmanaged-short>ISequentialStream::Read</unmanaged-short>	
        public int Read(System.IntPtr vRef, int cb) {
            unsafe {
                int cbReadRef;
                SharpDX.Result __result__;
                __result__= 
				CorDebug.LocalInterop.Calliint(_nativePointer, (void*)vRef, cb, &cbReadRef,((void**)(*(void**)_nativePointer))[3]);		
                __result__.CheckError();
                return cbReadRef;
            }
        }
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="vRef">No documentation.</param>	
        /// <param name="cb">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='ISequentialStream::Write']/*"/>	
        /// <unmanaged>HRESULT ISequentialStream::Write([In, Buffer] const void* pv,[In] unsigned int cb,[Out, Optional] unsigned int* pcbWritten)</unmanaged>	
        /// <unmanaged-short>ISequentialStream::Write</unmanaged-short>	
        public int Write(System.IntPtr vRef, int cb) {
            unsafe {
                int cbWrittenRef;
                SharpDX.Result __result__;
                __result__= 
				CorDebug.LocalInterop.Calliint(_nativePointer, (void*)vRef, cb, &cbWrittenRef,((void**)(*(void**)_nativePointer))[4]);		
                __result__.CheckError();
                return cbWrittenRef;
            }
        }
    }
    /// <summary>	
    /// No documentation.	
    /// </summary>	
    /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream']/*"/>	
    /// <unmanaged>IStream</unmanaged>	
    /// <unmanaged-short>IStream</unmanaged-short>	
    [Guid("0000000c-0000-0000-C000-000000000046")]
    public partial interface IStream : CorApi.Portable.Win32.IStreamBase {
        
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="dlibMove">No documentation.</param>	
        /// <param name="dwOrigin">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::Seek']/*"/>	
        /// <unmanaged>HRESULT IStream::Seek([In] LARGE_INTEGER dlibMove,[In] SHARPDX_SEEKORIGIN dwOrigin,[Out, Optional] ULARGE_INTEGER* plibNewPosition)</unmanaged>	
        /// <unmanaged-short>IStream::Seek</unmanaged-short>	
        /* public long Seek(long dlibMove, System.IO.SeekOrigin dwOrigin) */
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="libNewSize">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::SetSize']/*"/>	
        /// <unmanaged>HRESULT IStream::SetSize([In] ULARGE_INTEGER libNewSize)</unmanaged>	
        /// <unmanaged-short>IStream::SetSize</unmanaged-short>	
        /* public void SetSize(long libNewSize) */
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="stmRef">No documentation.</param>	
        /// <param name="cb">No documentation.</param>	
        /// <param name="cbWrittenRef">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::CopyTo']/*"/>	
        /// <unmanaged>HRESULT IStream::CopyTo([In] IStream* pstm,[In] ULARGE_INTEGER cb,[Out] ULARGE_INTEGER* pcbRead,[Out] ULARGE_INTEGER* pcbWritten)</unmanaged>	
        /// <unmanaged-short>IStream::CopyTo</unmanaged-short>	
        /* internal long CopyTo_(System.IntPtr stmRef, long cb, out long cbWrittenRef) */
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="grfCommitFlags">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::Commit']/*"/>	
        /// <unmanaged>HRESULT IStream::Commit([In] STGC grfCommitFlags)</unmanaged>	
        /// <unmanaged-short>IStream::Commit</unmanaged-short>	
        /* public void Commit(CorApi.Portable.Win32.CommitFlags grfCommitFlags) */
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::Revert']/*"/>	
        /// <unmanaged>HRESULT IStream::Revert()</unmanaged>	
        /// <unmanaged-short>IStream::Revert</unmanaged-short>	
        /* public void Revert() */
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="libOffset">No documentation.</param>	
        /// <param name="cb">No documentation.</param>	
        /// <param name="dwLockType">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::LockRegion']/*"/>	
        /// <unmanaged>HRESULT IStream::LockRegion([In] ULARGE_INTEGER libOffset,[In] ULARGE_INTEGER cb,[In] LOCKTYPE dwLockType)</unmanaged>	
        /// <unmanaged-short>IStream::LockRegion</unmanaged-short>	
        /* public void LockRegion(long libOffset, long cb, CorApi.Portable.Win32.LockType dwLockType) */
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="libOffset">No documentation.</param>	
        /// <param name="cb">No documentation.</param>	
        /// <param name="dwLockType">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::UnlockRegion']/*"/>	
        /// <unmanaged>HRESULT IStream::UnlockRegion([In] ULARGE_INTEGER libOffset,[In] ULARGE_INTEGER cb,[In] LOCKTYPE dwLockType)</unmanaged>	
        /// <unmanaged-short>IStream::UnlockRegion</unmanaged-short>	
        /* public void UnlockRegion(long libOffset, long cb, CorApi.Portable.Win32.LockType dwLockType) */
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="grfStatFlag">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::Stat']/*"/>	
        /// <unmanaged>HRESULT IStream::Stat([Out] STATSTG* pstatstg,[In] STATFLAG grfStatFlag)</unmanaged>	
        /// <unmanaged-short>IStream::Stat</unmanaged-short>	
        /* public CorApi.Portable.Win32.StorageStatistics GetStatistics(CorApi.Portable.Win32.StorageStatisticsFlags grfStatFlag) */
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='IStream::Clone']/*"/>	
        /// <unmanaged>HRESULT IStream::Clone([Out] IStream** ppstm)</unmanaged>	
        /// <unmanaged-short>IStream::Clone</unmanaged-short>	
        /* public CorApi.Portable.Win32.IStream Clone() */
    }
    /// <summary>	
    /// No documentation.	
    /// </summary>	
    /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='ISequentialStream']/*"/>	
    /// <unmanaged>ISequentialStream</unmanaged>	
    /// <unmanaged-short>ISequentialStream</unmanaged-short>	
    [Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d")]
    public partial interface IStreamBase : SharpDX.ICallbackable {
        
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="vRef">No documentation.</param>	
        /// <param name="cb">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='ISequentialStream::Read']/*"/>	
        /// <unmanaged>HRESULT ISequentialStream::Read([Out, Buffer] void* pv,[In] unsigned int cb,[Out, Optional] unsigned int* pcbRead)</unmanaged>	
        /// <unmanaged-short>ISequentialStream::Read</unmanaged-short>	
        /* public int Read(System.IntPtr vRef, int cb) */
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <param name="vRef">No documentation.</param>	
        /// <param name="cb">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='ISequentialStream::Write']/*"/>	
        /// <unmanaged>HRESULT ISequentialStream::Write([In, Buffer] const void* pv,[In] unsigned int cb,[Out, Optional] unsigned int* pcbWritten)</unmanaged>	
        /// <unmanaged-short>ISequentialStream::Write</unmanaged-short>	
        /* public int Write(System.IntPtr vRef, int cb) */
    }
}

#endif
