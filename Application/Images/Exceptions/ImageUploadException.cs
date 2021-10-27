﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Images.Exceptions
{
    public class ImageUploadException : Exception
    {
        public ImageUploadException(string message) : base(message)
        {

        }
    }
}
