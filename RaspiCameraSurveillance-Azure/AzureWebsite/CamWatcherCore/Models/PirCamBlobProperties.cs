﻿using System;

namespace CamWatcherCore.Models
{
    public class PirCamBlobProperties
    {
        public DateTimeOffset? DateModified;

        public Uri Uri;

        public PirCamBlobProperties(DateTimeOffset? dateModified, Uri uri)
        {
            DateModified = dateModified; Uri = uri;
        }
    }
}