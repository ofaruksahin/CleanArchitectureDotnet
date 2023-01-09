namespace CleanArchitectureDotnet.Application.Pipelines.Validation
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : BaseResponse
    {
        private readonly IServiceProvider _serviceProvider;

        public ValidationBehaviour(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var validator = _serviceProvider.GetService(typeof(IValidator<TRequest>));
            if (validator != null && validator is IValidator<TRequest> requestValidator)
            {
                var validationResult = requestValidator.Validate(request);
                if (!validationResult.IsValid)
                    throw new Exceptions.ValidationException(validationResult.Errors);
            }

            return await next();
        }
    }
}

