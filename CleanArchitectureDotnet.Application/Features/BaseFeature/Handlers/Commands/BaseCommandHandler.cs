using CleanArchitectureDotnet.Application.Features.BaseFeature.Request.Commands;

namespace CleanArchitectureDotnet.Application.Features.BaseFeature.Handlers.Commands
{
    public class BaseCommandHandler : IRequestHandler<BaseCommand, BaseResponse>
    {
        public async Task<BaseResponse> Handle(BaseCommand request, CancellationToken cancellationToken)
        {
            return BaseResponse.Success(new NoContentResponse());
        }
    }
}

