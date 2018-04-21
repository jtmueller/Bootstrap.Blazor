using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace Boostrap.Blazor
{
    public class ExampleJsInterop
    {
        public static string Prompt(string message)
        {
            return RegisteredFunction.Invoke<string>(
                "Boostrap.Blazor.ExampleJsInterop.Prompt",
                message);
        }
    }
}
