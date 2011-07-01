using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace UnStatic.IO
{
    public interface IFileInfo
    {
        string Name { get; }
        long Length { get; }
        string DirectoryName { get; }
        IDirectoryInfo Directory { get; }
        bool IsReadOnly { get; set; }
        bool Exists { get; }
        FileSecurity GetAccessControl();
        FileSecurity GetAccessControl(AccessControlSections includeSections);
        void SetAccessControl(FileSecurity fileSecurity);
        StreamReader OpenText();
        StreamWriter CreateText();
        StreamWriter AppendText();
        IFileInfo CopyTo(string destFileName);
        IFileInfo CopyTo(string destFileName, bool overwrite);
        FileStream Create();
        void Delete();

        [ComVisible(false)]
        void Decrypt();

        [ComVisible(false)]
        void Encrypt();

        FileStream Open(FileMode mode);
        FileStream Open(FileMode mode, FileAccess access);
        FileStream Open(FileMode mode, FileAccess access, FileShare share);
        FileStream OpenRead();
        FileStream OpenWrite();
        void MoveTo(string destFileName);

        [ComVisible(false)]
        IFileInfo Replace(string destinationFileName, string destinationBackupFileName);

        [ComVisible(false)]
        IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);

        string ToString();
    }
}