// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Reservation4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _hsth0ZliEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Liquidity set aside by the account owner for specific purposes.
/// <list type="table">
///   <item><term>StartDateTime</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>Amount</term><description>Amount2Choice_ — required (1..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: <c>StartDateTime</c> and <c>Amount</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class Reservation4Validator : AbstractValidator<Reservation4>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>StartDateTime</c> building block and the required <c>Amount</c>
    /// building block — e.g. resolved from a DI container — instead of this type constructing
    /// its own.
    /// </summary>
    /// <param name="startDateTimeValidator">
    /// Validator for the optional <c>StartDateTime</c> building block
    /// (DateAndDateTime2Choice_, 0..1).
    /// </param>
    /// <param name="amountValidator">
    /// Validator for the required <c>Amount</c> building block (Amount2Choice_, 1..1).
    /// </param>
    public Reservation4Validator(
        IValidator<DateAndDateTime2Choice_> startDateTimeValidator,
        IValidator<Amount2Choice_> amountValidator
    )
    {
        RuleFor(x => x.Amount).SetValidator(amountValidator);

        When(
            x => x.StartDateTime is not null,
            () => RuleFor(x => x.StartDateTime).SetValidator(startDateTimeValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>StartDateTime</c> and
    /// <c>Amount</c> are each validated by their own default validator
    /// (<see cref="DateAndDateTime2Choice_Validator"/>, <see cref="Amount2Choice_Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public Reservation4Validator()
        : this(new DateAndDateTime2Choice_Validator(), new Amount2Choice_Validator()) { }
}
