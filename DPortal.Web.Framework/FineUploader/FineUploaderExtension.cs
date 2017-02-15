using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace DPortal.Web.Framework.FineUploader
{
    public static class FineUploaderExtension
    {
        public static IFineUploaderModelBuilder FineUploader<TModel>(this HtmlHelper<TModel> helper)
        {
            return new FineUploaderModelBuilder(helper);
        }

        public static long GetFileSizeOnDisk(this string file)
        {
            FileInfo info = new FileInfo(file);
            if (!info.Exists)
                return 0;
            uint dummy, sectorsPerCluster, bytesPerSector;
            int result = GetDiskFreeSpaceW(info.Directory.Root.FullName, out sectorsPerCluster, out bytesPerSector, out dummy, out dummy);
            if (result == 0) throw new Win32Exception();
            uint clusterSize = sectorsPerCluster * bytesPerSector;
            uint hosize;
            uint losize = GetCompressedFileSizeW(file, out hosize);
            long size;
            size = (long)hosize << 32 | losize;
            return ((size + clusterSize - 1) / clusterSize) * clusterSize;
        }

        [DllImport("kernel32.dll")]
        static extern uint GetCompressedFileSizeW([In, MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
           [Out, MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        static extern int GetDiskFreeSpaceW([In, MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName,
           out uint lpSectorsPerCluster, out uint lpBytesPerSector, out uint lpNumberOfFreeClusters,
           out uint lpTotalNumberOfClusters);
    }
}
