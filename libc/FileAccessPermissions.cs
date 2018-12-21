using System;

namespace RL.Gnu
{
	/// <summary>
	/// 
	/// </summary>
	[Flags]
	public enum FileAccessPermissions
	{
		/// <summary>
		/// 
		/// </summary>
		UserRead = 256, // 400
		/// <summary>
		/// 
		/// </summary>
		UserWrite = 128, // 200
		/// <summary>
		/// 
		/// </summary>
		UserExecute = 64, // 100
		/// <summary>
		/// 
		/// </summary>
		UserReadWrite = 384, // 600
		/// <summary>
		/// 
		/// </summary>
		UserReadExecute = 320, // 500
		/// <summary>
		/// 
		/// </summary>
		UserReadWriteExecute = 448, // 700
		/// <summary>
		/// 
		/// </summary>
		GroupRead = 32, // 040
		/// <summary>
		/// 
		/// </summary>
		GroupWrite = 16, // 020
		/// <summary>
		/// 
		/// </summary>
		GroupExecute = 8, // 010
		/// <summary>
		/// 
		/// </summary>
		GroupReadWrite = 48, // 060
		/// <summary>
		/// 
		/// </summary>
		GroupReadExecute = 40, // 050
		/// <summary>
		/// 
		/// </summary>
		GroupReadWriteExecute = 56, // 070
		/// <summary>
		/// 
		/// </summary>
		OtherRead = 4, // 004
		/// <summary>
		/// 
		/// </summary>
		OtherWrite = 2, // 002
		/// <summary>
		/// 
		/// </summary>
		OtherExecute = 1, // 001
		/// <summary>
		/// 
		/// </summary>
		OtherReadWrite = 6, // 006
		/// <summary>
		/// 
		/// </summary>
		OtherReadExecute = 5, // 005
		/// <summary>
		/// 
		/// </summary>
		OtherReadWriteExecute = 7 // 007
	}
}
