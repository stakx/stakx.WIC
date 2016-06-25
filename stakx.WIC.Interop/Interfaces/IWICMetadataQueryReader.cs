﻿using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICMetadataQueryReader)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICMetadataQueryReader
    {
        void GetContainerFormat(
            [Out] out Guid pguidContainerFormat);

        void GetLocation(
            [In] int cchMaxLength,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzNamespace,
            [Out] out int pcchActualLength);

        void GetMetadataByName(
            [In, MarshalAs(UnmanagedType.LPWStr)] string wzName,
            [In, Out, MarshalAs(UnmanagedType.Struct)] ref PROPVARIANT pvarValue);

        void GetEnumerator(
            [Out] out IEnumString ppIEnumString);
    }
}