﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.OData.Extensions.Builder
{
    internal class DefaultAssemblyResolver : IAssemblyResolver
    {
        /// <summary>
        /// This static instance is used in the shared code in places where the request container context
        /// is not known or does not contain an instance of IWebApiAssembliesResolver.
        /// </summary>
        public static IAssemblyResolver Default = new DefaultAssemblyResolver();

        public IEnumerable<Assembly> Assemblies => new List<Assembly>();
    }
}