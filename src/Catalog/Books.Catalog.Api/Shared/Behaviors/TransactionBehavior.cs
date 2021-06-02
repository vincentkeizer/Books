using System.Threading;
using System.Threading.Tasks;
using Books.Catalog.Infra.Databases;
using MediatR;

namespace Books.Catalog.Api.Shared.Behaviors
{
    public class TransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public TransactionBehavior(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var unitOfWork = _unitOfWorkFactory.Create();
            var response = await next();
            await unitOfWork.CommitAsync();

            return response;
        }
    }
}
