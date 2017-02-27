﻿using System.Collections.Generic;
using Windows.Storage.Pickers;
using NextcloudClient.Types;

namespace NextcloudApp.Models
{
    public class FileUploadPageParameters : PageParameters<FileUploadPageParameters>
    {
        public ResourceInfo ResourceInfo { get; set; }
        public PickerLocationId PickerLocationId { get; set; }
        public List<string> FileTokens { get; set; }
    }
}
