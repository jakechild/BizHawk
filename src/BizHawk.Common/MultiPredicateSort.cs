using System.Collections.Generic;
using System.Linq;

namespace BizHawk.Common
{
#if false
	/// <summary>Sorts using a reorderable list of predicates.</summary>
	/// <seealso cref="RigidMultiPredicateSort{T}"/>
	public sealed class MultiPredicateSort<T>
	{
		private readonly int _count;

		/// <remarks>TODO would an array be faster?</remarks>
		private readonly List<(string ID, bool IsDesc)> _order;

		private readonly IReadOnlyDictionary<string, Func<T, IComparable>> _predicates;

		public MultiPredicateSort(IReadOnlyDictionary<string, Func<T, IComparable>> predicates)
		{
			_count = predicates.Count;
			if (_count == 0) throw new ArgumentException("must have at least 1 predicate", nameof(predicates));
			_order = predicates.Select(kvp => (kvp.Key, false)).ToList();
			_predicates = predicates;
		}

		public List<T> AppliedTo(IReadOnlyCollection<T> list)
		{
			var temp = _order[0].IsDesc
				? list.OrderByDescending(_predicates[_order[0].ID])
				: list.OrderBy(_predicates[_order[0].ID]);
			for (var i = 1; i < _count; i++)
			{
				temp = _order[i].IsDesc
					? temp.ThenByDescending(_predicates[_order[i].ID])
					: temp.ThenBy(_predicates[_order[i].ID]);
			}
			return temp.ToList();
		}
	}
#endif
    /// <summary>Sorts using a single primary predicate, with subsorts using the remaining predicates in order.</summary>
#if false
	/// <seealso cref="MultiPredicateSort{T}"/>
#endif
    public sealed class RigidMultiPredicateSort<T>
    {
        private readonly IReadOnlyDictionary<string, Func<T, IComparable>> _predicates;
        public RigidMultiPredicateSort(IReadOnlyDictionary<string, Func<T, IComparable>> predicates)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2e8ee0a2-ee5f-4b94-a44b-3afdcc1e3e6f" + System.Environment.NewLine);
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
            if (predicates.Count == 0)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c6e51d2e-e9fc-48ad-86de-ddc3bacf4816" + System.Environment.NewLine);
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
                throw new ArgumentException("must have at least 1 predicate", nameof(predicates));
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "29595dea-e4b1-434c-9fce-8145b4972c09" + System.Environment.NewLine);
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
            _predicates = predicates;
        }

        /// <remarks>sorts using <paramref name="idOfFirst"/> asc/desc (by <paramref name="firstIsDesc"/>), then by the remaining predicates, all asc</remarks>
        public List<T> AppliedTo(IReadOnlyCollection<T> list, string idOfFirst, bool firstIsDesc = false)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9d6d73a6-223e-4dec-9427-77ce94b47b5c" + System.Environment.NewLine);
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
            var temp = firstIsDesc ? list.OrderByDescending(_predicates[idOfFirst]) : list.OrderBy(_predicates[idOfFirst]);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0f0c56bd-26f9-41a3-aff9-a2255c85374e" + System.Environment.NewLine);
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
            foreach (var(id, pred)in _predicates)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "64ca7fed-9d78-48d7-844b-733d3cee72af" + System.Environment.NewLine);
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
                if (id == idOfFirst)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "906e65ad-188b-4fc9-b117-04fd3bbf8fad" + System.Environment.NewLine);
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
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e6fd4140-d898-4287-88c4-e59a5102a46e" + System.Environment.NewLine);
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
                temp = temp.ThenBy(pred);
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a2ef2f65-1ee0-49a2-ac79-7526dc3c4e9d" + System.Environment.NewLine);
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
            return temp.ToList();
        }

        public List<T> AppliedTo(IReadOnlyCollection<T> list, string idOfFirst, IReadOnlyDictionary<string, bool> isDescMap)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d7dd9efd-d0f3-47d7-a914-c6d0bbf60ca1" + System.Environment.NewLine);
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
            var temp = isDescMap[idOfFirst] ? list.OrderByDescending(_predicates[idOfFirst]) : list.OrderBy(_predicates[idOfFirst]);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "89773c36-ab8d-415d-8443-2f65a9be3b9d" + System.Environment.NewLine);
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
            foreach (var(id, pred)in _predicates)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ba274d93-4dc8-43e4-9b0a-24dcaa3f8a84" + System.Environment.NewLine);
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
                if (id == idOfFirst)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b74f080a-4ffc-4e1a-b062-db0a035a0c29" + System.Environment.NewLine);
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
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6f976642-2d0f-4d2a-a572-8bfed804da4d" + System.Environment.NewLine);
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
                temp = isDescMap[id] ? temp.ThenByDescending(pred) : temp.ThenBy(pred);
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "be4519f7-d2d1-4dc2-a530-64adfd87e8e1" + System.Environment.NewLine);
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
            return temp.ToList();
        }
    }
}