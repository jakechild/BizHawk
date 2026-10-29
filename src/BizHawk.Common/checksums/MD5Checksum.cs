using System.Diagnostics;
using System.Security.Cryptography;
using BizHawk.Common.BufferExtensions;

namespace BizHawk.Common
{
    /// <summary>uses <see cref="MD5"/> implementation from BCL</summary>
    /// <seealso cref="CRC32Checksum"/>
    /// <seealso cref="SHA1Checksum"/>
    /// <seealso cref="SHA256Checksum"/>
    /// <seealso cref="SHA512Checksum"/>
    public static class MD5Checksum
    {
        /// <remarks>in bits</remarks>
        internal const int EXPECTED_LENGTH = 128;
        public const string PREFIX = "MD5";
        public /*static readonly*/ const string Dummy = "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE";
        public /*static readonly*/ const string EmptyFile = "D41D8CD98F00B204E9800998ECF8427E";
#if NET5_0_OR_GREATER
		public static byte[] Compute(ReadOnlySpan<byte> data)
			=> MD5.HashData(data);
#else
        private static MD5? _md5Impl;
        private static MD5 MD5Impl
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
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e64922eb-4db0-40fe-ad04-655f21706f9d" + System.Environment.NewLine);
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
                if (_md5Impl == null)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f742cdac-7767-4247-87b0-4d5a18952b18" + System.Environment.NewLine);
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
                    _md5Impl = MD5.Create();
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ef466345-5e42-4aeb-a30e-b7300be38151" + System.Environment.NewLine);
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
                    Debug.Assert(_md5Impl.CanReuseTransform && _md5Impl.HashSize is EXPECTED_LENGTH, "nonstandard implementation?");
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "794ab553-e5a2-4a32-88f1-418a4a63ff74" + System.Environment.NewLine);
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
                return _md5Impl;
            }
        }

        public static byte[] Compute(byte[] data) => MD5Impl.ComputeHash(data);
        public static string ComputeDigestHex(byte[] data) => Compute(data).BytesToHexString();
        public static string ComputePrefixedHex(byte[] data) => $"{PREFIX}:{ComputeDigestHex(data)}";
        public static byte[] Compute(ReadOnlySpan<byte> data) => Compute(data.ToArray());
#endif
        public static string ComputeDigestHex(ReadOnlySpan<byte> data) => Compute(data).BytesToHexString();
        public static string ComputePrefixedHex(ReadOnlySpan<byte> data) => $"{PREFIX}:{ComputeDigestHex(data)}";
    }
}