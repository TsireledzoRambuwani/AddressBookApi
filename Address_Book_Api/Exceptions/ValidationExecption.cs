using FluentValidation.Results;

namespace Address_Book_Api.Exceptions
{
    public class ValidationExecption : Exception
    {
        public ValidationExecption() : base("One or more validation falitures occured.")
        {
            Errors = new List<string>();
        }

        public ValidationExecption(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }

        public List<string> Errors { get; }
    }
}
