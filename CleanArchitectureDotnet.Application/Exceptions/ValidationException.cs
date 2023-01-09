namespace CleanArchitectureDotnet.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public IReadOnlyList<string> Errors { get; protected set; }

        public ValidationException(List<ValidationFailure> failures)
        {
            Errors = failures.Select(f => f.ErrorMessage).ToList();
        }
    }
}

