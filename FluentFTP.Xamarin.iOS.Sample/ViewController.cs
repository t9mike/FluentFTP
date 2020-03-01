using Foundation;
using System;
using System.Threading;
using UIKit;

namespace FluentFTP.Xamarin.iOS.Sample
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            using (var ftp = new FtpClient("host", "user", "password"))
            {
                ftp.Connect();

                // upload a file to an existing FTP directory
                ftp.UploadFile(@"/Users/mmuegel/tmp/file2.txt", "file2-new.txt");

                //// upload a file and ensure the FTP directory is created on the server
                //ftp.UploadFile(@"D:\Github\FluentFTP\README.md", "/public_html/temp/README.md", FtpRemoteExists.Overwrite, true);

                //// upload a file and ensure the FTP directory is created on the server, verify the file after upload
                //ftp.UploadFile(@"D:\Github\FluentFTP\README.md", "/public_html/temp/README.md", FtpRemoteExists.Overwrite, true, FtpVerify.Retry);

            }

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}