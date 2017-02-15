namespace DPortal.Web.Framework.FineUploader
{
    public class FineUploaderModel
    {
        public string Name { get; set; }

        /// <summary>
        /// ex. 'jpg', 'jpeg', 'png', 'gif'
        /// </summary>
        public string AllowedFileExtensions { get; set; }
        public bool AllowUpload { get; set; }
        public string DeleteCallBack { get; set; }
        public string UploadCallBack { get; set; }
        public string UploadUrl { get; set; }
        public string RemoveUrl { get; set; }
        public string InitialFilesUrl { get; set; }
        public UIStyle UIStyle { get; set; }
    }
    public enum UIStyle
    {
        defaultUI,
        Thumbnails
    }
}
