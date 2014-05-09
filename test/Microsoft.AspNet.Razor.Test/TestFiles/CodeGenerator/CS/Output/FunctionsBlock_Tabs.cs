// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace TestOutput
{
    using System;
    using System.Threading.Tasks;

    public class FunctionsBlock_Tabs
    {
#line 1 "FunctionsBlock_Tabs.cshtml"



#line default
#line hidden
#line 5 "FunctionsBlock_Tabs.cshtml"

	Random _rand = new Random();
	private int RandomInt() {
		return _rand.Next();
	}

#line default
#line hidden
        #line hidden
        public FunctionsBlock_Tabs()
        {
        }

        public override async Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\nHere\'s a random number: ");
            Write(
#line 12 "FunctionsBlock_Tabs.cshtml"
                         RandomInt()

#line default
#line hidden
            );

        }
    }
}
