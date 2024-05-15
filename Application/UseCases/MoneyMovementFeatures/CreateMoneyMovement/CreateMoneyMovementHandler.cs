using Application.Wrappers.Responses;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using MediatR;

namespace Application.UseCases.MoneyMovementFeatures.CreateMoneyMovement;

public sealed class CreateMoneyMovementHandler(IMapper mapper, IMoneyMovementRepository moneyMovementRepository) 
    : IRequestHandler<CreateMoneyMovementRequest, Response<CreateMoneyMovementResponse>>
{
    public async Task<Response<CreateMoneyMovementResponse>> Handle(CreateMoneyMovementRequest request, CancellationToken cancellationToken)
    {
        var moneyMovement = mapper.Map<MoneyMovement>(request);
        await moneyMovementRepository.Create(moneyMovement);

        return new Response<CreateMoneyMovementResponse>(new CreateMoneyMovementResponse()
        {
            Id = moneyMovement.Id,
        });
    }
}
