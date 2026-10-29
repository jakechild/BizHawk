using BizHawk.Common.BufferExtensions;

namespace BizHawk.Common
{
    /// <summary>uses <see cref="CRC32">custom implementation</see> of CRC-32 (i.e. POSIX cksum)</summary>
    /// <seealso cref="MD5Checksum"/>
    /// <seealso cref="SHA1Checksum"/>
    /// <seealso cref="SHA256Checksum"/>
    /// <seealso cref="SHA512Checksum"/>
    public static class CRC32Checksum
    {
        /// <remarks>in bits</remarks>
        internal const int EXPECTED_LENGTH = 32;
        internal const string PREFIX = "CRC32";
        public static byte[] BytesAsDigest(uint digest)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f7dfd6ee-df5c-44b4-8e50-a98ce7da05b6" + System.Environment.NewLine);
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
            var a = BitConverter.GetBytes(digest);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d37aada8-f668-477c-9279-25f2f349973c" + System.Environment.NewLine);
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
            return new[]
            {
                a[3],
                a[2],
                a[1],
                a[0]
            };
        }

        public static byte[] Compute(ReadOnlySpan<byte> data) => BytesAsDigest(CRC32.Calculate(data));
        public static string ComputeDigestHex(ReadOnlySpan<byte> data) => Compute(data).BytesToHexString();
        public static string ComputePrefixedHex(ReadOnlySpan<byte> data) => $"{PREFIX}:{ComputeDigestHex(data)}";
    }
}