using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace UnStatic.IO
{
    public interface IDirectoryInfo
    {
        string Name { get; }
        IDirectoryInfo Parent { get; }
        bool Exists { get; }
        IDirectoryInfo Root { get; }
        IDirectoryInfo CreateSubdirectory(string path);
        IDirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity);
        void Create();
        void Create(DirectorySecurity directorySecurity);
        DirectorySecurity GetAccessControl();
        DirectorySecurity GetAccessControl(AccessControlSections includeSections);
        void SetAccessControl(DirectorySecurity directorySecurity);
        IFileInfo[] GetFiles(string searchPattern);
        IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption);
        IFileInfo[] GetFiles();
        IDirectoryInfo[] GetDirectories();
        FileSystemInfo[] GetFileSystemInfos(string searchPattern);
        FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);
        FileSystemInfo[] GetFileSystemInfos();
        IDirectoryInfo[] GetDirectories(string searchPattern);
        IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption);
        IEnumerable<IDirectoryInfo> EnumerateDirectories();
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern);
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);
        IEnumerable<IFileInfo> EnumerateFiles();
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern);
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption);
        IEnumerable<FileSystemInfo> EnumerateFileSystemInfos();
        IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern);
        IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);
        void MoveTo(string destDirName);
        void Delete();
        void Delete(bool recursive);
        string ToString();
    }
}