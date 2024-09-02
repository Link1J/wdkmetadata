using System;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation.Metadata;

namespace Windows.Wdk.Networking.WinSock;

public static unsafe partial class Apis
{
    public const uint IOC_INOUT = 0x80000000 | 0x40000000;
    public const uint IOC_WSK = 0x80000000 | 0x07000000;
}

// The dispatcher for WSK_SOCKET is a `const void*`, when really it is a pointer to one of these
// This type is just for making it easier to use.
[StructLayout(LayoutKind.Explicit)]
public struct WSK_PROVIDER_SOCKET_DISPATCH
{
    [FieldOffset(0)]
    public WSK_PROVIDER_BASIC_DISPATCH Basic;
    [FieldOffset(0)]
    public WSK_PROVIDER_LISTEN_DISPATCH Listen;
    [FieldOffset(0)]
    public WSK_PROVIDER_DATAGRAM_DISPATCH Datagram;
    [FieldOffset(0)]
    public WSK_PROVIDER_CONNECTION_DISPATCH Connection;
    [FieldOffset(0)]
    public WSK_PROVIDER_STREAM_DISPATCH Stream;
}