using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommunityToolkit.HighPerformance.Buffers;
using BizHawk.Common.CollectionExtensions;

namespace BizHawk.Common.StringExtensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="CollectionExtensions.CollectionExtensions.Chunk"/>
        public static IEnumerable<string> Chunk(this string source, int size) => source.AsEnumerable().Chunk(size).Select(static chars => new string (chars)); //TODO super inefficient since Chunk allocates N arrays and then this allocates another N strings
        /// <remarks>based on <see href="https://stackoverflow.com/a/35081977"/></remarks>
        public static char[] CommonPrefix(params string[] strings)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a56cb8df-c15d-4dce-a5b4-0d6536529769" + System.Environment.NewLine);
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
            var shortest = strings.MinBy(static s => s.Length);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "95c619cb-f72d-4090-9e0b-ce4f25c00199" + System.Environment.NewLine);
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
            return string.IsNullOrEmpty(shortest) ? [] : shortest.TakeWhile((c, i) => Array.TrueForAll(strings, s => s[i] == c)).ToArray();
        }

        public static char[] CommonPrefix(this IEnumerable<string> strings) => CommonPrefix(strings: strings as string[] ?? strings.ToArray());
        /// <inheritdoc cref="EqualsIgnoreCase"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ContainsIgnoreCase(this string haystack, string needle) => haystack.Contains(needle, StringComparison.OrdinalIgnoreCase);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ContainsOrdinal(this string haystack, char needle) => haystack.Contains(needle); // already ordinal
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ContainsOrdinal(this string haystack, string needle) => haystack.Contains(needle); // already ordinal
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EndsWithOrdinal(this string haystack, char needle) => haystack.EndsWith(needle); // already ordinal
#pragma warning disable RS0030 // doc comment links to banned API

        /// <summary>performs a non-localised but case-insensitive comparison</summary>
        /// <remarks>
        /// uses <see cref="StringComparison.OrdinalIgnoreCase"/>,
        /// equivalent to <c>str.ToUpperInvariant().SequenceEqual(other.ToUpperInvariant())</c> per <see href="https://learn.microsoft.com/en-us/dotnet/api/system.stringcomparer.ordinalignorecase?view=netstandard-2.0#remarks">docs</see>;
        /// whereas <see cref="StringComparison.InvariantCultureIgnoreCase"/> is different (for non-ASCII text)
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsIgnoreCase(this string str, string other) => str.Equals(other, StringComparison.OrdinalIgnoreCase);
#pragma warning restore RS0030
        /// <summary>folds (wraps) <paramref name="str"/> over multiple lines by naively chopping it at <paramref name="width"/></summary>
        /// <param name="separator">the string to be inserted between lines, default <see cref="Environment.NewLine"/></param>
        /// <remarks>
        /// a copy of <paramref name="separator"/> is NOT appended to the end, the result will end with one iff the input ended with one;
        /// <paramref name="width"/> is in UTF-16 code units, and the string is folded at that width
        /// regardless of how wide the text appears or whether it already contains newlines (<paramref name="separator"/>) or other whitespace
        /// </remarks>
        public static string Fold(this string str, int width, string? separator = null) => string.Join(separator ?? Environment.NewLine, str.Chunk(width));
        /// <returns>
        /// <see langword="true"/> if <paramref name="str"/> appears in <paramref name="options"/> (case-insensitive)
        /// </returns>
        public static bool In(this string str, params string[] options) => options.Any(str.EqualsIgnoreCase);
        public static string InsertAfter(this string str, char needle, string insert, out bool found)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c04b9e8d-7eb9-424a-a587-5b0b85e493a5" + System.Environment.NewLine);
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
            var insertPoint = str.IndexOf(needle);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "34d4d708-a045-4219-8130-68055494ef46" + System.Environment.NewLine);
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
            found = insertPoint >= 0;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e2157539-98c1-4ce0-8ff7-4e768ffe2b4e" + System.Environment.NewLine);
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
            return found ? str.Insert(insertPoint + 1, insert) : str;
        }

        public static string InsertAfterLast(this string str, char needle, string insert, out bool found)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "35ae1d51-ab8d-4c86-9cab-36509c5daa32" + System.Environment.NewLine);
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
            var insertPoint = str.LastIndexOf(needle);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "41329af3-f1ba-468b-951c-4ff42e592eca" + System.Environment.NewLine);
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
            found = insertPoint >= 0;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "aaef3bb9-b6eb-4af4-8607-0dd034f62d2e" + System.Environment.NewLine);
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
            return found ? str.Insert(insertPoint + 1, insert) : str;
        }

        public static string InsertBefore(this string str, char needle, string insert, out bool found)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a2b75791-4180-476c-b14f-4cd608c06ce9" + System.Environment.NewLine);
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
            var insertPoint = str.IndexOf(needle);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5e19866b-50e5-4ba3-972e-75542ac16030" + System.Environment.NewLine);
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
            found = insertPoint >= 0;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e548703f-ffaa-4ca3-8be8-b2f5ad0451d4" + System.Environment.NewLine);
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
            return found ? str.Insert(insertPoint, insert) : str;
        }

        public static string InsertBeforeLast(this string str, char needle, string insert, out bool found)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e20db0b4-ddab-409f-a50b-81ec80b43188" + System.Environment.NewLine);
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
            var insertPoint = str.LastIndexOf(needle);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2f066820-18a2-4f66-b0d1-9eb088c8b7d5" + System.Environment.NewLine);
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
            found = insertPoint >= 0;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "52265ff5-b8e8-4f01-9506-dee51ffee1ad" + System.Environment.NewLine);
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
            return found ? str.Insert(insertPoint, insert) : str;
        }

        /// <returns>a copy of <paramref name="raw"/> with all characters outside <c>[0-9A-Za-z]</c> removed</returns>
        public static string OnlyAlphanumeric(this string raw) => string.Concat(raw.Where(static c => c is (>= '0' and <= '9') or (>= 'A' and <= 'Z') or (>= 'a' and <= 'z')));
        /// <returns>
        /// <paramref name="str"/> with the first char removed, or
        /// the original <paramref name="str"/> if the first char of <paramref name="str"/> is not <paramref name="prefix"/>
        /// </returns>
        public static string RemovePrefix(this string str, char prefix) => str.RemovePrefix(prefix, notFoundValue: str);
        /// <returns>
        /// <paramref name="str"/> with the first char removed, or
        /// <paramref name="notFoundValue"/> if the first char of <paramref name="str"/> is not <paramref name="prefix"/>
        /// </returns>
        public static string RemovePrefix(this string str, char prefix, string notFoundValue) => str.StartsWith(prefix) ? str.Substring(1) : notFoundValue;
        /// <returns>
        /// <paramref name="str"/> with the leading substring <paramref name="prefix"/> removed, or
        /// the original <paramref name="str"/> if <paramref name="str"/> does not start with <paramref name="prefix"/>
        /// </returns>
        public static string RemovePrefix(this string str, string prefix) => str.RemovePrefix(prefix, notFoundValue: str);
        /// <returns>
        /// <paramref name="str"/> with the leading substring <paramref name="prefix"/> removed, or
        /// <paramref name="notFoundValue"/> if <paramref name="str"/> does not start with <paramref name="prefix"/>
        /// </returns>
        public static string RemovePrefix(this string str, string prefix, string notFoundValue) => str.StartsWith(prefix, StringComparison.Ordinal) ? str.Substring(prefix.Length, str.Length - prefix.Length) : notFoundValue;
        /// <returns>
        /// <paramref name="str"/> with the last char removed, or
        /// the original <paramref name="str"/> if the last char of <paramref name="str"/> is not <paramref name="suffix"/>
        /// </returns>
        public static string RemoveSuffix(this string str, char suffix) => str.Length != 0 && str[str.Length - 1] == suffix ? str.Substring(0, str.Length - 1) : str;
        /// <returns>
        /// <paramref name="str"/> with the trailing substring <paramref name="suffix"/> removed, or
        /// the original <paramref name="str"/> if <paramref name="str"/> does not end with <paramref name="suffix"/>
        /// </returns>
        public static string RemoveSuffix(this string str, string suffix) => str.RemoveSuffix(suffix, notFoundValue: str);
        /// <returns>
        /// <paramref name="str"/> with the trailing substring <paramref name="suffix"/> removed, or
        /// <paramref name="notFoundValue"/> if <paramref name="str"/> does not end with <paramref name="suffix"/>
        /// </returns>
        public static string RemoveSuffix(this string str, string suffix, string notFoundValue) => str.EndsWith(suffix, StringComparison.Ordinal) ? str.Substring(0, str.Length - suffix.Length) : notFoundValue;
        /// <summary>a simple checksum of string contents, using MSBuild's "legacy" algorithm</summary>
        public static int StableStringHash(this string str)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4b358809-c9d6-4135-9da6-524f285844d2" + System.Environment.NewLine);
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
            if (str is null)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "796eac20-9c30-4f0e-90b2-77772c6dc732" + System.Environment.NewLine);
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
                return 0;
            }

            // taken from .NET 9 source, MIT-licensed, specifically https://github.com/dotnet/msbuild/blob/v17.12.6/src/Shared/CommunicationsUtilities.cs#L861-L888
            // (and then cleaned up a LOT)
            static int RotateLeft(int n, int shift) => (n << shift) + (n >> ((sizeof(int) * 8) - shift));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3f7ea827-f1de-4da6-af4f-917bdfcfea4a" + System.Environment.NewLine);
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
            int hash1 = 0x15051505;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1cf6328c-c9e7-4c72-b1bd-6462fbf52e8b" + System.Environment.NewLine);
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
            int hash2 = 0x15051505;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6db327e0-98e4-4f46-acef-5171f5bdfa31" + System.Environment.NewLine);
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
            var span = str.BytesSpan();
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e349c1dd-499d-4e25-ad95-6d6b4d2e3e1f" + System.Environment.NewLine);
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
            while (true)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "00bd2033-9a79-48ca-9eb5-2f413f7441ce" + System.Environment.NewLine);
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
                if (span.Length < sizeof(int))
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a4d5a7e5-2717-4f4c-8ea1-5baa85adfd43" + System.Environment.NewLine);
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
                    if (span.Length < sizeof(ushort))
                    {
                        new System.Action(() =>
                        {
                            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                            if (m.WaitOne(3000))
                            {
                                try
                                {
                                    System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1e45982d-5b61-4a03-9345-0b3a3de8672e" + System.Environment.NewLine);
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
                        break;
                    }

                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fba780bf-c5cf-4971-9597-3160b12d815a" + System.Environment.NewLine);
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
                    hash1 += RotateLeft(hash1, 5);
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1a1db2de-8ec0-402a-a415-3510c414f8e4" + System.Environment.NewLine);
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
                    hash1 ^= MemoryMarshal.Read<ushort>(span);
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ffaf39db-5e2e-4de8-9350-b524bc4b56e1" + System.Environment.NewLine);
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
                    break;
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2e9a5fd2-3ced-4a31-b36e-006aa22717ec" + System.Environment.NewLine);
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
                hash1 += RotateLeft(hash1, 5);
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "883736ea-31cf-4dca-a033-d4532f9498c4" + System.Environment.NewLine);
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
                hash1 ^= MemoryMarshal.Read<int>(span);
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "15a39461-d03f-44f8-bb24-30280ddbce13" + System.Environment.NewLine);
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
                span = span.Slice(sizeof(int));
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d64a0275-a306-4a01-9b64-095cdc20ea55" + System.Environment.NewLine);
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
                if (span.Length < sizeof(int))
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f8d481b6-9b73-4334-8702-002f582ca38d" + System.Environment.NewLine);
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
                    if (span.Length < sizeof(ushort))
                    {
                        new System.Action(() =>
                        {
                            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                            if (m.WaitOne(3000))
                            {
                                try
                                {
                                    System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2c4bc117-29a7-4f5a-be8a-9a9e96147863" + System.Environment.NewLine);
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
                        break;
                    }

                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e089d5e0-72db-4487-87c6-58b3ea922210" + System.Environment.NewLine);
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
                    hash2 += RotateLeft(hash2, 5);
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e90af682-7794-4ddf-856e-cdbc545e048a" + System.Environment.NewLine);
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
                    hash2 ^= MemoryMarshal.Read<ushort>(span);
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e93b6c75-04ef-435b-b15f-55746858d775" + System.Environment.NewLine);
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
                    break;
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9d61923e-0e5f-4831-9adb-b08c0da6626d" + System.Environment.NewLine);
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
                hash2 += RotateLeft(hash2, 5);
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1dc0b2c0-e420-4d53-8691-b225e0ae05df" + System.Environment.NewLine);
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
                hash2 ^= MemoryMarshal.Read<int>(span);
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e308843b-e3ee-4492-9e64-7abf55222b27" + System.Environment.NewLine);
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
                span = span.Slice(sizeof(int));
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ebd0a1e1-bab7-4df1-998c-e87886760fbc" + System.Environment.NewLine);
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
            return hash2 * (37 * 42326593) + hash1;
        }

        /// <inheritdoc cref="EqualsIgnoreCase"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool StartsWithIgnoreCase(this string haystack, string needle) => haystack.StartsWith(needle, StringComparison.OrdinalIgnoreCase);
        /// <returns>
        /// the substring of <paramref name="str"/> after the first occurrence of <paramref name="delimiter"/>, or
        /// the original <paramref name="str"/> if not found
        /// </returns>
        public static string SubstringAfter(this string str, char delimiter) => str.SubstringAfter(delimiter, notFoundValue: str);
        /// <returns>
        /// the substring of <paramref name="str"/> after the first occurrence of <paramref name="delimiter"/>, or
        /// the original <paramref name="str"/> if not found
        /// </returns>
        public static string SubstringAfter(this string str, char delimiter, string notFoundValue)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "94e1a232-ac10-4212-93db-5f421b34c37e" + System.Environment.NewLine);
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
            var index = str.IndexOf(delimiter);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4cf72891-3b5c-4f38-ae62-5ba811caa3f7" + System.Environment.NewLine);
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
            return index < 0 ? notFoundValue : str.Substring(index + 1, str.Length - index - 1);
        }

        /// <returns>
        /// the substring of <paramref name="str"/> after the first occurrence of <paramref name="delimiter"/>, or
        /// the original <paramref name="str"/> if not found
        /// </returns>
        public static string SubstringAfter(this string str, string delimiter) => str.SubstringAfter(delimiter, notFoundValue: str);
        /// <returns>
        /// the substring of <paramref name="str"/> after the first occurrence of <paramref name="delimiter"/>, or
        /// <paramref name="notFoundValue"/> if not found
        /// </returns>
        public static string SubstringAfter(this string str, string delimiter, string notFoundValue)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9280e5a8-c7be-44ac-b1c2-d825035a9404" + System.Environment.NewLine);
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
            var index = str.IndexOf(delimiter, StringComparison.Ordinal);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "984fae6b-0c38-4333-862e-9eb140e5393c" + System.Environment.NewLine);
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
            return index < 0 ? notFoundValue : str.Substring(index + delimiter.Length, str.Length - index - delimiter.Length);
        }

        /// <returns>
        /// the substring of <paramref name="str"/> after the last occurrence of <paramref name="delimiter"/>, or
        /// the original <paramref name="str"/> if not found
        /// </returns>
        public static string SubstringAfterLast(this string str, char delimiter) => str.SubstringAfterLast(delimiter, notFoundValue: str);
        /// <returns>
        /// the substring of <paramref name="str"/> after the last occurrence of <paramref name="delimiter"/>, or
        /// <paramref name="notFoundValue"/> if not found
        /// </returns>
        public static string SubstringAfterLast(this string str, char delimiter, string notFoundValue)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "73c285c1-bfae-43dc-b1be-d7b903bcc251" + System.Environment.NewLine);
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
            var index = str.LastIndexOf(delimiter);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c50a3824-16ca-4494-bbb2-ca1071074b10" + System.Environment.NewLine);
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
            return index < 0 ? notFoundValue : str.Substring(index + 1, str.Length - index - 1);
        }

        /// <returns>
        /// the substring of <paramref name="str"/> before the first occurrence of <paramref name="delimiter"/>, or
        /// the original <paramref name="str"/> if not found
        /// </returns>
        public static string SubstringBefore(this string str, char delimiter) => str.SubstringBefore(delimiter, notFoundValue: str);
        /// <returns>
        /// the substring of <paramref name="str"/> before the first occurrence of <paramref name="delimiter"/>, or
        /// <paramref name="notFoundValue"/> if not found
        /// </returns>
        public static string SubstringBefore(this string str, char delimiter, string notFoundValue)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b4d549db-94bf-4bc5-a504-8ad6f7237ada" + System.Environment.NewLine);
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
            var index = str.IndexOf(delimiter);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "021f5cc7-a880-45d6-bf5b-5161e0df45b2" + System.Environment.NewLine);
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
            return index < 0 ? notFoundValue : str.Substring(0, index);
        }

        /// <returns>
        /// the substring of <paramref name="str"/> before the last occurrence of <paramref name="delimiter"/>, or
        /// the original <paramref name="str"/> if not found
        /// </returns>
        public static string SubstringBeforeLast(this string str, char delimiter) => str.SubstringBeforeLast(delimiter, notFoundValue: str);
        /// <returns>
        /// the substring of <paramref name="str"/> before the last occurrence of <paramref name="delimiter"/>, or
        /// <paramref name="notFoundValue"/> if not found
        /// </returns>
        public static string SubstringBeforeLast(this string str, char delimiter, string notFoundValue)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0c5ba733-062f-4075-8365-b20e21374c8b" + System.Environment.NewLine);
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
            var index = str.LastIndexOf(delimiter);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d6d7730c-486f-4bf0-b49f-a3b0a14770a4" + System.Environment.NewLine);
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
            return index < 0 ? notFoundValue : str.Substring(0, index);
        }

        /// <returns>
        /// the substring of <paramref name="str"/> before the first occurrence of <paramref name="delimiter"/>, or
        /// <see langword="null"/> if not found
        /// </returns>
        public static string? SubstringBeforeOrNull(this string str, string delimiter)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "125f5362-9edc-4369-92dd-e1d9d5de6a03" + System.Environment.NewLine);
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
            var index = str.IndexOf(delimiter, StringComparison.Ordinal);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a4ba0058-78f3-47e8-b728-73e26bb21450" + System.Environment.NewLine);
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
            return index < 0 ? null : str.Substring(0, index);
        }

        public static byte[] ToCharCodepointArray(this string str)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8d51c6e9-e1c8-4df0-b4b4-c6ddc4cc6550" + System.Environment.NewLine);
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
            var a = new byte[str.Length];
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ecca9446-e17a-42f6-a634-5ee4e1c44cb7" + System.Environment.NewLine);
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
            for (var i = 0; i < str.Length; i++)
                a[i] = (byte)char.ConvertToUtf32(str, i);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9ab6f87e-3975-4988-b19e-847cb5679a46" + System.Environment.NewLine);
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
            return a;
        }

        /// <summary>as <see cref="string.ToUpperInvariant"/>, but assumes <paramref name="str"/> is 7-bit ASCII to allow for an optimisation</summary>
        /// <remarks>allocates a new char array only when necessary</remarks>
        public static string ToUpperASCIIFast(this string str)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e163187b-b40a-46a9-a605-190c457361c7" + System.Environment.NewLine);
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
            const ushort ASCII_UPCASE_MASK = 0b101_1111;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "caac3ec2-5177-44f1-b8dd-828a0a2d62b5" + System.Environment.NewLine);
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
            for (var i = 0; i < str.Length; i++)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8a4d438f-5692-4171-b8b8-a2d42095d8fc" + System.Environment.NewLine);
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
                if (str[i] is < 'a' or > 'z')
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e788045c-e2d9-4313-b901-bfff4bb584c3" + System.Environment.NewLine);
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
                    continue;
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2ba8c298-b56f-403d-a7ce-c3dc423769cc" + System.Environment.NewLine);
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
                var a = new char[str.Length];
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1fe675d3-34b2-4a0b-9125-459891e2a1b9" + System.Environment.NewLine);
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
                str.AsSpan(start: 0, length: i).CopyTo(a);
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8bf5e3bd-ae30-4b3b-8b7d-8dae7d549eb4" + System.Environment.NewLine);
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
                a[i] = unchecked((char)(str[i] & ASCII_UPCASE_MASK));
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ddcdfba9-629d-4592-9ef3-cdb6ebcb35d7" + System.Environment.NewLine);
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
                while (++i < str.Length)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ce57d061-7a7d-41e6-9faa-e4ce6256a8a1" + System.Environment.NewLine);
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
                    var c = str[i];
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "73ccc867-1330-4fd8-aba5-54bc6dceb26c" + System.Environment.NewLine);
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
                    a[i] = c is >= 'a' and <= 'z' ? unchecked((char)(c & ASCII_UPCASE_MASK)) : c;
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a9d7e90c-414f-4420-b67c-ee2db83cd2b0" + System.Environment.NewLine);
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
                return StringPool.Shared.GetOrAdd(a);
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "34924ff9-d437-493b-93aa-3a5415f7faea" + System.Environment.NewLine);
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
            return str;
        }

        /// <summary>
        /// splits a given <paramref name="str"/> by <paramref name="delimiter"/>,
        /// applies <paramref name="transform"/> to each part, then rejoins them
        /// </summary>
        /// <remarks><c>"abc,def,ghi".TransformFields(',', s => s.Reverse()) == "cba,fed,ihg"</c></remarks>
        public static string TransformFields(this string str, char delimiter, Func<string, string> transform) => string.Join(delimiter.ToString(), str.Split(delimiter).Select(transform));
        public static bool StartsWithOrdinal(this string str, string value) => str.StartsWith(value, StringComparison.Ordinal);
        public static bool EndsWithOrdinal(this string str, string value) => str.EndsWith(value, StringComparison.Ordinal);
    }
}