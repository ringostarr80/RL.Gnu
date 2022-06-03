using System.Runtime.InteropServices;

namespace RL.Gnu
{
    /// <summary>
    /// This is a wrapper-class for several libc functions.
    /// </summary>
    public partial class libc
    {
		/// <summary>
		/// The <c>getpid</c> function returns the process ID of the current process. 
		/// </summary>
		/// <returns>an integer of the process ID.</returns>
		public static int getpid()
        {
            return libc_getpid();
        }

		/// <summary>
		/// The <c>GetPid</c> function returns the process ID of the current process. 
		/// </summary>
		/// <returns>an integer of the process ID.</returns>
		public static int GetPid()
        {
            return libc_getpid();
        }

		/// <summary>
		/// The <c>GetProcessID</c> function returns the process ID of the current process. 
		/// </summary>
		/// <returns>an integer of the process ID.</returns>
		public static int GetProcessID()
        {
            return libc_getpid();
        }

		/// <summary>
		/// The <c>getppid</c> function returns the process ID of the current process. 
		/// </summary>
		/// <returns>an integer of the process ID.</returns>
		public static int getppid()
        {
            return libc_getppid();
        }

		/// <summary>
		/// The <c>GetPPid</c> function returns the process ID of the current process. 
		/// </summary>
		/// <returns>an integer of the process ID.</returns>
		public static int GetPPid()
        {
            return libc_getppid();
        }

		/// <summary>
		/// The <c>GetParentProcessID</c> function returns the process ID of the current process. 
		/// </summary>
		/// <returns>an integer of the process ID.</returns>
		public static int GetParentProcessID()
        {
            return libc_getppid();
        }

        [DllImport(LIBC_FILE, EntryPoint = "getpid")]
        private static extern int libc_getpid();

		[DllImport(LIBC_FILE, EntryPoint = "getppid")]
        private static extern int libc_getppid();
    }
}
