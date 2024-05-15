using Application.Wrappers.Responses;
using Domain.Enum;
using MediatR;

namespace Application.UseCases.MoneyMovementFeatures.CreateMoneyMovement;

public sealed record CreateMoneyMovementRequest(decimal MoneyAmount, int CategoryId, EMovementType MovementType, DateTime Date,
    string Description = "", byte[]? Photo = null) : IRequest<Response<CreateMoneyMovementResponse>>;