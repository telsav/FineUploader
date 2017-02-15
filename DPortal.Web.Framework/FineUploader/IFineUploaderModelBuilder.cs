using System.Web;

namespace DPortal.Web.Framework.FineUploader
{
    public interface IFineUploaderModelBuilder
    {
        /// <summary>
        /// the name of control
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IFineUploaderModelBuilder Name(string name);
        /// <summary>
        /// set upload url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        IFineUploaderModelBuilder UploadAt(string url);
        /// <summary>
        /// Set remove file url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        IFineUploaderModelBuilder RemoveAt(string url);
        /// <summary>
        /// initil files url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        IFineUploaderModelBuilder InitialFiles(string url);

        /// <summary>
        /// Set UI Style
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        IFineUploaderModelBuilder SetUIStyle(UIStyle ui = UIStyle.Thumbnails);
        /// <summary>
        /// Allow file type to upload
        /// </summary>
        /// <param name="extensions">['jpg', 'jpeg', 'png', 'gif'] or []</param>
        /// <returns></returns>
        IFineUploaderModelBuilder SetAllowedFileExtensions(string extensions);
        /// <summary>
        /// Set allow upload or not
        /// </summary>
        /// <param name="allow"></param>
        /// <returns></returns>
        IFineUploaderModelBuilder SetAllowUpload(bool allow);

        /// <summary>
        /// Set callback when delete file completed
        /// </summary>
        /// <param name="callBack"></param>
        /// <returns></returns>
        IFineUploaderModelBuilder SetDeleteCallBack(string callBack);

        /// <summary>
        /// Set callback when upload file  completed
        /// </summary>
        /// <param name="callBack"></param>
        /// <returns></returns>
        IFineUploaderModelBuilder SetUploadCallBack(string callBack);

        /// <summary>
        /// render control
        /// </summary>
        /// <returns></returns>
        IHtmlString Render();

        /// <summary>
        /// set custom temlate of fineuploader control
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        IHtmlString Render(string template);
    }
}
