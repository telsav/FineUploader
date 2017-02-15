using System.Web;
using System.Web.Mvc.Html;

namespace DPortal.Web.Framework.FineUploader
{
    public class FineUploaderModelBuilder : IFineUploaderModelBuilder
    {
        private readonly System.Web.Mvc.HtmlHelper _helper;
        private string _name;
        private string _allowedFileExtensions;
        private string _uploadUrl;
        private string _removeUrl;
        private string _initialFilesUrl;
        private string _template = "_FineUploader";
        private UIStyle _uiStyle = UIStyle.Thumbnails;
        private bool _allowUpload = true;
        private string _deleteCallBack = string.Empty;
        private string _uploadCallBack = string.Empty;

        public FineUploaderModelBuilder(System.Web.Mvc.HtmlHelper helper)
        {
            _helper = helper;
        }

        public FineUploaderModel GetFineUploaderModel()
        {
            return new FineUploaderModel
            {
                Name = _name,
                AllowedFileExtensions = _allowedFileExtensions,
                AllowUpload = _allowUpload,
                DeleteCallBack = _deleteCallBack,
                UploadCallBack = _uploadCallBack,
                UploadUrl = _uploadUrl,
                RemoveUrl = _removeUrl,
                InitialFilesUrl = _initialFilesUrl,
                UIStyle = _uiStyle
            };
        }

        public IFineUploaderModelBuilder Name(string name)
        {
            _name = name;
            return this;
        }

        public IFineUploaderModelBuilder UploadAt(string url)
        {
            _uploadUrl = url;
            return this;
        }

        public IFineUploaderModelBuilder RemoveAt(string url)
        {
            _removeUrl = url;
            return this;
        }

        public IFineUploaderModelBuilder InitialFiles(string url)
        {
            _initialFilesUrl = url;
            return this;
        }

        public IFineUploaderModelBuilder SetUIStyle(UIStyle ui = UIStyle.Thumbnails)
        {
            _uiStyle = ui;
            return this;
        }

        public IFineUploaderModelBuilder SetDeleteCallBack(string callBack)
        {
            _deleteCallBack = callBack;
            return this;
        }

        public IFineUploaderModelBuilder SetUploadCallBack(string callBack)
        {
            _uploadCallBack = callBack;
            return this;
        }

        public IFineUploaderModelBuilder SetAllowUpload(bool allow)
        {
            _allowUpload = allow;
            return this;
        }

        public IFineUploaderModelBuilder SetAllowedFileExtensions(string extensions)
        {
            _allowedFileExtensions = extensions;
            return this;
        }

        public IHtmlString Render()
        {
            return _helper.Partial(_template, GetFineUploaderModel());
        }

        public IHtmlString Render(string template)
        {
            _template = template;
            return _helper.Partial(_template, GetFineUploaderModel());
        }
    }
}
