// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace TestOutput
{
    using System;
    using System.Threading.Tasks;

    public class InlineBlocks
    {
public static Template 
#line 1 "InlineBlocks.cshtml"
Link(string link) {

#line default
#line hidden
        return new Template((__razor_helper_writer) => {
#line 1 "InlineBlocks.cshtml"
                           

#line default
#line hidden

            WriteLiteralTo(__razor_helper_writer, "    <a");
            WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 35), Tuple.Create("\"", 93), 
            Tuple.Create(Tuple.Create("", 42), Tuple.Create<System.Object, System.Int32>(new Template((__razor_attribute_value_writer) => {
#line 2 "InlineBlocks.cshtml"
              if(link != null) { 

#line default
#line hidden

                WriteTo(__razor_attribute_value_writer, 
#line 2 "InlineBlocks.cshtml"
                                  link

#line default
#line hidden
                );

#line 2 "InlineBlocks.cshtml"
                                       } else {

#line default
#line hidden

                WriteLiteralTo(__razor_attribute_value_writer, " # ");
#line 2 "InlineBlocks.cshtml"
                                                               }

#line default
#line hidden

            }
            ), 42), false));
            WriteLiteralTo(__razor_helper_writer, " />\r\n");
#line 3 "InlineBlocks.cshtml"

#line default
#line hidden

        }
        );
#line 3 "InlineBlocks.cshtml"
}

#line default
#line hidden

        #line hidden
        public InlineBlocks()
        {
        }

        public override async Task ExecuteAsync()
        {
        }
    }
}
