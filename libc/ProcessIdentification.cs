using System;
using System.Runtime.InteropServices;

namespace RL.Gnu
{
    /// <summary>
    /// This is a wrapper-class for several libc functions.
    /// </summary>
    public partial class libc
    {
		/// <summary>
		/// The getpid function returns the process ID of the current process. 
		/// </summary>
		/// <returns>an integer of the process ID.</returns>
		public static int getpid()
        {
            return libc_getpid();
        }

		/// <summary>
		/// The GetPid function returns the process ID of the current process. 
		/// </summary>
		/// <returns>an integer of the process ID.</returns>
		public static int GetPid()
        {
            return libc_getpid();
        }

		/// <summary>
		/// The getppid function returns the process ID of the current process. 
		/// </summary>
		/// <returns>an integer of the process ID.</returns>
		public static int getppid()
        {
            return libc_getppid();
        }

		/// <summary>
		/// The GetPPid function returns the process ID of the current process. 
		/// </summary>
		/// <returns>an integer of the process ID.</returns>
		public static int GetPPid()
        {
            return libc_getppid();
        }

        [DllImport(LIBC_FILE, EntryPoint = "getpid")]
        private static extern int libc_getpid();

		[DllImport(LIBC_FILE, EntryPoint = "getppid")]
        private static extern int libc_getppid();
    }
}
