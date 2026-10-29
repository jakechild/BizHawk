using System.Diagnostics;
using System.Security.Cryptography;
using BizHawk.Common.BufferExtensions;

namespace BizHawk.Common
{
    /// <summary>uses <see cref="SHA512"/> implementation from BCL</summary>
    /// <seealso cref="CRC32Checksum"/>
    /// <seealso cref="MD5Checksum"/>
    /// <seealso cref="SHA1Checksum"/>
    /// <seealso cref="SHA256Checksum"/>
    public static class SHA512Checksum
    {
        /// <remarks>in bits</remarks>
        internal const int EXPECTED_LENGTH = 512;
        internal const string PREFIX = "SHA512";
#if NET7_0_OR_GREATER
		public static byte[] Compute(ReadOnlySpan<byte> data)
			=> SHA512.HashData(data);
#else
        private static SHA512? _sha512Impl;
        private static SHA512 SHA512Impl
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
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b33fc2a5-0d84-4bc6-b871-840dfd010bff" + System.Environment.NewLine);
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
                if (_sha512Impl == null)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "deabae82-7175-40b7-9b35-040f0c6d8420" + System.Environment.NewLine);
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
                    _sha512Impl = SHA512.Create();
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2b6d38aa-9644-4bad-ac3f-1bf692df2817" + System.Environment.NewLine);
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
                    Debug.Assert(_sha512Impl.CanReuseTransform && _sha512Impl.HashSize is EXPECTED_LENGTH, "nonstandard implementation?");
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a6b3cc6d-ade9-4d3a-bfa6-8c069b752187" + System.Environment.NewLine);
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
                return _sha512Impl;
            }
        }

        public static byte[] Compute(byte[] data) => SHA512Impl.ComputeHash(data);
        public static string ComputeDigestHex(byte[] data) => Compute(data).BytesToHexString();
        public static string ComputePrefixedHex(byte[] data) => $"{PREFIX}:{ComputeDigestHex(data)}";
        public static byte[] Compute(ReadOnlySpan<byte> data) => Compute(data.ToArray());
#endif
        public static string ComputeDigestHex(ReadOnlySpan<byte> data) => Compute(data).BytesToHexString();
        public static string ComputePrefixedHex(ReadOnlySpan<byte> data) => $"{PREFIX}:{ComputeDigestHex(data)}";
    }
}