using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace UnStatic.IO
{
    public class FileInfo : IFileInfo
    {
        private readonly System.IO.FileInfo _fileInfo;

        public FileInfo(System.IO.FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
        }


        public FileInfo(string fileName)
        {
            _fileInfo = new System.IO.FileInfo(fileName);
        }

        public string Name
        {
            get { return _fileInfo.Name; }
        }

        public long Length
        {
            get { return _fileInfo.Length; }
        }

        public string DirectoryName
        {
            get { return DirectoryName; }
        }

        public DirectoryInfo Directory
        {
            get { return _fileInfo.Directory; }
        }

        public bool IsReadOnly
        {
            get { return _fileInfo.IsReadOnly; }
            set { _fileInfo.IsReadOnly = value; }
        }

        public bool Exists
        {
            get { return _fileInfo.Exists; }
        }

        public FileSecurity GetAccessControl()
        {
            return _fileInfo.GetAccessControl();
        }

        public FileSecurity GetAccessControl(AccessControlSections includeSections)
        {
            return _fileInfo.GetAccessControl(includeSections);
        }


        public void SetAccessControl(FileSecurity fileSecurity)
        {
            _fileInfo.SetAccessControl(fileSecurity);
        }


        public StreamReader OpenText()
        {
            return _fileInfo.OpenText();
        }

        public StreamWriter CreateText()
        {
            return _fileInfo.CreateText();
        }


        public StreamWriter AppendText()
        {
            return _fileInfo.AppendText();
        }

        public IFileInfo CopyTo(string destFileName)
        {
            return new FileInfo(_fileInfo.CopyTo(destFileName));
        }

        public IFileInfo CopyTo(string destFileName, bool overwrite)
        {
            return new FileInfo(_fileInfo.CopyTo(destFileName, overwrite));
        }


        public FileStream Create()
        {
            return _fileInfo.Create();
        }


        public void Delete()
        {
            _fileInfo.Delete();
        }

        [ComVisible(false)]
        public void Decrypt()
        {
            _fileInfo.Decrypt();
        }

        [ComVisible(false)]
        public void Encrypt()
        {
            _fileInfo.Decrypt();
        }

        public FileStream Open(FileMode mode)
        {
            return _fileInfo.Open(mode);
        }

        public FileStream Open(FileMode mode, FileAccess access)
        {
            return _fileInfo.Open(mode, access);
        }


        public FileStream Open(FileMode mode, FileAccess access, FileShare share)
        {
            return _fileInfo.Open(mode, access, share);
        }


        public FileStream OpenRead()
        {
            return _fileInfo.OpenRead();
        }


        public FileStream OpenWrite()
        {
            return _fileInfo.OpenWrite();
        }


        public void MoveTo(string destFileName)
        {
            _fileInfo.MoveTo(destFileName);
        }


        [ComVisible(false)]
        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
        {
            return new FileInfo(_fileInfo.Replace(destinationFileName, destinationBackupFileName));
        }

        [ComVisible(false)]
        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            return new FileInfo(_fileInfo.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors));
        }

        public override string ToString()
        {
            return _fileInfo.ToString();
        }
    }
}