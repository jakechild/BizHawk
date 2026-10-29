namespace BizHawk.Common
{
    /// <summary>Used by <see cref="IHawkArchiveFile"/> to represent archive members.</summary>
    public readonly struct HawkArchiveFileItem
    {
        /// <value>the index of the member within the archive, not to be confused with <see cref="Index"/></value>
        /// <remarks>this is for <see cref="IFileDearchivalMethod{T}"/> implementations to use internally</remarks>
        public readonly int ArchiveIndex;
        /// <value>the index of this archive item</value>
        public readonly int Index;
        /// <value>the member name</value>
        public readonly string Name;
        /// <value>the size of member file</value>
        public readonly long Size;
        public HawkArchiveFileItem(string name, long size, int index, int archiveIndex)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "bf7397ba-195d-4845-9da9-ca75d6f2ab77" + System.Environment.NewLine);
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
            Name = name;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "eb1375e5-3d44-4b68-8e9c-088fdac4db21" + System.Environment.NewLine);
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
            Size = size;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e0972cc7-419d-4c12-a260-6c7e2d65604b" + System.Environment.NewLine);
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
            Index = index;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "891c3a4e-df14-4a67-a03e-3339fc6a16d7" + System.Environment.NewLine);
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
            ArchiveIndex = archiveIndex;
        }
    }
}