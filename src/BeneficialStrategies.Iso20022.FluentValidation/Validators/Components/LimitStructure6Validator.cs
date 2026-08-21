// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="LimitStructure6"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _4Oc6QTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Limit details of one particular limit set by the member and managed by the transaction
/// administrator.
/// <list type="table">
///   <item><term>LimitIdentification</term><description>LimitIdentification8 — required (1..1)</description></item>
///   <item><term>StartDateTime</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>Amount</term><description>Amount2Choice_ — required (1..1)</description></item>
///   <item><term>CreditDebitIndicator</term><description>CreditDebitCode — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. <c>CreditDebitIndicator</c> is a
/// closed C# enum — no rule needed.
///
/// Dependency injection: every nested building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class LimitStructure6Validator : AbstractValidator<LimitStructure6>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for every nested building block — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    /// <param name="limitIdentificationValidator">
    /// Validator for the required <c>LimitIdentification</c> building block
    /// (LimitIdentification8, 1..1).
    /// </param>
    /// <param name="startDateTimeValidator">
    /// Validator for the optional <c>StartDateTime</c> building block
    /// (DateAndDateTime2Choice_, 0..1).
    /// </param>
    /// <param name="amountValidator">
    /// Validator for the required <c>Amount</c> building block (Amount2Choice_, 1..1).
    /// </param>
    public LimitStructure6Validator(
        IValidator<LimitIdentification8> limitIdentificationValidator,
        IValidator<DateAndDateTime2Choice_> startDateTimeValidator,
        IValidator<Amount2Choice_> amountValidator
    )
    {
        RuleFor(x => x.LimitIdentification).SetValidator(limitIdentificationValidator);
        RuleFor(x => x.Amount).SetValidator(amountValidator);

        When(
            x => x.StartDateTime is not null,
            () => RuleFor(x => x.StartDateTime).SetValidator(startDateTimeValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every nested building block is
    /// validated by its own default validator (<see cref="LimitIdentification8Validator"/>,
    /// <see cref="DateAndDateTime2Choice_Validator"/>, <see cref="Amount2Choice_Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public LimitStructure6Validator()
        : this(
            new LimitIdentification8Validator(),
            new DateAndDateTime2Choice_Validator(),
            new Amount2Choice_Validator()
        ) { }
}
