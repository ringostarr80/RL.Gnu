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
		/// The chmod function sets the access permission bits for the file named by filename to mode.
		/// </summary>
		/// <returns>If filename is a symbolic link, chmod changes the permissions of the file pointed to by the link, not those of the link itself.
		/// This function returns 0 if successful and -1 if not. In addition to the usual file name errors (see File Name Errors), the following errno error conditions are defined for this function:</returns>
		public static int chmod(string filename, int mode)
        {
            return libc_chmod(filename, mode);
        }

		/// <summary>
		/// The chmod function sets the access permission bits for the file named by filename to mode.
		/// </summary>
		/// <returns>If filename is a symbolic link, chmod changes the permissions of the file pointed to by the link, not those of the link itself.
		/// This function returns 0 if successful and -1 if not. In addition to the usual file name errors (see File Name Errors), the following errno error conditions are defined for this function:</returns>
		public static int ChangeMode(string filename, int mode)
        {
            return libc_chmod(filename, mode);
        }

		/// <summary>
		/// The chmod function sets the access permission bits for the file named by filename to mode.
		/// </summary>
		/// <returns>If filename is a symbolic link, chmod changes the permissions of the file pointed to by the link, not those of the link itself.
		/// This function returns 0 if successful and -1 if not. In addition to the usual file name errors (see File Name Errors), the following errno error conditions are defined for this function:</returns>
		public static int ChangeMode(string filename, FileAccessPermissions mode)
        {
            return libc_chmod(filename, (int)mode);
        }

		[DllImport(LIBC_FILE, EntryPoint = "chmod")]
        private static extern int libc_chmod(string filename, int mode);
	}
}
