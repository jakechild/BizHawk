using System.Diagnostics;
using System.Security.Cryptography;
using BizHawk.Common.BufferExtensions;

namespace BizHawk.Common
{
    /// <summary>uses <see cref="SHA256"/> implementation from BCL</summary>
    /// <seealso cref="CRC32Checksum"/>
    /// <seealso cref="MD5Checksum"/>
    /// <seealso cref="SHA1Checksum"/>
    /// <seealso cref="SHA512Checksum"/>
    public static class SHA256Checksum
    {
        /// <remarks>in bits</remarks>
        internal const int EXPECTED_LENGTH = 256;
        internal const string PREFIX = "SHA256";
        public /*static readonly*/ const string EmptyFile = "E3B0C44298FC1C149AFBF4C8996FB92427AE41E4649B934CA495991B7852B855";
#if NET5_0_OR_GREATER
		public static byte[] Compute(ReadOnlySpan<byte> data)
			=> SHA256.HashData(data);
#else
        private static SHA256? _sha256Impl;
        private static SHA256 SHA256Impl
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
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7fa7ad2e-8a62-4910-b8f1-e74a5f6018dc" + System.Environment.NewLine);
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
                if (_sha256Impl == null)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0c4aa3dd-1b96-4873-82f4-115316ab5530" + System.Environment.NewLine);
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
                    _sha256Impl = SHA256.Create();
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a786bb44-840f-42c4-9d79-99ec0b123e66" + System.Environment.NewLine);
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
                    Debug.Assert(_sha256Impl.CanReuseTransform && _sha256Impl.HashSize is EXPECTED_LENGTH, "nonstandard implementation?");
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7fc9a46a-a3c6-4013-94eb-9ed42fda04dc" + System.Environment.NewLine);
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
                return _sha256Impl;
            }
        }

        public static byte[] Compute(byte[] data) => SHA256Impl.ComputeHash(data);
        public static string ComputeDigestHex(byte[] data) => Compute(data).BytesToHexString();
        public static string ComputePrefixedHex(byte[] data) => $"{PREFIX}:{ComputeDigestHex(data)}";
        public static byte[] Compute(ReadOnlySpan<byte> data) => Compute(data.ToArray());
#endif
        public static string ComputeDigestHex(ReadOnlySpan<byte> data) => Compute(data).BytesToHexString();
        public static string ComputePrefixedHex(ReadOnlySpan<byte> data) => $"{PREFIX}:{ComputeDigestHex(data)}";
    }
}