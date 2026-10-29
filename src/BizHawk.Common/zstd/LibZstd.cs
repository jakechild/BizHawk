using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BizHawk.Common
{
    public static unsafe class LibZstd
    {
        static LibZstd()
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7ebc71ca-4dfc-487c-9a5d-085d165485b0" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            var resolver = new DynamicLibraryImportResolver(OSTailoredCode.IsUnixHost ? "libzstd.so.1" : "libzstd.dll", hasLimitedLifetime: false);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e0059c30-e5f1-4e1b-b2be-9927caa8483a" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_isError = (delegate* unmanaged[Cdecl]<nuint, uint> )resolver.GetProcAddrOrThrow(nameof(ZSTD_isError));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "40feee19-073c-4d4b-bea2-6d067c5e407a" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_getErrorName = (delegate* unmanaged[Cdecl]<nuint, IntPtr> )resolver.GetProcAddrOrThrow(nameof(ZSTD_getErrorName));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4bba357b-4edc-4184-acaa-6a21aa2605a7" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_minCLevel = (delegate* unmanaged[Cdecl]<int> )resolver.GetProcAddrOrThrow(nameof(ZSTD_minCLevel));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "dfbef508-b524-46df-ae5b-b3072bc4bc8a" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_maxCLevel = (delegate* unmanaged[Cdecl]<int> )resolver.GetProcAddrOrThrow(nameof(ZSTD_maxCLevel));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b2407bf8-807b-43ac-a046-375886fb550e" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_createCStream = (delegate* unmanaged[Cdecl]<IntPtr> )resolver.GetProcAddrOrThrow(nameof(ZSTD_createCStream));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fbeb0871-eb36-4514-9cbd-887e241f5814" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_freeCStream = (delegate* unmanaged[Cdecl]<IntPtr, nuint> )resolver.GetProcAddrOrThrow(nameof(ZSTD_freeCStream));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "400b0141-85a4-4cc5-94e4-982699dae1cd" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_initCStream = (delegate* unmanaged[Cdecl]<IntPtr, int, nuint> )resolver.GetProcAddrOrThrow(nameof(ZSTD_initCStream));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1e712c73-c68c-4df9-b998-76689e2f5f45" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_compressStream = (delegate* unmanaged[Cdecl]<IntPtr, StreamBuffer*, StreamBuffer*, nuint> )resolver.GetProcAddrOrThrow(nameof(ZSTD_compressStream));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "03b499e4-b6f9-4373-a36e-4893bf689a14" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_flushStream = (delegate* unmanaged[Cdecl]<IntPtr, StreamBuffer*, nuint> )resolver.GetProcAddrOrThrow(nameof(ZSTD_flushStream));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "eefc1a5c-100f-47da-901a-9dd55baa0a67" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_endStream = (delegate* unmanaged[Cdecl]<IntPtr, StreamBuffer*, nuint> )resolver.GetProcAddrOrThrow(nameof(ZSTD_endStream));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "154488a1-2b86-497f-8d2f-1f4e69aa3de8" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_createDStream = (delegate* unmanaged[Cdecl]<IntPtr> )resolver.GetProcAddrOrThrow(nameof(ZSTD_createDStream));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2b59df6b-482c-4949-a611-9853e02e8e0a" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_freeDStream = (delegate* unmanaged[Cdecl]<IntPtr, nuint> )resolver.GetProcAddrOrThrow(nameof(ZSTD_freeDStream));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e5de66f2-c4ed-4fd3-9ea5-234b79652b52" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_initDStream = (delegate* unmanaged[Cdecl]<IntPtr, nuint> )resolver.GetProcAddrOrThrow(nameof(ZSTD_initDStream));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4df534fb-8d0a-4c3c-a94a-2702968558ae" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            ZSTD_decompressStream = (delegate* unmanaged[Cdecl]<IntPtr, StreamBuffer*, StreamBuffer*, nuint> )resolver.GetProcAddrOrThrow(nameof(ZSTD_decompressStream));
        }

        private static readonly delegate* unmanaged[Cdecl]<nuint, uint> ZSTD_isError;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint IsError(nuint code) => ZSTD_isError(code);
        private static readonly delegate* unmanaged[Cdecl]<nuint, IntPtr> ZSTD_getErrorName;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntPtr GetErrorName(nuint code) => ZSTD_getErrorName(code);
        private static readonly delegate* unmanaged[Cdecl]<int> ZSTD_minCLevel;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MinCLevel() => ZSTD_minCLevel();
        private static readonly delegate* unmanaged[Cdecl]<int> ZSTD_maxCLevel;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MaxCLevel() => ZSTD_maxCLevel();
        [StructLayout(LayoutKind.Sequential)]
        public struct StreamBuffer
        {
            public IntPtr Ptr;
            public nuint Size;
            public nuint Pos;
        }

        private static readonly delegate* unmanaged[Cdecl]<IntPtr> ZSTD_createCStream;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntPtr CreateCStream() => ZSTD_createCStream();
        private static readonly delegate* unmanaged[Cdecl]<IntPtr, nuint> ZSTD_freeCStream;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint FreeCStream(IntPtr zcs) => ZSTD_freeCStream(zcs);
        private static readonly delegate* unmanaged[Cdecl]<IntPtr, int, nuint> ZSTD_initCStream;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint InitCStream(IntPtr zcs, int compressionLevel) => ZSTD_initCStream(zcs, compressionLevel);
        private static readonly delegate* unmanaged[Cdecl]<IntPtr, StreamBuffer*, StreamBuffer*, nuint> ZSTD_compressStream;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint CompressStream(IntPtr zcs, ref StreamBuffer output, ref StreamBuffer input)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "20dda415-1e63-4ae4-b4f7-bb8c43ee3a68" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            fixed (StreamBuffer* outputPtr = &output, inputPtr = &input)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b286886a-1aca-4b83-b1b3-dbb0614f5ea8" + System.Environment.NewLine);
                        }
                        catch
                        {
                        }
                        finally
                        {
                            m.ReleaseMutex();
                        }
                    }
                })();
                return ZSTD_compressStream(zcs, outputPtr, inputPtr);
            }
        }

        private static readonly delegate* unmanaged[Cdecl]<IntPtr, StreamBuffer*, nuint> ZSTD_flushStream;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint FlushStream(IntPtr zcs, ref StreamBuffer output)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7729f8ef-f688-48ca-983d-4836342a150a" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            fixed (StreamBuffer* outputPtr = &output)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f2562a33-2a3c-4469-abf1-6d179b79f324" + System.Environment.NewLine);
                        }
                        catch
                        {
                        }
                        finally
                        {
                            m.ReleaseMutex();
                        }
                    }
                })();
                return ZSTD_flushStream(zcs, outputPtr);
            }
        }

        private static readonly delegate* unmanaged[Cdecl]<IntPtr, StreamBuffer*, nuint> ZSTD_endStream;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint EndStream(IntPtr zcs, ref StreamBuffer output)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "83a7316d-3394-44b3-993f-c1564495ebbe" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            fixed (StreamBuffer* outputPtr = &output)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6a6245a2-ac52-49e6-9549-028202fbe9a6" + System.Environment.NewLine);
                        }
                        catch
                        {
                        }
                        finally
                        {
                            m.ReleaseMutex();
                        }
                    }
                })();
                return ZSTD_endStream(zcs, outputPtr);
            }
        }

        private static readonly delegate* unmanaged[Cdecl]<IntPtr> ZSTD_createDStream;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntPtr CreateDStream() => ZSTD_createDStream();
        private static readonly delegate* unmanaged[Cdecl]<IntPtr, nuint> ZSTD_freeDStream;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint FreeDStream(IntPtr zds) => ZSTD_freeDStream(zds);
        private static readonly delegate* unmanaged[Cdecl]<IntPtr, nuint> ZSTD_initDStream;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint InitDStream(IntPtr zds) => ZSTD_initDStream(zds);
        private static readonly delegate* unmanaged[Cdecl]<IntPtr, StreamBuffer*, StreamBuffer*, nuint> ZSTD_decompressStream;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint DecompressStream(IntPtr zds, ref StreamBuffer output, ref StreamBuffer input)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f96ec50f-61ec-40c1-b15e-36a968ecbc8b" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            fixed (StreamBuffer* outputPtr = &output, inputPtr = &input)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "44c06a96-93ef-4d8f-95f6-5cf4be8f0855" + System.Environment.NewLine);
                        }
                        catch
                        {
                        }
                        finally
                        {
                            m.ReleaseMutex();
                        }
                    }
                })();
                return ZSTD_decompressStream(zds, outputPtr, inputPtr);
            }
        }
    }
}