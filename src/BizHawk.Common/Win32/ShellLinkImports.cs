#nullable disable
#pragma warning disable BHI1300 // explicit conversion operators w/ no checked variant

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable UnusedMember.Global
namespace BizHawk.Common
{
    public static class ShellLinkImports
    {
        /// <summary>The IShellLink interface allows Shell links to be created, modified, and resolved</summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct IShellLinkW
        {
            public static readonly Guid Guid = new("000214F9-0000-0000-C000-000000000046");
            [StructLayout(LayoutKind.Sequential)]
            public struct IShellLinkWVtbl
            {
                // IUnknown functions
                public delegate* unmanaged[Stdcall]<IShellLinkW*, in Guid, out IntPtr, int> QueryInterface;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, uint> AddRef;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, uint> Release;
                // IShellLinkW functions
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int, IntPtr, uint, int> GetPath;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, out IntPtr, int> GetIDList;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int> SetIDList;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int, int> GetDescription;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int> SetDescription;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int, int> GetWorkingDirectory;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int> SetWorkingDirectory;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int, int> GetArguments;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int> SetArguments;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, out short, int> GetHotkey;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, short, int> SetHotkey;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, out int, int> GetShowCmd;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, int, int> SetShowCmd;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int, out int, int> GetIconLocation;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int, int> SetIconLocation;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int, int> SetRelativePath;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int, int> Resolve;
                public delegate* unmanaged[Stdcall]<IShellLinkW*, IntPtr, int> SetPath;
            }

            public IShellLinkWVtbl* lpVtbl;
            public void GetPath(out string pszFile, int cch, uint fFlags)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3e1c6be7-b0db-4eb7-a07b-7a59f44a0445" + System.Environment.NewLine);
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
                var _pszFile = Marshal.AllocCoTaskMem(cch * sizeof(char));
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "719ad7b3-ca73-4319-8154-c117872da6e0" + System.Environment.NewLine);
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
                try
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "363343c9-792c-4132-8fba-a65ddab9d4ee" + System.Environment.NewLine);
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
                    var hr = lpVtbl->GetPath((IShellLinkW*)Unsafe.AsPointer(ref this), _pszFile, cch, IntPtr.Zero, fFlags);
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0b2ccb1a-0215-421d-aab7-09689eaf5796" + System.Environment.NewLine);
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
                    Marshal.ThrowExceptionForHR(hr);
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5d95369b-bf38-4625-af85-074a84c727e8" + System.Environment.NewLine);
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
                    pszFile = Marshal.PtrToStringUni(_pszFile);
                }
                finally
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1abbc264-e5e1-492c-849b-187f24d37f03" + System.Environment.NewLine);
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
                    Marshal.FreeCoTaskMem(_pszFile);
                }
            }
#if false
			public void Resolve(IntPtr hwnd, int fFlags)
			{
				var hr = lpVtbl->Resolve((IShellLinkW*)Unsafe.AsPointer(ref this), hwnd, fFlags);
				Marshal.ThrowExceptionForHR(hr);
			}
#endif
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct IPersistFile
        {
            public static readonly Guid Guid = new("0000010b-0000-0000-C000-000000000046");
            [StructLayout(LayoutKind.Sequential)]
            public struct IPersistFileVtbl
            {
                // IUnknown functions
                public delegate* unmanaged[Stdcall]<IPersistFile*, in Guid, out IntPtr, int> QueryInterface;
                public delegate* unmanaged[Stdcall]<IPersistFile*, uint> AddRef;
                public delegate* unmanaged[Stdcall]<IPersistFile*, uint> Release;
                // IPersist functions
                public delegate* unmanaged[Stdcall]<IPersistFile*, out Guid, int> GetClassID;
                // IPersistFile functions
                public delegate* unmanaged[Stdcall]<IPersistFile*, int> IsDirty;
                public delegate* unmanaged[Stdcall]<IPersistFile*, IntPtr, uint, int> Load;
                public delegate* unmanaged[Stdcall]<IPersistFile*, IntPtr, bool, int> Save;
                public delegate* unmanaged[Stdcall]<IPersistFile*, IntPtr, int> SaveCompleted;
                public delegate* unmanaged[Stdcall]<IPersistFile*, out IntPtr, int> GetCurFile;
            }

            public IPersistFileVtbl* lpVtbl;
            public void Load(string pszFileName, uint dwMode)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "39d93aa4-3d3b-482d-871b-506da3627f6c" + System.Environment.NewLine);
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
                var _pszFileName = Marshal.StringToCoTaskMemUni(pszFileName);
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9da3356a-3b06-42e5-8a8e-8ad00d43b33d" + System.Environment.NewLine);
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
                try
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "76bc9e1d-fa84-4e00-af46-8891b4f65a0d" + System.Environment.NewLine);
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
                    var hr = lpVtbl->Load((IPersistFile*)Unsafe.AsPointer(ref this), _pszFileName, dwMode);
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "68c9b0d6-cc97-4aaf-9b76-9ae1cb459434" + System.Environment.NewLine);
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
                    Marshal.ThrowExceptionForHR(hr);
                }
                finally
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "eb50d29a-b769-4cbd-98c8-39ba83248a21" + System.Environment.NewLine);
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
                    Marshal.FreeCoTaskMem(_pszFileName);
                }
            }
        }

        /// <remarks>CLSID_ShellLink from ShlGuid.h</remarks>
        public unsafe class ShellLink : IDisposable
        {
            public static readonly Guid Guid = new("00021401-0000-0000-C000-000000000046");
            public static explicit operator IShellLinkW*(ShellLink link) => link.SLI;
            public static explicit operator IPersistFile*(ShellLink link) => link.PFI;
            private IShellLinkW* SLI;
            private IPersistFile* PFI;
            public ShellLink()
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d525492c-88d9-4c57-b74f-4f33f765e344" + System.Environment.NewLine);
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
                var hr = Ole32Imports.CoCreateInstance(Guid, IntPtr.Zero, Ole32Imports.CLSCTX.INPROC_SERVER, IShellLinkW.Guid, out var psl);
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "dda8ee79-92f5-4a6b-b702-f3857ca00796" + System.Environment.NewLine);
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
                Marshal.ThrowExceptionForHR(hr);
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "99fe74c5-d7d1-4d68-8efc-091a5a84346c" + System.Environment.NewLine);
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
                var sli = (IShellLinkW*)psl;
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7668a79a-fc8d-4d27-a9d6-3b03de80d6a7" + System.Environment.NewLine);
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
                hr = sli->lpVtbl->QueryInterface(sli, in IPersistFile.Guid, out var ppf);
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a1d3a950-25ad-43e5-998b-8950a404ff9d" + System.Environment.NewLine);
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
                var hrEx = Marshal.GetExceptionForHR(hr);
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "17801124-c094-4006-99eb-042f9d17abee" + System.Environment.NewLine);
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
                if (hrEx != null)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a1d4fb5d-ed44-463c-acae-2b4769de29cc" + System.Environment.NewLine);
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
                    sli->lpVtbl->Release(sli);
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f0f5499e-cb66-4005-82f9-04b64ae4cf93" + System.Environment.NewLine);
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
                    throw hrEx;
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e3090e2d-3c61-4189-be18-43e8dd9b7f0b" + System.Environment.NewLine);
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
                SLI = sli;
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f5ce0275-a9c4-464b-8f16-8bab66dc9a67" + System.Environment.NewLine);
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
                PFI = (IPersistFile*)ppf;
            }

            public void Dispose()
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0af8d8b5-4f8d-4c2b-8fc0-1e03383a9f9c" + System.Environment.NewLine);
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
                if (PFI != null)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b1603313-5cf4-4a4b-876e-921269cad3f1" + System.Environment.NewLine);
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
                    PFI->lpVtbl->Release(PFI);
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7e66a1aa-c574-4218-a606-f38da0735988" + System.Environment.NewLine);
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
                    PFI = null;
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3668732b-f241-445c-b198-3107fa969d6b" + System.Environment.NewLine);
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
                if (SLI != null)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "84738e16-5e4b-4689-b0f8-be61f2a64fda" + System.Environment.NewLine);
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
                    SLI->lpVtbl->Release(SLI);
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c81bf3f5-a801-46da-9dad-a19b817f6d47" + System.Environment.NewLine);
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
                    SLI = null;
                }
            }
        }
    }
}