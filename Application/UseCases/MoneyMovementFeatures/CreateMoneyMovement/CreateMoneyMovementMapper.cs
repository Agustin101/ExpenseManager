using Application.Wrappers.Responses;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.MoneyMovementFeatures.CreateMoneyMovement;

public sealed class CreateMoneyMovementMapper : Profile
{
    public CreateMoneyMovementMapper()
    {
        CreateMap<CreateMoneyMovementRequest, MoneyMovement>();
    }
}
