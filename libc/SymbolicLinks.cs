using System.Runtime.InteropServices;
using System.Text;

namespace RL.Gnu
{
	/// <summary>
	/// This is a wrapper-class for several libc functions.
	/// </summary>
	public partial class LibC
	{
		/// <summary>
		/// The <c>canonicalize_file_name</c> function returns the absolute name of the file named by name which contains no ., .. components nor any repeated path separators (/) or symlinks. The result is passed back as the return value of the function in a block of memory allocated with malloc. If the result is not used anymore the memory should be freed with a call to free.
		/// </summary>
		/// <returns>If any of the path components are missing the function returns a NULL pointer. This is also what is returned if the length of the path reaches or exceeds PATH_MAX characters. In any case errno is set accordingly.</returns>
		public static string canonicalize_file_name(string name)
        {
            return libc_canonicalize_file_name(name);
        }

		/// <summary>
		/// The <c>canonicalize_file_name</c> function returns the absolute name of the file named by name which contains no ., .. components nor any repeated path separators (/) or symlinks. The result is passed back as the return value of the function in a block of memory allocated with malloc. If the result is not used anymore the memory should be freed with a call to free.
		/// </summary>
		/// <returns>If any of the path components are missing the function returns a NULL pointer. This is also what is returned if the length of the path reaches or exceeds PATH_MAX characters. In any case errno is set accordingly.</returns>
		public static string CanonicalizeFileName(string name)
        {
            return libc_canonicalize_file_name(name);
        }

		/// <summary>
		/// The <c>canonicalize_file_name</c> function returns the absolute name of the file named by name which contains no ., .. components nor any repeated path separators (/) or symlinks. The result is passed back as the return value of the function in a block of memory allocated with malloc. If the result is not used anymore the memory should be freed with a call to free.
		/// </summary>
		/// <returns>If any of the path components are missing the function returns a NULL pointer. This is also what is returned if the length of the path reaches or exceeds PATH_MAX characters. In any case errno is set accordingly.</returns>
		public static string realpath(string name)
        {
			return libc_realpath(name);
		}

		/// <summary>
		/// The <c>canonicalize_file_name</c> function returns the absolute name of the file named by name which contains no ., .. components nor any repeated path separators (/) or symlinks. The result is passed back as the return value of the function in a block of memory allocated with malloc. If the result is not used anymore the memory should be freed with a call to free.
		/// </summary>
		/// <returns>If any of the path components are missing the function returns a NULL pointer. This is also what is returned if the length of the path reaches or exceeds PATH_MAX characters. In any case errno is set accordingly.</returns>
		public static void realpath(string name, out string resolved)
        {
			resolved = libc_realpath(name);
		}

		/// <summary>
		/// The <c>canonicalize_file_name</c> function returns the absolute name of the file named by name which contains no ., .. components nor any repeated path separators (/) or symlinks. The result is passed back as the return value of the function in a block of memory allocated with malloc. If the result is not used anymore the memory should be freed with a call to free.
		/// </summary>
		/// <returns>If any of the path components are missing the function returns a NULL pointer. This is also what is returned if the length of the path reaches or exceeds PATH_MAX characters. In any case errno is set accordingly.</returns>
		public static string RealPath(string name)
        {
			return libc_realpath(name);
        }

		/// <summary>
		/// The <c>readlink</c> function gets the value of the symbolic link filename. The file name that the link points to is copied into buffer. This file name string is not null-terminated; readlink normally returns the number of characters copied. The size argument specifies the maximum number of characters to copy, usually the allocation size of buffer.
		/// </summary>
		/// <returns>If the return value equals size, you cannot tell whether or not there was room to return the entire name. So make a bigger buffer and call readlink again. Here is an example:</returns>
		public static int readlink(string filename, out string buffer, int size)
        {
			var bytes = new byte[size];
            var result = libc_readlink(filename, bytes, size);
			if (result < 0) {
				buffer = string.Empty;
				return result;
			}
			buffer = Encoding.UTF8.GetString(bytes).Trim(new char[] { '\0', ' ', '\t', '\n', '\r' });
			return result;
		}

		/// <summary>
		/// The <c>readlink</c> function gets the value of the symbolic link filename. The file name that the link points to is copied into buffer. This file name string is not null-terminated; readlink normally returns the number of characters copied. The size argument specifies the maximum number of characters to copy, usually the allocation size of buffer.
		/// </summary>
		/// <returns>If the return value equals size, you cannot tell whether or not there was room to return the entire name. So make a bigger buffer and call readlink again. Here is an example:</returns>
		public static string ReadLink(string filename)
        {
			var size = 100;
			while (true)
			{
				var buffer = new byte[size];
				var result = libc_readlink(filename, buffer, size);
				if (result < 0)
				{
					return string.Empty;
				}
				if (result < size)
				{
					return Encoding.UTF8.GetString(buffer).Trim(new char[] { '\0', ' ', '\t', '\n', '\r' });
				}
				size *= 2;
			}
		}

		/// <summary>
		/// The <c>symlink</c> function makes a symbolic link to oldname named newname.
		/// </summary>
		/// <returns>The normal return value from symlink is 0. A return value of -1 indicates an error. In addition to the usual file name syntax errors (see File Name Errors), the following errno error conditions are defined for this function:</returns>
		public static int symlink(string oldname, string newname)
        {
            return libc_symlink(oldname, newname);
        }

		/// <summary>
		/// The <c>symlink</c> function makes a symbolic link to oldname named newname.
		/// </summary>
		/// <returns>The normal return value from symlink is 0. A return value of -1 indicates an error. In addition to the usual file name syntax errors (see File Name Errors), the following errno error conditions are defined for this function:</returns>
		public static int SymLink(string oldname, string newname)
        {
            return libc_symlink(oldname, newname);
        }

		/// <summary>
		/// The <c>symlink</c> function makes a symbolic link to oldname named newname.
		/// </summary>
		/// <returns>The normal return value from symlink is 0. A return value of -1 indicates an error. In addition to the usual file name syntax errors (see File Name Errors), the following errno error conditions are defined for this function:</returns>
		public static int SymbolicLink(string oldname, string newname)
        {
            return libc_symlink(oldname, newname);
        }

		[DllImport(LIBC_FILE, EntryPoint = "canonicalize_file_name")]
        private static extern string libc_canonicalize_file_name(string name);

		[DllImport(LIBC_FILE, EntryPoint = "readlink")]
        private static extern int libc_readlink(string filename, byte[] buffer, int size);

		[DllImport(LIBC_FILE, EntryPoint = "realpath")]
        private static extern string libc_realpath(string name, byte[] resolved = null);

		[DllImport(LIBC_FILE, EntryPoint = "symlink")]
        private static extern int libc_symlink(string oldname, string newname);
	}
}
