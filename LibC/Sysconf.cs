namespace RL.Gnu
{
	/// <summary>
	/// Here are the symbolic constants for use as the parameter argument to sysconf. The values are all integer constants (more specifically, enumeration type values).
	/// </summary>
	public enum Sysconf
	{
		/// <summary>
		/// Inquire about the parameter corresponding to ARG_MAX.
		/// </summary>
		ARG_MAX = 0,
		/// <summary>
		/// Inquire about the parameter corresponding to CHILD_MAX.
		/// </summary>
		CHILD_MAX = 1,
		/// <summary>
		/// Inquire about the number of clock ticks per second; see CPU Time. The corresponding parameter CLK_TCK is obsolete.
		/// </summary>
		CLK_TCK = 2,
		/// <summary>
		/// Inquire about the parameter corresponding to NGROUPS_MAX.
		/// </summary>
		NGROUPS_MAX = 3,
		/// <summary>
		/// Inquire about the parameter corresponding to OPEN_MAX.
		/// </summary>
		OPEN_MAX = 4,
		/// <summary>
		/// Inquire about the parameter corresponding to STREAM_MAX.
		/// </summary>
		STREAM_MAX = 5,
		/// <summary>
		/// Inquire about the parameter corresponding to TZNAME_MAX.
		/// </summary>
		TZNAME_MAX = 6,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_JOB_CONTROL.
		/// </summary>
		JOB_CONTROL = 7,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_SAVED_IDS.
		/// </summary>
		SAVED_IDS = 8,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_REALTIME_SIGNALS.
		/// </summary>
		REALTIME_SIGNALS = 9,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_PRIORITY_SCHEDULING.
		/// </summary>
		PRIORITY_SCHEDULING = 10,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_TIMERS.
		/// </summary>
		TIMERS = 11,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_ASYNCHRONOUS_IO.
		/// </summary>
		ASYNCHRONOUS_IO = 12,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_PRIORITIZED_IO.
		/// </summary>
		PRIORITIZED_IO = 13,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_SYNCHRONIZED_IO.
		/// </summary>
		SYNCHRONIZED_IO = 14,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_FSYNC.
		/// </summary>
		FSYNC = 15,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_MAPPED_FILES.
		/// </summary>
		MAPPED_FILES = 16,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_MEMLOCK.
		/// </summary>
		MEMLOCK = 17,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_MEMLOCK_RANGE.
		/// </summary>
		MEMLOCK_RANGE = 18,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_MEMORY_PROTECTION.
		/// </summary>
		MEMORY_PROTECTION = 19,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_MESSAGE_PASSING.
		/// </summary>
		MESSAGE_PASSING = 20,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_SEMAPHORES.
		/// </summary>
		SEMAPHORES = 21,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_SHARED_MEMORY_OBJECTS.
		/// </summary>
		SHARED_MEMORY_OBJECTS = 22,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_AIO_LISTIO_MAX.
		/// </summary>
		AIO_LISTIO_MAX = 23,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_AIO_MAX.
		/// </summary>
		AIO_MAX = 24,
		/// <summary>
		/// Inquire about the value by which a process can decrease its asynchronous I/O priority level from its own scheduling priority. This corresponds to the run-time invariant value AIO_PRIO_DELTA_MAX.
		/// </summary>
		AIO_PRIO_DELTA_MAX = 25,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_DELAYTIMER_MAX.
		/// </summary>
		DELAYTIMER_MAX = 26,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_MQ_OPEN_MAX.
		/// </summary>
		MQ_OPEN_MAX = 27,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_MQ_PRIO_MAX.
		/// </summary>
		MQ_PRIO_MAX = 28,
		/// <summary>
		/// Inquire about the version number of POSIX.1 that the library and kernel support.
		/// </summary>
		VERSION = 29,
		/// <summary>
		/// Inquire about the virtual memory page size of the machine. getpagesize returns the same value (see Query Memory Parameters).
		/// </summary>
		PAGESIZE = 30,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_RTSIG_MAX.
		/// </summary>
		RTSIG_MAX = 31,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_SEM_NSEMS_MAX.
		/// </summary>
		SEM_NSEMS_MAX = 32,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_SEM_VALUE_MAX.
		/// </summary>
		SEM_VALUE_MAX = 33,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_SIGQUEUE_MAX.
		/// </summary>
		SIGQUEUE_MAX = 34,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_TIMER_MAX.
		/// </summary>
		TIMER_MAX = 35,
		/// <summary>
		/// Inquire about the maximum value of obase in the bc utility.
		/// </summary>
		BC_BASE_MAX = 36,
		/// <summary>
		/// Inquire about the maximum size of an array in the bc utility.
		/// </summary>
		BC_DIM_MAX = 37,
		/// <summary>
		/// Inquire about the maximum value of scale in the bc utility.
		/// </summary>
		BC_SCALE_MAX = 38,
		/// <summary>
		/// Inquire about the maximum size of a string constant in the bc utility.
		/// </summary>
		BC_STRING_MAX = 39,
		/// <summary>
		/// Inquire about the maximum number of weights that can necessarily be used in defining the collating sequence for a locale.
		/// </summary>
		COLL_WEIGHTS_MAX = 40,
		/// <summary>
		/// Inquire about the maximum number of expressions nested within parentheses when using the expr utility.
		/// </summary>
		EXPR_NEST_MAX = 42,
		/// <summary>
		/// Inquire about the maximum size of a text line that the POSIX.2 text utilities can handle.
		/// </summary>
		LINE_MAX = 43,
		/// <summary>
		/// Inquire about the version number of POSIX.2 that the system utilities support.
		/// </summary>
		TWO_VERSION = 46,
		/// <summary>
		/// Inquire about whether the system has the POSIX.2 C compiler command, c89.
		/// </summary>
		TWO_C_DEV = 48,
		/// <summary>
		/// Inquire about whether the system has the POSIX.2 Fortran compiler command, fort77.
		/// </summary>
		TWO_FORT_DEV = 49,
		/// <summary>
		/// Inquire about whether the system has the POSIX.2 asa command to interpret Fortran carriage control.
		/// </summary>
		TWO_FORT_RUN = 50,
		/// <summary>
		/// Inquire about whether the system has the POSIX.2 commands ar, make, and strip.
		/// </summary>
		TWO_SW_DEV = 51,
		/// <summary>
		/// Inquire about whether the system has the POSIX.2 localedef command.
		/// </summary>
		TWO_LOCALEDEF = 52,
		/// <summary>
		/// Inquire about the value associated with the T_IOV_MAX variable.
		/// </summary>
		IOV_MAX = 60,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_THREADS.
		/// </summary>
		THREADS = 67,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_THREAD_SAFE_FUNCTIONS.
		/// </summary>
		THREAD_SAFE_FUNCTIONS = 68,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_GETGR_R_SIZE_MAX.
		/// </summary>
		GETGR_R_SIZE_MAX = 69,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_GETPW_R_SIZE_MAX.
		/// </summary>
		GETPW_R_SIZE_MAX = 70,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_LOGIN_NAME_MAX.
		/// </summary>
		LOGIN_NAME_MAX = 71,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_TTY_NAME_MAX.
		/// </summary>
		TTY_NAME_MAX = 72,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_THREAD_DESTRUCTOR_ITERATIONS.
		/// </summary>
		THREAD_DESTRUCTOR_ITERATIONS = 73,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_THREAD_KEYS_MAX.
		/// </summary>
		THREAD_KEYS_MAX = 74,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_THREAD_STACK_MIN.
		/// </summary>
		THREAD_STACK_MIN = 75,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_THREAD_THREADS_MAX.
		/// </summary>
		THREAD_THREADS_MAX = 76,
		/// <summary>
		/// Inquire about the parameter corresponding to a _POSIX_THREAD_ATTR_STACKADDR.
		/// </summary>
		THREAD_ATTR_STACKADDR = 77,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_THREAD_ATTR_STACKSIZE.
		/// </summary>
		THREAD_ATTR_STACKSIZE = 78,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_THREAD_PRIORITY_SCHEDULING.
		/// </summary>
		THREAD_PRIORITY_SCHEDULING = 79,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_THREAD_PRIO_INHERIT.
		/// </summary>
		THREAD_PRIO_INHERIT = 80,
		/// <summary>
		/// Inquire about the parameter corresponding to _POSIX_THREAD_PRIO_PROTECT.
		/// </summary>
		THREAD_PRIO_PROTECT = 81,
		/// <summary>
		/// Inquire about the number of processors online.
		/// </summary>
		NPROCESSORS_ONLN = 84,
		/// <summary>
		/// Inquire about the number of functions which can be registered as termination functions for atexit; see Cleanups on Exit.
		/// </summary>
		ATEXIT_MAX = 87,
		/// <summary>
		/// Inquire about the parameter corresponding to _XOPEN_VERSION.
		/// </summary>
		XOPEN_VERSION = 89,
		/// <summary>
		/// Inquire about the parameter corresponding to _XOPEN_XCU_VERSION.
		/// </summary>
		XOPEN_XCU_VERSION = 90,
		/// <summary>
		/// Inquire about the parameter corresponding to _XOPEN_UNIX.
		/// </summary>
		XOPEN_UNIX = 91,
		/// <summary>
		/// Inquire about the parameter corresponding to _XOPEN_CRYPT. The GNU C Library no longer implements the _XOPEN_CRYPT extensions, so ‘sysconf (_SC_XOPEN_CRYPT)’ always returns -1.
		/// </summary>
		XOPEN_CRYPT = 92,
		/// <summary>
		/// Inquire about the parameter corresponding to _XOPEN_ENH_I18N.
		/// </summary>
		XOPEN_ENH_I18N = 93,
		/// <summary>
		/// Inquire about the parameter corresponding to _XOPEN_SHM.
		/// </summary>
		XOPEN_SHM = 94,
		/// <summary>
		/// Inquire about the parameter corresponding to _XOPEN_LEGACY.
		/// </summary>
		XOPEN_LEGACY = 129,
		/// <summary>
		/// Inquire about the parameter corresponding to _XOPEN_REALTIME.
		/// </summary>
		XOPEN_REALTIME = 130,
		/// <summary>
		/// Inquire about the parameter corresponding to _XOPEN_REALTIME_THREADS.
		/// </summary>
		XOPEN_REALTIME_THREADS = 131
	}
}