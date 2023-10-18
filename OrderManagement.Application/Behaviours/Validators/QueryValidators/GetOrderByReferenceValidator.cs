using FluentValidation;
using OrderManagement.Application.Queries;

namespace OrderManagement.Application.Behaviours.Validators.QueryValidators
{
    public sealed class GetOrderByReferenceValidator : AbstractValidator<GetOrderByReferenceQuery>
    {
        public GetOrderByReferenceValidator()
        {
            RuleFor(x => x.OrderReference).NotEmpty().MinimumLength(3).MaximumLength(15);

        }
    }
}
