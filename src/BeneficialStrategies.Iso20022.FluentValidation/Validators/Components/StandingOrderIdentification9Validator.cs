// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="StandingOrderIdentification9"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _6l3dlTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the elements used to uniquely identify a standing order.
/// <list type="table">
///   <item><term>Account</term><description>CashAccount40 — required (1..1)</description></item>
///   <item><term>AccountOwner</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: <c>Account</c> and <c>AccountOwner</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class StandingOrderIdentification9Validator : AbstractValidator<StandingOrderIdentification9>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Account</c> building block and the optional <c>AccountOwner</c>
    /// building block — e.g. resolved from a DI container — instead of this type constructing its
    /// own.
    /// </summary>
    /// <param name="accountValidator">
    /// Validator for the required <c>Account</c> building block (CashAccount40, 1..1).
    /// </param>
    /// <param name="agentValidator">
    /// Validator for the optional <c>AccountOwner</c> building block
    /// (BranchAndFinancialInstitutionIdentification8, 0..1) — only invoked when present.
    /// </param>
    public StandingOrderIdentification9Validator(
        IValidator<CashAccount40> accountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator
    )
    {
        RuleFor(x => x.Account).SetValidator(accountValidator);

        When(
            x => x.AccountOwner is not null,
            () => RuleFor(x => x.AccountOwner).SetValidator(agentValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Account</c> and
    /// <c>AccountOwner</c> are each validated by their own default validator
    /// (<see cref="CashAccount40Validator"/>, <see cref="BranchAndFinancialInstitutionIdentification8Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public StandingOrderIdentification9Validator()
        : this(new CashAccount40Validator(), new BranchAndFinancialInstitutionIdentification8Validator()) { }
}
