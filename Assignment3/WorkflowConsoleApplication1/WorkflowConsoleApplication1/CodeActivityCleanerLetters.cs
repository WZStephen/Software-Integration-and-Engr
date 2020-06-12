using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Text.RegularExpressions;

namespace WorkflowConsoleApplication1
{

    public sealed class CodeActivityCleanerLetters : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> GeneratedString{get; set;}

        // Define an activity output argument of type string
        public OutArgument<string> CleanedString { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            //get the value generated from the service
            string generatedString = context.GetValue(this.GeneratedString);

            //keep only the upper and lower case of letters in string
            string cleanedString = Regex.Replace(generatedString, @"[^A-Za-z]+", "", RegexOptions.Compiled);

            //sort the letter string alphabatically
            cleanedString = String.Concat(cleanedString.OrderBy(c => c));

            //return the sorted string
            context.SetValue(this.CleanedString, cleanedString);
        }
    }
}
