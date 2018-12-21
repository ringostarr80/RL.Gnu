using System;
using System.IO;

using RL.Gnu;
using NUnit;
using NUnit.Framework;

namespace libc_nunit
{
	[TestFixture]
	public class SymbolicLinkTest
	{
		private string _tmpFilename = "foo.txt";
		private string _symbolicLink = "bar.txt";

		private int CreateFileAndSymbolicLink(string filename, string symbolicLink)
		{
			if (File.Exists(filename)) {
				File.Delete(filename);
			}
			if (File.Exists(symbolicLink)) {
				File.Delete(symbolicLink);
			}
			File.WriteAllText(filename, "foo content");
			return libc.SymbolicLink(filename, symbolicLink);
		}

		private void DeleteFileAndSymbolicLink(string filename, string symbolicLink)
		{
			File.Delete(filename);
			File.Delete(symbolicLink);
		}

		[Test]
        public void TestDotNetLikeSymbolicLink()
        {
			var symLinkResult = this.CreateFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
			Assert.AreEqual(0, symLinkResult);

			this.DeleteFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
		}

		[Test]
		public void TestDotNetLikeReadLink()
		{
			var symLinkResult = this.CreateFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
			Assert.AreEqual(0, symLinkResult);
			var link = libc.ReadLink(this._symbolicLink);
			Assert.AreEqual("foo.txt", link);

			this.DeleteFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
		}

		[Test]
		public void TestDotNetLikeCanonicalizeFileName()
		{
			var symLinkResult = this.CreateFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
			Assert.AreEqual(0, symLinkResult);
			var canonicalizedFilename = libc.CanonicalizeFileName(this._symbolicLink);
			Assert.IsTrue(canonicalizedFilename.Contains("foo.txt"));

			this.DeleteFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
		}

		[Test]
		public void TestDotNetLikeRealPath()
		{
			var symLinkResult = this.CreateFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
			Assert.AreEqual(0, symLinkResult);
			var canonicalizedFilename = libc.RealPath(this._symbolicLink);
			Assert.IsTrue(canonicalizedFilename.Contains("foo.txt"));

			this.DeleteFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
		}
	}
}
