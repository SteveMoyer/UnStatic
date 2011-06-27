using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime;
using System.Security;
using System.Security.AccessControl;
using System.Text;

namespace UnStatic.IO
{
    public interface IFile
    {
        [SecuritySafeCritical]
        StreamReader OpenText(string path);

        [SecuritySafeCritical]
        StreamWriter CreateText(string path);

        [SecuritySafeCritical]
        StreamWriter AppendText(string path);

        void Copy(string sourceFileName, string destFileName);
        void Copy(string sourceFileName, string destFileName, bool overwrite);

        [SecuritySafeCritical]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        FileStream Create(string path);

        [SecuritySafeCritical]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        FileStream Create(string path, int bufferSize);

        [SecuritySafeCritical]
        FileStream Create(string path, int bufferSize, FileOptions options);

        FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity fileSecurity);

        [SecuritySafeCritical]
        void Delete(string path);

        [SecuritySafeCritical]
        void Decrypt(string path);

        [SecuritySafeCritical]
        void Encrypt(string path);

        [SecuritySafeCritical]
        bool Exists(string path);

        [SecuritySafeCritical]
        FileStream Open(string path, FileMode mode);

        [SecuritySafeCritical]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        FileStream Open(string path, FileMode mode, FileAccess access);

        [SecuritySafeCritical]
        FileStream Open(string path, FileMode mode, FileAccess access, FileShare share);

        void SetCreationTime(string path, DateTime creationTime);

        [SecuritySafeCritical]
        void SetCreationTimeUtc(string path, DateTime creationTimeUtc);

        [SecuritySafeCritical]
        DateTime GetCreationTime(string path);

        [SecuritySafeCritical]
        DateTime GetCreationTimeUtc(string path);

        void SetLastAccessTime(string path, DateTime lastAccessTime);

        [SecuritySafeCritical]
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);

        [SecuritySafeCritical]
        DateTime GetLastAccessTime(string path);

        [SecuritySafeCritical]
        DateTime GetLastAccessTimeUtc(string path);

        void SetLastWriteTime(string path, DateTime lastWriteTime);

        [SecuritySafeCritical]
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);

        [SecuritySafeCritical]
        DateTime GetLastWriteTime(string path);

        [SecuritySafeCritical]
        DateTime GetLastWriteTimeUtc(string path);

        [SecuritySafeCritical]
        FileAttributes GetAttributes(string path);

        [SecuritySafeCritical]
        void SetAttributes(string path, FileAttributes fileAttributes);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        FileSecurity GetAccessControl(string path);

        FileSecurity GetAccessControl(string path, AccessControlSections includeSections);

        [SecuritySafeCritical]
        void SetAccessControl(string path, FileSecurity fileSecurity);

        [SecuritySafeCritical]
        FileStream OpenRead(string path);

        [SecuritySafeCritical]
        FileStream OpenWrite(string path);

        [SecuritySafeCritical]
        string ReadAllText(string path);

        [SecuritySafeCritical]
        string ReadAllText(string path, Encoding encoding);

        [SecuritySafeCritical]
        void WriteAllText(string path, string contents);

        [SecuritySafeCritical]
        void WriteAllText(string path, string contents, Encoding encoding);

        [SecuritySafeCritical]
        byte[] ReadAllBytes(string path);

        [SecuritySafeCritical]
        void WriteAllBytes(string path, byte[] bytes);

        [SecuritySafeCritical]
        string[] ReadAllLines(string path);

        [SecuritySafeCritical]
        string[] ReadAllLines(string path, Encoding encoding);

        [SecuritySafeCritical]
        IEnumerable<string> ReadLines(string path);

        [SecuritySafeCritical]
        IEnumerable<string> ReadLines(string path, Encoding encoding);

        [SecuritySafeCritical]
        void WriteAllLines(string path, string[] contents);

        [SecuritySafeCritical]
        void WriteAllLines(string path, string[] contents, Encoding encoding);

        [SecuritySafeCritical]
        void WriteAllLines(string path, IEnumerable<string> contents);

        [SecuritySafeCritical]
        void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding);

        [SecuritySafeCritical]
        void AppendAllText(string path, string contents);

        [SecuritySafeCritical]
        void AppendAllText(string path, string contents, Encoding encoding);

        [SecuritySafeCritical]
        void AppendAllLines(string path, IEnumerable<string> contents);

        [SecuritySafeCritical]
        void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding);

        [SecuritySafeCritical]
        void Move(string sourceFileName, string destFileName);

        void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName);

        [SecuritySafeCritical]
        void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName,
                                     bool ignoreMetadataErrors);
    }
}