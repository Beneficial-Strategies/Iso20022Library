// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="LimitIdentification8"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _0WRu0TEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the identification details to uniquely identify a limit within the system.
/// <list type="table">
///   <item><term>SystemIdentification</term><description>SystemIdentification2Choice_ — optional (0..1)</description></item>
///   <item><term>BilateralLimitCounterpartyIdentification</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>Type</term><description>LimitType1Choice_ — required (1..1)</description></item>
///   <item><term>AccountOwner</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>AccountIdentification</term><description>AccountIdentification4Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: every nested building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below. <c>BranchAndFinancialInstitutionIdentification8</c> is shared across two properties
/// (<c>AccountOwner</c>, <c>BilateralLimitCounterpartyIdentification</c>) — one injected
/// validator serves both.
/// </remarks>
public class LimitIdentification8Validator : AbstractValidator<LimitIdentification8>
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
    /// Validator for the <c>AccountOwner</c> and <c>BilateralLimitCounterpartyIdentification</c>
    /// building blocks (both BranchAndFinancialInstitutionIdentification8, 0..1).
    /// </param>
    /// <param name="systemIdentificationValidator">
    /// Validator for the optional <c>SystemIdentification</c> building block
    /// (SystemIdentification2Choice_, 0..1).
    /// </param>
    /// <param name="typeValidator">
    /// Validator for the required <c>Type</c> building block (LimitType1Choice_, 1..1).
    /// </param>
    public LimitIdentification8Validator(
        IValidator<AccountIdentification4Choice_> accountIdentificationValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<SystemIdentification2Choice_> systemIdentificationValidator,
        IValidator<LimitType1Choice_> typeValidator
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
            x => x.BilateralLimitCounterpartyIdentification is not null,
            () =>
                RuleFor(x => x.BilateralLimitCounterpartyIdentification).SetValidator(agentValidator!)
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
    /// <see cref="SystemIdentification2Choice_Validator"/>, <see cref="LimitType1Choice_Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public LimitIdentification8Validator()
        : this(
            new AccountIdentification4Choice_Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new SystemIdentification2Choice_Validator(),
            new LimitType1Choice_Validator()
        ) { }
}
