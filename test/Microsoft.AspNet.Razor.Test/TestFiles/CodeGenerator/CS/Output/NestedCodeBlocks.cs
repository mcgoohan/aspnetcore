// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace TestOutput
{
    using System;
    using System.Threading.Tasks;

    public class NestedCodeBlocks
    {
        #line hidden
        public NestedCodeBlocks()
        {
        }

        public override async Task ExecuteAsync()
        {
#line 1 "NestedCodeBlocks.cshtml"
 if(foo) {
    

#line default
#line hidden

#line 2 "NestedCodeBlocks.cshtml"
     if(bar) {
    }

#line default
#line hidden

#line 3 "NestedCodeBlocks.cshtml"
     
}

#line default
#line hidden

        }
    }
}
