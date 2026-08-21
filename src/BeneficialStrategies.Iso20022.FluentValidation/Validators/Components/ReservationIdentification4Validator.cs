// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ReservationIdentification4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _0vVvETEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Liquidity set aside by the account owner for specific purposes.
/// <list type="table">
///   <item><term>ReservationIdentification</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>SystemIdentification</term><description>SystemIdentification2Choice_ — optional (0..1)</description></item>
///   <item><term>Type</term><description>ReservationType2Choice_ — required (1..1)</description></item>
///   <item><term>AccountOwner</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>AccountIdentification</term><description>AccountIdentification4Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: every nested building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class ReservationIdentification4Validator : AbstractValidator<ReservationIdentification4>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for every nested building block — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    /// <param name="accountIdentificationValidator">
    /// Validator for the optional <c>AccountIdentification</c> building block
    /// (AccountIdentification4Choice_, 0..1).
    /// </param>
    /// <param name="agentValidator">
    /// Validator for the optional <c>AccountOwner</c> building block
    /// (BranchAndFinancialInstitutionIdentification8, 0..1).
    /// </param>
    /// <param name="systemIdentificationValidator">
    /// Validator for the optional <c>SystemIdentification</c> building block
    /// (SystemIdentification2Choice_, 0..1).
    /// </param>
    /// <param name="typeValidator">
    /// Validator for the required <c>Type</c> building block (ReservationType2Choice_, 1..1).
    /// </param>
    public ReservationIdentification4Validator(
        IValidator<AccountIdentification4Choice_> accountIdentificationValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<SystemIdentification2Choice_> systemIdentificationValidator,
        IValidator<ReservationType2Choice_> typeValidator
    )
    {
        RuleFor(x => x.Type).SetValidator(typeValidator);

        When(
            x => x.AccountIdentification is not null,
            () => RuleFor(x => x.AccountIdentification).SetValidator(accountIdentificationValidator!)
        );
        When(
            x => x.AccountOwner is not null,
            () => RuleFor(x => x.AccountOwner).SetValidator(agentValidator!)
        );
        When(
            x => x.SystemIdentification is not null,
            () => RuleFor(x => x.SystemIdentification).SetValidator(systemIdentificationValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every nested building block is
    /// validated by its own default validator (<see cref="AccountIdentification4Choice_Validator"/>,
    /// <see cref="BranchAndFinancialInstitutionIdentification8Validator"/>,
    /// <see cref="SystemIdentification2Choice_Validator"/>, <see cref="ReservationType2Choice_Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public ReservationIdentification4Validator()
        : this(
            new AccountIdentification4Choice_Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new SystemIdentification2Choice_Validator(),
            new ReservationType2Choice_Validator()
        ) { }
}
