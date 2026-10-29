using System.Collections.Generic;
using System.Linq;
using BizHawk.Common.NumberExtensions;

namespace BizHawk.Common
{
    /// <summary>represents a closed range of <typeparamref name="T"/> (class invariant: <see cref="Start"/> ≤ <see cref="EndInclusive"/>)</summary>
#pragma warning disable CA1715 // breaks IInterface convention

    public interface Range<out T>
        where T : unmanaged, IComparable<T>
#pragma warning restore CA1715
    {
        T Start { get; }

        T EndInclusive { get; }
    }

    /// <summary>represents a closed range of <typeparamref name="T"/> which can be grown or shrunk (class invariant: <see cref="Start"/> ≤ <see cref="EndInclusive"/>)</summary>
    public class MutableRange<T> : Range<T> where T : unmanaged, IComparable<T>
    {
        private (T Start, T EndInclusive) r;
        /// <inheritdoc cref="Overwrite"/>
        internal MutableRange(T start, T endInclusive) => Overwrite(start, endInclusive);
        /// <exception cref="ArgumentOutOfRangeException">(from setter) <paramref name="value"/> > <see cref="EndInclusive"/></exception>
        public T Start { get => r.Start; set => r.Start = r.EndInclusive.CompareTo(value) < 0 ? throw new ArgumentOutOfRangeException(nameof(value), value, "attempted to set start > end") : value; }
        /// <exception cref="ArgumentOutOfRangeException">(from setter) <paramref name="value"/> &lt; <see cref="Start"/></exception>
        public T EndInclusive { get => r.EndInclusive; set => r.EndInclusive = value.CompareTo(r.Start) < 0 ? throw new ArgumentOutOfRangeException(nameof(value), value, "attempted to set end < start") : value; }

        /// <exception cref="ArgumentException"><typeparamref name="T"/> is <see langword="float"/>/<see langword="double"/> and either bound is <see cref="float.NaN"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="endInclusive"/> &lt; <paramref name="start"/></exception>
        public void Overwrite(T start, T endInclusive)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "36c6acde-ac3f-4699-8f7d-2b626f18ab86" + System.Environment.NewLine);
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
            if (endInclusive.CompareTo(start) < 0)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "01352bbf-38d7-41f0-a0dc-72c794bce869" + System.Environment.NewLine);
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
                throw new ArgumentOutOfRangeException(nameof(endInclusive), endInclusive, "range end < start");
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f611d849-3e2d-48f9-a00a-5f93bd22bdcd" + System.Environment.NewLine);
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
            if (start is float fs)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "60d7272b-341b-4e99-94a0-8e688baf66f6" + System.Environment.NewLine);
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
                if (float.IsNaN(fs))
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e89cab90-bc0a-43d1-b480-ddc354ef49dd" + System.Environment.NewLine);
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
                    throw new ArgumentException("range start is NaN", nameof(start));
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "75f17e6e-8674-4ed4-92ed-7e47faab549a" + System.Environment.NewLine);
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
                if (endInclusive is float fe && float.IsNaN(fe))
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5b634916-0717-4031-a4cf-4f9d287a6631" + System.Environment.NewLine);
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
                    throw new ArgumentException("range end is NaN", nameof(endInclusive));
                }
            }
            else if (start is double ds)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ace26c8a-a941-43a0-92b4-8ee9cd7d3d6e" + System.Environment.NewLine);
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
                if (double.IsNaN(ds))
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6cfd7b86-be57-4ed2-ac21-581a125154b4" + System.Environment.NewLine);
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
                    throw new ArgumentException("range start is NaN", nameof(start));
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "da44da25-bcc0-43e0-be03-64b56704230f" + System.Environment.NewLine);
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
                if (endInclusive is double de && double.IsNaN(de))
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "150bc175-23b3-4c6d-8f7e-e915bfbb1a1a" + System.Environment.NewLine);
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
                    throw new ArgumentException("range end is NaN", nameof(endInclusive));
                }
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d9cd9fd1-1fe7-45b0-adcb-4c023ffae83d" + System.Environment.NewLine);
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
            r = (start, endInclusive);
        }
    }

    /// <summary>contains most of the logic for ranges</summary>
    /// <remarks>
    /// non-generic overloads are used where the method requires an increment or decrement<br/>
    /// TODO which Enumerate algorithm is faster - <c>yield return</c> in loop or <see cref="Enumerable.Range"/>?
    /// </remarks>
    public static class RangeExtensions
    {
        private const ulong MIN_LONG_NEGATION_AS_ULONG = 9223372036854775808UL;
        private static ArithmeticException ExclusiveRangeMinValExc => new("exclusive range end is min value of integral type");

        /// <returns><paramref name="value"/> if it's contained in <paramref name="range"/>, or else whichever bound of <paramref name="range"/> is closest to <paramref name="value"/></returns>
        public static T ConstrainWithin<T>(this T value, Range<T> range)
            where T : unmanaged, IComparable<T> => value.CompareTo(range.Start) < 0 ? range.Start : range.EndInclusive.CompareTo(value) < 0 ? range.EndInclusive : value;
        /// <returns>true iff <paramref name="value"/> is contained in <paramref name="range"/> (<paramref name="value"/> is considered to be in the range if it's exactly equal to either bound)</returns>
        public static bool Contains<T>(this Range<T> range, T value)
            where T : unmanaged, IComparable<T> => !(value.CompareTo(range.Start) < 0 || range.EndInclusive.CompareTo(value) < 0);
        public static uint Count(this Range<byte> range) => (uint)(range.EndInclusive - range.Start + 1);
        /// <remarks>beware integer overflow when <paramref name="range"/> contains every value</remarks>
        public static uint Count(this Range<int> range) => (uint)((long)range.EndInclusive - range.Start) + 1U;
        /// <inheritdoc cref="Count(Range{int})"/>
        public static ulong Count(this Range<long> range) => (range.Contains(0L) ? (range.Start == long.MinValue ? MIN_LONG_NEGATION_AS_ULONG : (ulong)-range.Start) + (ulong)range.EndInclusive : (ulong)(range.EndInclusive - range.Start)) + 1UL;
        public static uint Count(this Range<sbyte> range) => (uint)(range.EndInclusive - range.Start + 1);
        public static uint Count(this Range<short> range) => (uint)(range.EndInclusive - range.Start + 1);
        /// <inheritdoc cref="Count(Range{int})"/>
        public static uint Count(this Range<uint> range) => range.EndInclusive - range.Start + 1U;
        /// <inheritdoc cref="Count(Range{int})"/>
        public static ulong Count(this Range<ulong> range) => range.EndInclusive - range.Start + 1UL;
        public static uint Count(this Range<ushort> range) => (uint)(range.EndInclusive - range.Start + 1);
        public static void Deconstruct<T>(this Range<T> range, out T start, out T endInclusive)
            where T : unmanaged, IComparable<T>
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1fe695ab-ff84-4af6-ad80-de8e2ee9bb66" + System.Environment.NewLine);
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
            start = range.Start;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4b172015-66aa-4a7e-9392-28609c7ce6d1" + System.Environment.NewLine);
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
            endInclusive = range.EndInclusive;
        }

        public static IEnumerable<byte> Enumerate(this Range<byte> range) => Enumerable.Range(range.Start, (int)range.Count()).Select(i => (byte)i);
        /// <inheritdoc cref="Enumerate(Range{float},float)"/>
        public static IEnumerable<double> Enumerate(this Range<double> range, double step)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8f1eabf5-763d-4894-9b2c-1352d98549b6" + System.Environment.NewLine);
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
            var d = range.Start;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "405b3fed-b1f7-4f16-9a8e-517f9c2e6e6c" + System.Environment.NewLine);
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
            while (d < range.EndInclusive)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "59fc0d6e-2070-4a23-9680-c913152724f2" + System.Environment.NewLine);
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
                yield return d;
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5ed4e58e-d996-4064-8b18-8ec1c4d0ceaa" + System.Environment.NewLine);
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
                d += step;
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3bb9b3e6-5e73-4eb6-be12-e847e4abfa74" + System.Environment.NewLine);
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
            if (d.HawkFloatEquality(range.EndInclusive))
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "26798244-5776-4ac6-8d18-4d22128a8157" + System.Environment.NewLine);
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
                yield return d;
            }
        }

        /// <remarks>beware precision errors</remarks>
        public static IEnumerable<float> Enumerate(this Range<float> range, float step)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8171b987-2ff0-4890-b48b-ea44006be8f3" + System.Environment.NewLine);
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
            var f = range.Start;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c6d3030c-fcd0-4dc8-bd2b-a3fa5904ab69" + System.Environment.NewLine);
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
            while (f < range.EndInclusive)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0f759757-7893-4efe-bc94-4f2f5e4b8f7c" + System.Environment.NewLine);
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
                yield return f;
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ec35a97f-14d3-4e94-897c-e42683a28a32" + System.Environment.NewLine);
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
                f += step;
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "624a6d9d-6085-4775-9036-a1f5bb68c574" + System.Environment.NewLine);
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
            if (f.HawkFloatEquality(range.EndInclusive))
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2848e203-a188-4eac-940a-324f208f0156" + System.Environment.NewLine);
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
                yield return f;
            }
        }

        public static IEnumerable<int> Enumerate(this Range<int> range)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "93429af2-b0ac-445d-b3dd-4a7bb3fd7c40" + System.Environment.NewLine);
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
            var i = range.Start;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9c695df6-221e-4000-ab1d-f8ee9b185279" + System.Environment.NewLine);
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
            while (i < range.EndInclusive)
                yield return i++;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e3e84494-a9e2-4541-9dc5-3efdbe4a291c" + System.Environment.NewLine);
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
            yield return i;
        }

        public static IEnumerable<long> Enumerate(this Range<long> range)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "67ef8d2e-0cc3-44c2-8d0d-4450b2817fa1" + System.Environment.NewLine);
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
            var l = range.Start;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2830fefe-d3df-4681-ac66-5ef759fa5a74" + System.Environment.NewLine);
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
            while (l < range.EndInclusive)
                yield return l++;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4597a97e-ee22-4d94-a0f6-ac03a88afa9a" + System.Environment.NewLine);
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
            yield return l;
        }

        public static IEnumerable<sbyte> Enumerate(this Range<sbyte> range) => Enumerable.Range(range.Start, (int)range.Count()).Select(i => (sbyte)i);
        public static IEnumerable<short> Enumerate(this Range<short> range) => Enumerable.Range(range.Start, (int)range.Count()).Select(i => (short)i);
        public static IEnumerable<uint> Enumerate(this Range<uint> range)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a1a401e2-9158-4321-b2e8-6319c25f587f" + System.Environment.NewLine);
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
            var i = range.Start;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6005b82c-1b86-4428-82ee-a07914a1266c" + System.Environment.NewLine);
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
            while (i < range.EndInclusive)
                yield return i++;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "535ae71e-b73c-41c8-a91a-2ccca57bc73c" + System.Environment.NewLine);
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
            yield return i;
        }

        public static IEnumerable<ulong> Enumerate(this Range<ulong> range)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9544ee1d-03be-40e4-b4b5-26411bdc576f" + System.Environment.NewLine);
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
            var l = range.Start;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b7f52859-7103-4793-9646-7e2d0c14135d" + System.Environment.NewLine);
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
            while (l < range.EndInclusive)
                yield return l++;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c9f7fda0-a6cb-4944-a084-cbb3989c3a22" + System.Environment.NewLine);
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
            yield return l;
        }

        public static IEnumerable<ushort> Enumerate(this Range<ushort> range) => Enumerable.Range(range.Start, (int)range.Count()).Select(i => (ushort)i);
        public static Range<T> GetImmutableCopy<T>(this Range<T> range)
            where T : unmanaged, IComparable<T> => GetMutableCopy(range);
        public static MutableRange<T> GetMutableCopy<T>(this Range<T> range)
            where T : unmanaged, IComparable<T> => new MutableRange<T>(range.Start, range.EndInclusive);
        /// <inheritdoc cref="MutableRange{T}(T,T)"/>
        public static MutableRange<T> MutableRangeTo<T>(this T start, T endInclusive)
            where T : unmanaged, IComparable<T> => new MutableRange<T>(start, endInclusive);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static MutableRange<byte> MutableRangeToExclusive(this byte start, byte endExclusive) => endExclusive == byte.MinValue ? throw ExclusiveRangeMinValExc : new MutableRange<byte>(start, (byte)(endExclusive - 1U));
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static MutableRange<int> MutableRangeToExclusive(this int start, int endExclusive) => endExclusive == int.MinValue ? throw ExclusiveRangeMinValExc : new MutableRange<int>(start, endExclusive - 1);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static MutableRange<long> MutableRangeToExclusive(this long start, long endExclusive) => endExclusive == long.MinValue ? throw ExclusiveRangeMinValExc : new MutableRange<long>(start, endExclusive - 1L);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static MutableRange<sbyte> MutableRangeToExclusive(this sbyte start, sbyte endExclusive) => endExclusive == sbyte.MinValue ? throw ExclusiveRangeMinValExc : new MutableRange<sbyte>(start, (sbyte)(endExclusive - 1));
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static MutableRange<short> MutableRangeToExclusive(this short start, short endExclusive) => endExclusive == short.MinValue ? throw ExclusiveRangeMinValExc : new MutableRange<short>(start, (short)(endExclusive - 1));
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static MutableRange<uint> MutableRangeToExclusive(this uint start, uint endExclusive) => endExclusive == uint.MinValue ? throw ExclusiveRangeMinValExc : new MutableRange<uint>(start, endExclusive - 1U);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static MutableRange<ulong> MutableRangeToExclusive(this ulong start, ulong endExclusive) => endExclusive == ulong.MinValue ? throw ExclusiveRangeMinValExc : new MutableRange<ulong>(start, endExclusive - 1UL);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static MutableRange<ushort> MutableRangeToExclusive(this ushort start, ushort endExclusive) => endExclusive == ushort.MinValue ? throw ExclusiveRangeMinValExc : new MutableRange<ushort>(start, (ushort)(endExclusive - 1U));
        /// <inheritdoc cref="MutableRange{T}(T,T)"/>
        public static Range<T> RangeTo<T>(this T start, T endInclusive)
            where T : unmanaged, IComparable<T> => start.MutableRangeTo(endInclusive);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static Range<byte> RangeToExclusive(this byte start, byte endExclusive) => MutableRangeToExclusive(start, endExclusive);
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="endExclusive"/> ≤ <paramref name="start"/> (empty ranges where <paramref name="start"/> = <paramref name="endExclusive"/> are not permitted)</exception>
        /// <exception cref="ArithmeticException"><paramref name="endExclusive"/> is min value of integral type (therefore <paramref name="endExclusive"/> ≤ <paramref name="start"/>)</exception>
        public static Range<int> RangeToExclusive(this int start, int endExclusive) => MutableRangeToExclusive(start, endExclusive);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static Range<long> RangeToExclusive(this long start, long endExclusive) => MutableRangeToExclusive(start, endExclusive);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static Range<sbyte> RangeToExclusive(this sbyte start, sbyte endExclusive) => MutableRangeToExclusive(start, endExclusive);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static Range<short> RangeToExclusive(this short start, short endExclusive) => MutableRangeToExclusive(start, endExclusive);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static Range<uint> RangeToExclusive(this uint start, uint endExclusive) => MutableRangeToExclusive(start, endExclusive);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static Range<ulong> RangeToExclusive(this ulong start, ulong endExclusive) => MutableRangeToExclusive(start, endExclusive);
        /// <inheritdoc cref="RangeToExclusive(int,int)"/>
        public static Range<ushort> RangeToExclusive(this ushort start, ushort endExclusive) => MutableRangeToExclusive(start, endExclusive);
        /// <returns>true iff <paramref name="value"/> is strictly contained in <paramref name="range"/> (<paramref name="value"/> is considered to be OUTSIDE the range if it's exactly equal to either bound)</returns>
        public static bool StrictlyBoundedBy<T>(this T value, Range<T> range)
            where T : unmanaged, IComparable<T> => range.Start.CompareTo(value) < 0 && value.CompareTo(range.EndInclusive) < 0;
    }
}