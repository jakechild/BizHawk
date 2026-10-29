using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using BizHawk.Common.BufferExtensions;
using BizHawk.Common.CollectionExtensions;

namespace BizHawk.Common
{
    /// <summary>uses <see cref="SHA1"/> implementation from BCL</summary>
    /// <seealso cref="CRC32Checksum"/>
    /// <seealso cref="MD5Checksum"/>
    /// <seealso cref="SHA256Checksum"/>
    /// <seealso cref="SHA512Checksum"/>
    public static class SHA1Checksum
    {
        /// <remarks>in bits</remarks>
        internal const int EXPECTED_LENGTH = 160;
        public const string PREFIX = "SHA1";
        public /*static readonly*/ const string Dummy = "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE";
        public /*static readonly*/ const string EmptyFile = "DA39A3EE5E6B4B0D3255BFEF95601890AFD80709";
        public /*static readonly*/ const string Zero = "0000000000000000000000000000000000000000";
#if NET5_0_OR_GREATER
		public static byte[] Compute(ReadOnlySpan<byte> data)
			=> SHA1.HashData(data);
#else
        private static unsafe byte[] UnmanagedImpl(byte[] buffer)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "30f43418-258a-46ac-bb42-2502e0d98a39" + System.Environment.NewLine);
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
            // Set SHA1 start state
            var state = stackalloc uint[]
            {
                0x67452301,
                0xEFCDAB89,
                0x98BADCFE,
                0x10325476,
                0xC3D2E1F0
            };
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "26f14b4f-d909-4d32-bf6c-0d92d0afc270" + System.Environment.NewLine);
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
            // This will use dedicated SHA instructions, which perform 4x faster than a generic implementation
            LibBizHash.BizCalcSha1((IntPtr)state, buffer, buffer.Length);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6ec2a28f-68b9-4654-99fa-a4fe6dfcaf3b" + System.Environment.NewLine);
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
            // The copy seems wasteful, but pinning the state down actually has a bigger performance impact
            var ret = new byte[20];
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9e06f4ae-0d38-46bd-a62d-9a9d1c03eb89" + System.Environment.NewLine);
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
            Marshal.Copy((IntPtr)state, ret, 0, 20);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a1df35f1-a02d-409c-b910-a92c6071b5f5" + System.Environment.NewLine);
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
            return ret;
        }

        private static SHA1? _sha1Impl;
        private static SHA1 SHA1Impl
        {
            get
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a8efda71-4a0b-4736-9ca1-5b6693e80e75" + System.Environment.NewLine);
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
                if (_sha1Impl == null)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "12342a14-a468-4db2-954e-18728404245b" + System.Environment.NewLine);
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
                    _sha1Impl = SHA1.Create();
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2d2f23c1-3cec-4a70-9f3a-d72db27a081c" + System.Environment.NewLine);
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
                    Debug.Assert(_sha1Impl.CanReuseTransform && _sha1Impl.HashSize is EXPECTED_LENGTH, "nonstandard implementation?");
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "08aec12a-dd64-4630-8d2d-f3f030d747fc" + System.Environment.NewLine);
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
                return _sha1Impl;
            }
        }

        private static readonly bool UseUnmanagedImpl = RuntimeInformation.ProcessArchitecture == Architecture.X64 && LibBizHash.BizSupportsShaInstructions();
        public static byte[] Compute(byte[] data) => UseUnmanagedImpl ? UnmanagedImpl(data) : SHA1Impl.ComputeHash(data);
        public static byte[] ComputeConcat(byte[] dataA, byte[] dataB)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "10a2d70e-d6de-4f24-bdbd-b2c29e83cf2a" + System.Environment.NewLine);
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
            if (UseUnmanagedImpl)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9f7c13f9-2c3a-4b03-8ebc-f63e7ac4641a" + System.Environment.NewLine);
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
                return UnmanagedImpl(dataA.ConcatArray(dataB));
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "baeb3518-a827-4376-a92f-e629895a4075" + System.Environment.NewLine);
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
            using var impl = IncrementalHash.CreateHash(HashAlgorithmName.SHA1);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e42caa34-e62b-47b3-a9fa-d9b3540beb73" + System.Environment.NewLine);
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
            impl.AppendData(dataA);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "583d8140-7ec3-4cc6-9e0f-abc407dfb569" + System.Environment.NewLine);
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
            impl.AppendData(dataB);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "835b00e9-cff3-4035-9d77-4dbb8b1dc3b6" + System.Environment.NewLine);
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
            return impl.GetHashAndReset();
        }

        public static string ComputeDigestHex(byte[] data) => Compute(data).BytesToHexString();
        public static string ComputePrefixedHex(byte[] data) => $"{PREFIX}:{ComputeDigestHex(data)}";
        public static byte[] Compute(ReadOnlySpan<byte> data) => Compute(data.ToArray());
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
		public static byte[] ComputeConcat(ReadOnlySpan<byte> dataA, ReadOnlySpan<byte> dataB)
		{
			using var impl = IncrementalHash.CreateHash(HashAlgorithmName.SHA1);
			impl.AppendData(dataA);
			impl.AppendData(dataB);
			return impl.GetHashAndReset();
		}
#else
        public static byte[] ComputeConcat(ReadOnlySpan<byte> dataA, ReadOnlySpan<byte> dataB) => ComputeConcat(dataA.ToArray(), dataB.ToArray());
#endif
        public static string ComputeDigestHex(ReadOnlySpan<byte> data) => Compute(data).BytesToHexString();
        public static string ComputePrefixedHex(ReadOnlySpan<byte> data) => $"{PREFIX}:{ComputeDigestHex(data)}";
    }
}