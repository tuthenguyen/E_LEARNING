using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_LEARNING.APPLICATION.Base.Exceptions
{
    [Serializable]
    public class ValidationException : Exception
    {
        protected ValidationException()
           : base("One or more validation failures have occurred.")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(string message)
            : base(message)
        {
        }

        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            Errors = failures
                .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
                .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
            Failures = failures;
        }

        public IDictionary<string, string[]> Errors { get; }
        public IEnumerable<ValidationFailure> Failures { get; }
    }
}
