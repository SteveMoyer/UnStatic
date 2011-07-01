using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;

namespace UnStatic.IO
{
    public class DirectoryInfo : IDirectoryInfo
    {
        private System.IO.DirectoryInfo _directoryInfo;

        public DirectoryInfo(string path)
        {
            _directoryInfo = new System.IO.DirectoryInfo(path);
        }
        public DirectoryInfo(System.IO.DirectoryInfo systemDirectoryInfo)
        {
            _directoryInfo = systemDirectoryInfo;
        }

        public  string Name { get { return _directoryInfo.Name; }
        }

        public IDirectoryInfo Parent
        {
            get { return new DirectoryInfo(_directoryInfo.Parent); }
        }

        public bool Exists
        {
            get { return _directoryInfo.Exists; }
        }

        public IDirectoryInfo Root
        {
            get { return new DirectoryInfo(_directoryInfo.Root); }
        }

        public IDirectoryInfo CreateSubdirectory(string path)
        {
            return new DirectoryInfo(_directoryInfo.CreateSubdirectory(path));
        }

        public IDirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity)
        {
            return new DirectoryInfo(_directoryInfo.CreateSubdirectory(path,directorySecurity));
        }

        public void Create()
        {
            _directoryInfo.Create();
        }

        public void Create(DirectorySecurity directorySecurity)
        {
            _directoryInfo.Create(directorySecurity);
        }

        public DirectorySecurity GetAccessControl()
        {
            return _directoryInfo.GetAccessControl();
        }

        public DirectorySecurity GetAccessControl(AccessControlSections includeSections)
        {
            return _directoryInfo.GetAccessControl(includeSections);
        }


        public void SetAccessControl(DirectorySecurity directorySecurity)
        {
            _directoryInfo.SetAccessControl(directorySecurity);
        }

        public IFileInfo[] GetFiles(string searchPattern)
        {
            return _directoryInfo.GetFiles(searchPattern).Select(f=>new FileInfo(f)).ToArray();
        }

        public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetFiles(searchPattern,searchOption).Select(f => new FileInfo(f)).ToArray();
        }

        public IFileInfo[] GetFiles()
        {
            return _directoryInfo.GetFiles().Select(f => new FileInfo(f)).ToArray();
        }

        public IDirectoryInfo[] GetDirectories()
        {
            return _directoryInfo.GetDirectories().Select(d => new DirectoryInfo(d)).ToArray();
        }

        public FileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
            return _directoryInfo.GetFileSystemInfos(searchPattern);
        }

        public FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetFileSystemInfos(searchPattern, searchOption);
        }

        public FileSystemInfo[] GetFileSystemInfos()
        {
            return _directoryInfo.GetFileSystemInfos();
        }

        public IDirectoryInfo[] GetDirectories(string searchPattern)
        {
            return _directoryInfo.GetDirectories(searchPattern).Select(d => new DirectoryInfo(d)).ToArray();
        }

        public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetDirectories(searchPattern,searchOption).Select(d => new DirectoryInfo(d)).ToArray();
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories()
        {
            return GetDirectories().AsEnumerable();
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return GetDirectories(searchPattern).AsEnumerable();
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            return GetDirectories(searchPattern,searchOption).AsEnumerable();
        }

        public IEnumerable<IFileInfo> EnumerateFiles()
        {
            return GetFiles().AsEnumerable();
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
        {
            return GetFiles(searchPattern).AsEnumerable();
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
        {
            return GetFiles(searchPattern, searchOption).AsEnumerable();
        }

        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos()
        {
            return _directoryInfo.GetFileSystemInfos().AsEnumerable();
        }

        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            return _directoryInfo.GetFileSystemInfos(searchPattern).AsEnumerable();
        }

        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetFileSystemInfos(searchPattern,searchOption ).AsEnumerable();
        }

        public void MoveTo(string destDirName)
        {
            _directoryInfo.MoveTo(destDirName);
        }

        public  void Delete()
        {
            _directoryInfo.Delete();
        }

        public void Delete(bool recursive)
        {
            _directoryInfo.Delete(recursive);
        }

        public override string ToString()
        {
            return _directoryInfo.ToString();
        }
    }
}