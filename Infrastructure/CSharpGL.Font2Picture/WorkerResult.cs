﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL.Font2Picture
{
    class WorkerResult
    {
        public WorkerData data;
        public StringBuilder builder;

        public WorkerResult(StringBuilder builder, WorkerData data)
        {
            this.builder = builder;
            this.data = data;
        }
    }
}
