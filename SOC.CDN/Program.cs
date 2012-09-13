using System.IO;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.StorageClient;

namespace SOC.CDN
{
    class Program
    {
        static void Main()
        {
            var storageAccount =
                CloudStorageAccount.Parse(
                    "DefaultEndpointsProtocol=http;AccountName=socialthreads;AccountKey=VJbLtBeJB63NCSd7EfQS6hwK/qa15sDjIAhidoVJEBa7BzfQWw/6/uYHhCvXzJdtjU8RpjxTovLx6jHVbaD/cg==");
            //  CloudConfigurationManager.GetSetting("StorageConnectionString"));
            var blobClient = storageAccount.CreateCloudBlobClient();
            // Retrieve a reference to a container 

            var containers = new[] { "orders", "base", "themes", "external", "admin" };
            foreach (var containerName in containers)
            {
                var container = blobClient.GetContainerReference(containerName);

                // Create the container if it doesn't already exist
                container.CreateIfNotExist();

                container.SetPermissions(
                    new BlobContainerPermissions {PublicAccess = BlobContainerPublicAccessType.Blob});
                var root = string.Format("../../{0}/", containerName);
                var files = Directory.GetFiles(root, "*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    // Retrieve reference to a blob named "myblob"
                    var fileLower = file.ToLower();
                    var blob = container.GetBlobReference(file.Replace(root, string.Empty));
                    var parts = fileLower.Split('.');
                    var fileType = parts[parts.Length - 1];
                    switch(fileType)
                    {
                        case "css":
                            {
                                blob.Properties.ContentType = "text/css";
                                break;
                            }
                        case "js":
                            {
                                blob.Properties.ContentType = "application/x-javascript";
                                break;
                            }
                        case "png":
                            {
                                blob.Properties.ContentType = "image/png";
                                break;
                            }
                        case "gif":
                            {
                                blob.Properties.ContentType = "image/gif";
                                break;
                            }
                    }
                    // Create or overwrite the "myblob" blob with contents from a local file
                    using (var fileStream = File.OpenRead(fileLower))
                    {
                        fileStream.Name.ToLower();
                        blob.UploadFromStream(fileStream);
                    }
                }
            }
        }
    }
}
