using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using DotNetOpenAuth.OAuth2;
using Google.Apis.Authentication;
using Google.Apis.Authentication.OAuth2;
using Google.Apis.Authentication.OAuth2.DotNetOpenAuth;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Util;
using Google.Apis.Helper;

namespace ClipboardApp
{
    public static class UploadToGoogleDrive
    {
        //The remote service on which all the requests are executed.
        
        public static DriveService Service { get; private set; }
        
        // Creates a concrete instance of the IAuthenticator to authenticate the user against Google OAuth2.0
        
        public static IAuthenticator CreateAuthenticator()
        {
            var provider = new NativeApplicationClient(GoogleAuthenticationServer.Description)
            {
                ClientIdentifier = ClientCredentials.CLIENT_ID,
                ClientSecret = ClientCredentials.CLIENT_SECRET
            };
            return new OAuth2Authenticator<NativeApplicationClient>(provider, GetAuthorization);
        }
        
        // Method to get the authorization from the user to access their Google Drive from the application
        
        private static IAuthorizationState GetAuthorization(NativeApplicationClient client)
        {
            const string STORAGE = "Clipboard";
            const string KEY = "1060399703595";
            string scope = DriveService.Scopes.Drive.GetStringValue();

            // Check if there is a cached refresh token available.
            IAuthorizationState state = AuthorizationMgr.GetCachedRefreshToken(STORAGE, KEY);
            if (state != null)
            {
                try
                {
                    client.RefreshToken(state);
                    MainWindow.authorizedLabel.Text = "Succesfully Authorized!";
                    //MessageBox.Show("Succesfully Authorized!");
                    return state; // Yes - we are done.
                }
                catch (DotNetOpenAuth.Messaging.ProtocolException ex)
                {
                    Debug.WriteLine("Using existing refresh token failed: " + ex.Message);
                }
            }

            // If we get here, there is no stored token. Retrieve the authorization from the user.
            state = AuthorizationMgr.RequestNativeAuthorization(client, scope);
            AuthorizationMgr.SetCachedRefreshToken(STORAGE, KEY, state);
            return state;
        }

        public static void Authorize()
        {
            Service = new DriveService(CreateAuthenticator());
            List<File> fileList = Utilities.RetrieveAllFiles(Service);
        }

        // Main method to upload the file
        public static void AuthorizeAndUpload()
        {
            // First, create a reference to the Drive service. 
            Service = new DriveService(CreateAuthenticator());

            //used to detect if the file already exist on Google Drive (body.Title)
            File body = new File();
            body.Title = System.IO.Path.GetFileName(MainWindow.FileName);
            body.Description = "A test document";
            body.MimeType = "text/plain";
            
            // Get a listing of the existing files...
            List<File> fileList = Utilities.RetrieveAllFiles(Service);

            // Set a flag to keep track of whether the file already exists in the drive
            bool fileExists = false;

            foreach (File item in fileList)
            {
                if (item.Title == body.Title)
                {
                    // File exists in the drive already!
                    fileExists = true;
                    var result = MessageBox.Show("The file already exists in your Google Drive. Do you wish to overwrite it?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            Utilities.UpdateFile(Service, item.Id, item.Title, item.Description, item.MimeType, MainWindow.FileName, true);
                            break;
                        case DialogResult.No:
                            Utilities.InsertFile(Service, System.IO.Path.GetFileName(MainWindow.FileName), "An uploaded document", "", "text/plain", MainWindow.FileName);
                            break;
                        default:
                            return;
                    }
                    break;
                }
            }

            // Check to see if the file exist. If not, it is a new file and must be uploaded.
            if (!fileExists)
            {
                Utilities.InsertFile(Service, System.IO.Path.GetFileName(MainWindow.FileName), "An uploaded document", "", "text/plain", MainWindow.FileName);
            }

            MessageBox.Show("Upload Complete!");
        }
    }
}
