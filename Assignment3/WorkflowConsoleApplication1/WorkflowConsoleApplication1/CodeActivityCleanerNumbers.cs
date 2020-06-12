using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Text.RegularExpressions;

namespace WorkflowConsoleApplication1
{

    public sealed class CodeActivityCleanerNumbers : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> GeneratedString { get; set; }

        // Define an activity output argument of type string
        public OutArgument<string> CleanedString { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            //get the value generated from the service
            string generatedString = context.GetValue(this.GeneratedString);

            //keep only the number in string array
            string cleanedString = Regex.Replace(generatedString, @"[^0-9]+", "", RegexOptions.Compiled);

            //convert string to char array to perform numerically sorting
            char[] temp = cleanedString.ToArray();
            Array.Sort(temp);
            Array.Reverse(temp);
            cleanedString = new string(temp);

            //return the sorted the number string
            context.SetValue(this.CleanedString, cleanedString);
        }
    }
}
