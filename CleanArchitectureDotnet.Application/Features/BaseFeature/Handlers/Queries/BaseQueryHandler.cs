using CleanArchitectureDotnet.Application.Features.BaseFeature.Request.Queries;

namespace CleanArchitectureDotnet.Application.Features.BaseFeature.Handlers.Queries
{
    public class BaseQueryHandler : IRequestHandler<BaseQuery, BaseResponse>
    {
        public async Task<BaseResponse> Handle(BaseQuery request, CancellationToken cancellationToken)
        {
            return BaseResponse.Success(new NoContentResponse());
        }
    }
}

