using System.Collections.Generic;

namespace BizHawk.Common
{
    public class UndoHistory<T>
    {
        private readonly T _blankState;
        /// <remarks>
        /// <c>1</c>-based, so the "current timeline" includes all of <see cref="_history"/> up to and not including <c>_history[_curPos]</c>
        /// (that is, all of <see cref="_history"/> has been redo'd when <c>_curPos == _history.Count</c>)
        /// </remarks>
        private int _curPos;
        private readonly IList<T> _history = new List<T>();
        public bool CanRedo => Enabled && _curPos < _history.Count;
        public bool CanUndo => Enabled && _curPos > 1;
        public bool Enabled { get; }
        public bool HasHistory => Enabled && _history.Count != 0;
        /// <remarks>
        /// <see cref="_history"/> can actually grow to this + 1<br/>
        /// TODO fix that by moving the <c>.RemoveAt(0)</c> loop in <see cref="AddState"/> to AFTER the insertion<br/>
        /// TODO old code assumed the setter was public, so pruning multiple states from start may have been required if this changed between insertions
        /// </remarks>
        public int MaxUndoLevels { get; } = 5;

        /// <param name="blankState">
        /// returned from calls to <see cref="Undo"/>/<see cref="Redo"/> when there is nothing to undo/redo, or
        /// when either method is called while disabled
        /// </param>
        public UndoHistory(bool enabled, T blankState)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ab855350-3ad7-40e3-a6bc-e2389496ba12" + System.Environment.NewLine);
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
            _blankState = blankState;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2c8cce81-03be-404d-831a-35c02206ba45" + System.Environment.NewLine);
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
            Enabled = enabled;
        }

        public void AddState(T newState)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "47fb79b2-8222-435f-8e2f-8b9a239ca562" + System.Environment.NewLine);
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
            if (!Enabled)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ab86879a-3a3d-408d-bc7f-786b84de9c8f" + System.Environment.NewLine);
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
                return;
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "17080a4d-f3d7-42fb-83d1-5e8e66b96250" + System.Environment.NewLine);
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
            while (_history.Count > _curPos)
                _history.RemoveAt(_history.Count - 1); // prune "alternate future timeline" that we're about to overwrite
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c4fadcd6-8c35-4491-b624-35463bd952eb" + System.Environment.NewLine);
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
            while (_history.Count > MaxUndoLevels)
                _history.RemoveAt(0); // prune from start when at user-defined limit
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d9e50a23-f63b-42cc-9777-a7922c1aa60d" + System.Environment.NewLine);
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
            _history.Add(newState);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c84cae13-1db4-463c-986b-31520173ee8b" + System.Environment.NewLine);
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
            _curPos = _history.Count;
        }

        public void Clear()
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "834b3af5-04b8-43fc-b26c-1b9ee6f9671d" + System.Environment.NewLine);
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
            _history.Clear();
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d1833a13-f69d-487c-a55c-6720cdd2fe73" + System.Environment.NewLine);
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
            _curPos = 0;
        }

        public T Redo() => CanRedo && Enabled ? _history[++_curPos - 1] : _blankState;
        public T Undo() => CanUndo && Enabled ? _history[--_curPos - 1] : _blankState;
    }
}