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
		/// The <c>getpagesize</c> function returns the page size of the process. This value is fixed for the runtime of the process but can vary in different runs of the application. 
		/// </summary>
		/// <returns>an integer of the page size.</returns>
		public static int getpagesize()
        {
            return libc_getpagesize();
        }

		/// <summary>
		/// The <c>getpagesize</c> function returns the page size of the process. This value is fixed for the runtime of the process but can vary in different runs of the application. 
		/// </summary>
		/// <returns>an integer of the page size.</returns>
		public static int GetPageSize()
        {
            return libc_getpagesize();
        }

		/// <summary>
		/// The <c>getpagesize</c> function returns the page size of the process. This value is fixed for the runtime of the process but can vary in different runs of the application. 
		/// </summary>
		/// <returns>an integer of the page size.</returns>
		public static long get_phys_pages()
        {
            return libc_get_phys_pages();
        }

		/// <summary>
		/// The <c>getpagesize</c> function returns the page size of the process. This value is fixed for the runtime of the process but can vary in different runs of the application. 
		/// </summary>
		/// <returns>an integer of the page size.</returns>
		public static long GetPhysPages()
        {
            return libc_get_phys_pages();
        }

		/// <summary>
		/// The <c>getpagesize</c> function returns the page size of the process. This value is fixed for the runtime of the process but can vary in different runs of the application. 
		/// </summary>
		/// <returns>an integer of the page size.</returns>
		public static long GetPhysicalPages()
        {
            return libc_get_phys_pages();
        }

		/// <summary>
		/// The <c>getpagesize</c> function returns the page size of the process. This value is fixed for the runtime of the process but can vary in different runs of the application. 
		/// </summary>
		/// <returns>an integer of the page size.</returns>
		public static long get_avphys_pages()
        {
            return libc_get_avphys_pages();
        }

		/// <summary>
		/// The <c>getpagesize</c> function returns the page size of the process. This value is fixed for the runtime of the process but can vary in different runs of the application. 
		/// </summary>
		/// <returns>an integer of the page size.</returns>
		public static long GetAvPhysPages()
        {
            return libc_get_avphys_pages();
        }

		/// <summary>
		/// The <c>getpagesize</c> function returns the page size of the process. This value is fixed for the runtime of the process but can vary in different runs of the application. 
		/// </summary>
		/// <returns>an integer of the page size.</returns>
		public static long GetAvailablePhysicalPages()
        {
            return libc_get_avphys_pages();
        }

		/// <summary>
		/// Widely available on System V derived systems is a method to get information about the physical memory the system has. The call
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns>returns the total number of pages of physical memory the system has. This does not mean all this memory is available. This information can be found using </returns>
		public static long sysconf(int parameter)
		{
			return libc_sysconf(parameter);
		}

		/// <summary>
		/// Widely available on System V derived systems is a method to get information about the physical memory the system has. The call
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns>returns the total number of pages of physical memory the system has. This does not mean all this memory is available. This information can be found using </returns>
		public static long Sysconf(int parameter)
		{
			return libc_sysconf(parameter);
		}

		/// <summary>
		/// Widely available on System V derived systems is a method to get information about the physical memory the system has. The call
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns>returns the total number of pages of physical memory the system has. This does not mean all this memory is available. This information can be found using </returns>
		public static long sysconf(Sysconf parameter)
		{
			return libc_sysconf((int)parameter);
		}

		/// <summary>
		/// Widely available on System V derived systems is a method to get information about the physical memory the system has. The call
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns>returns the total number of pages of physical memory the system has. This does not mean all this memory is available. This information can be found using </returns>
		public static long Sysconf(Sysconf parameter)
		{
			return libc_sysconf((int)parameter);
		}

		[DllImport(LIBC_FILE, EntryPoint = "getpagesize")]
        private static extern int libc_getpagesize();

		[DllImport(LIBC_FILE, EntryPoint = "get_avphys_pages")]
        private static extern long libc_get_avphys_pages();

		[DllImport(LIBC_FILE, EntryPoint = "get_phys_pages")]
        private static extern long libc_get_phys_pages();

		[DllImport(LIBC_FILE, EntryPoint = "sysconf")]
        private static extern long libc_sysconf(int parameter);
	}
}
