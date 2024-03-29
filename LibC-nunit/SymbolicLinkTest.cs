using System.IO;

using RL.Gnu;
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
			return LibC.SymbolicLink(filename, symbolicLink);
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
			Assert.That(symLinkResult, Is.Zero);

			this.DeleteFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
		}

		[Test]
		public void TestDotNetLikeReadLink()
		{
			var symLinkResult = this.CreateFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
			Assert.That(symLinkResult, Is.Zero);
			var link = LibC.ReadLink(this._symbolicLink);
			Assert.That(link, Is.EqualTo("foo.txt"));

			this.DeleteFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
		}

		[Test]
		public void TestDotNetLikeCanonicalizeFileName()
		{
			var symLinkResult = this.CreateFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
			Assert.That(symLinkResult, Is.Zero);
			var canonicalizedFilename = LibC.CanonicalizeFileName(this._symbolicLink);
			Assert.That(canonicalizedFilename, Does.Contain("foo.txt"));

			this.DeleteFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
		}

		[Test]
		public void TestDotNetLikeRealPath()
		{
			var symLinkResult = this.CreateFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
			Assert.That(symLinkResult, Is.Zero);
			var canonicalizedFilename = LibC.RealPath(this._symbolicLink);
			Assert.That(canonicalizedFilename, Does.Contain("foo.txt"));

			this.DeleteFileAndSymbolicLink(this._tmpFilename, this._symbolicLink);
		}
	}
}
