using MediatR;
using MultiShop.Order.Application.Features.Mediator.Results.OrderingResults;

namespace MultiShop.Order.Application.Features.Mediator.Queries.OrderingQueries;

public class GetOrderingByIdQuery(int id): IRequest<GetOrderingByIdQueryResult>
{
    public int Id { get; set; } = id;
}