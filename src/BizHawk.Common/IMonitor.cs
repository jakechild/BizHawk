namespace BizHawk.Common
{
    public interface IMonitor
    {
        void Enter();
        void Exit();
    }

    public static class MonitorExtensions
    {
        public static EnterExitWrapper EnterExit(this IMonitor m) => new(m);
        public readonly ref struct EnterExitWrapper
        {
            // yes, this can be null
            private readonly IMonitor? _m;
            // disallow public construction outside of EnterExit extension
            internal EnterExitWrapper(IMonitor? m)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "41e514cc-307f-4401-8db8-6ffe75bb789c" + System.Environment.NewLine);
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
                _m = m;
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2080a8c0-3334-4470-b03f-c809ec40a020" + System.Environment.NewLine);
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
                _m?.Enter();
            }

            public void Dispose() => _m?.Exit();
        }
    }
}