using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace UnStatic.IO
{
    public class Directory : IDirectory
    {
        public IDirectoryInfo GetParent(string path)
        {
            return new DirectoryInfo( System.IO.Directory.GetParent(path));
        }

        public IDirectoryInfo CreateDirectory(string path)
        {
            return new DirectoryInfo(System.IO.Directory.CreateDirectory(path));
        }

        public IDirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity)
        {
            return new DirectoryInfo(System.IO.Directory.CreateDirectory(path, directorySecurity));
        }

        public bool Exists(string path)
        {
            return System.IO.Directory.Exists(path);
        }

        public void SetCreationTime(string path, DateTime creationTime)
        {
            System.IO.Directory.SetCreationTime(path,creationTime);
        }

        public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            System.IO.Directory.SetCreationTimeUtc(path,creationTimeUtc);
        }

        public DateTime GetCreationTime(string path)
        {
            return System.IO.Directory.GetCreationTime(path);
        }

        public DateTime GetCreationTimeUtc(string path)
        {
            return System.IO.Directory.GetCreationTimeUtc(path);
        }

        public void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            System.IO.Directory.SetLastWriteTime(path, lastWriteTime);
        }

        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            System.IO.Directory.SetLastWriteTimeUtc(path,lastWriteTimeUtc);
        }

        public DateTime GetLastWriteTime(string path)
        {
            return System.IO.Directory.GetLastWriteTime(path);
        }

        public DateTime GetLastWriteTimeUtc(string path)
        {
            return System.IO.Directory.GetLastWriteTimeUtc(path);
        }

        public void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            System.IO.Directory.SetLastAccessTime(path,lastAccessTime);
        }

        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            System.IO.Directory.SetLastAccessTimeUtc(path,lastAccessTimeUtc);
        }

        public DateTime GetLastAccessTime(string path)
        {
            return System.IO.Directory.GetLastAccessTime(path);
        }

        public DateTime GetLastAccessTimeUtc(string path)
        {
            return System.IO.Directory.GetLastAccessTimeUtc(path);
        }

        public DirectorySecurity GetAccessControl(string path)
        {
            return System.IO.Directory.GetAccessControl(path);
        }

        public DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
        {
            return System.IO.Directory.GetAccessControl(path, includeSections);
        }

        public void SetAccessControl(string path, DirectorySecurity directorySecurity)
        {
            System.IO.Directory.SetAccessControl(path,directorySecurity);
        }

        public string[] GetFiles(string path)
        {
            return System.IO.Directory.GetFiles(path);
        }

        public string[] GetFiles(string path, string searchPattern)
        {
            return System.IO.Directory.GetFiles(path, searchPattern);
        }

        public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetFiles(path, searchPattern, searchOption);
        }

        public string[] GetDirectories(string path)
        {
            return System.IO.Directory.GetDirectories(path);
        }

        public string[] GetDirectories(string path, string searchPattern)
        {
            return System.IO.Directory.GetDirectories(path, searchPattern);
        }

        public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetDirectories(path, searchPattern, searchOption);
        }

        public string[] GetFileSystemEntries(string path)
        {
            return System.IO.Directory.GetFileSystemEntries(path);
        }

        public string[] GetFileSystemEntries(string path, string searchPattern)
        {
            return System.IO.Directory.GetFileSystemEntries(path, searchPattern);
        }

        public string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetFileSystemEntries(path, searchPattern, searchOption);
        }

        public IEnumerable<string> EnumerateDirectories(string path)
        {
            return System.IO.Directory.EnumerateDirectories(path);
        }

        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        {
            return System.IO.Directory.EnumerateDirectories(path, searchPattern);
        }

        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.EnumerateDirectories(path, searchPattern, searchOption);
        }

        public IEnumerable<string> EnumerateFiles(string path)
        {
            return System.IO.Directory.EnumerateFiles(path);
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            return System.IO.Directory.EnumerateFiles(path, searchPattern);
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.EnumerateFiles(path, searchPattern, searchOption);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path)
        {
            return EnumerateFileSystemEntries(path);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        {
            return EnumerateFileSystemEntries(path, searchPattern);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return EnumerateFileSystemEntries(path, searchPattern, searchOption);
        }

        public string[] GetLogicalDrives()
        {
            return System.IO.Directory.GetLogicalDrives();
        }

        public string GetDirectoryRoot(string path)
        {
            return System.IO.Directory.GetDirectoryRoot(path    );
        }

        public string GetCurrentDirectory()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }

        public void SetCurrentDirectory(string path)
        {
            System.IO.Directory.SetCurrentDirectory(path);
        }

        public void Move(string sourceDirName, string destDirName)
        {
            System.IO.Directory.Move(sourceDirName,destDirName);
        }

        public void Delete(string path)
        {
            System.IO.Directory.Delete(path);
        }

        public void Delete(string path, bool recursive)
        {
            System.IO.Directory.Delete(path,recursive);
        }
    }
}