﻿// Copyright (C) Microsoft. All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using System;

namespace Microsoft.DevSkim.CLI.Writers
{
    public class WriterFactory
    {
        public static Writer GetWriter(string writerName, string format = null)
        {
            switch (writerName.ToLowerInvariant())
            {
                case "json":
                    return new JsonWriter(format);                    
                case "text":
                    return new SimpleTextWriter(format);
                case "sarif":
                    throw new NotImplementedException("sarif not supported");
                default:
                    throw new Exception("wrong output");
            }
        }
    }
}