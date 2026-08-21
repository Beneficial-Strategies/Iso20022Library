// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="StandingOrder10"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _yhhMoTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// New standing order values.
/// <list type="table">
///   <item><term>Amount</term><description>Amount2Choice_ — optional (0..1)</description></item>
///   <item><term>Creditor</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Debtor</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>ExecutionType</term><description>ExecutionType1Choice_ — optional (0..1)</description></item>
///   <item><term>Frequency</term><description>Frequency2Code — optional (0..1)</description></item>
///   <item><term>ValidityPeriod</term><description>DatePeriod2Choice_ — optional (0..1)</description></item>
///   <item><term>ZeroSweepIndicator</term><description>TrueFalseIndicator — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. <c>Frequency</c> is a closed C#
/// enum and <c>ZeroSweepIndicator</c> is already fully struct-enforced — neither needs a rule.
///
/// Dependency injection: every nested building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below. <c>BranchAndFinancialInstitutionIdentification8</c> is shared across two properties
/// (<c>Creditor</c>, <c>Debtor</c>); <c>CashAccount40</c> across two (<c>CreditorAccount</c>,
/// <c>DebtorAccount</c>) — one injected validator serves both properties of the same validated
/// type.
/// </remarks>
public class StandingOrder10Validator : AbstractValidator<StandingOrder10>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for every nested building block — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    /// <param name="amountValidator">
    /// Validator for the optional <c>Amount</c> building block (Amount2Choice_, 0..1).
    /// </param>
    /// <param name="agentValidator">
    /// Validator for the <c>Creditor</c> and <c>Debtor</c> building blocks (both
    /// BranchAndFinancialInstitutionIdentification8).
    /// </param>
    /// <param name="cashAccountValidator">
    /// Validator for the <c>CreditorAccount</c> and <c>DebtorAccount</c> building blocks (both
    /// CashAccount40).
    /// </param>
    /// <param name="executionTypeValidator">
    /// Validator for the optional <c>ExecutionType</c> building block (ExecutionType1Choice_, 0..1).
    /// </param>
    /// <param name="validityPeriodValidator">
    /// Validator for the optional <c>ValidityPeriod</c> building block (DatePeriod2Choice_, 0..1).
    /// </param>
    public StandingOrder10Validator(
        IValidator<Amount2Choice_> amountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<ExecutionType1Choice_> executionTypeValidator,
        IValidator<DatePeriod2Choice_> validityPeriodValidator
    )
    {
        When(x => x.Amount is not null, () => RuleFor(x => x.Amount).SetValidator(amountValidator!));

        When(x => x.Creditor is not null, () => RuleFor(x => x.Creditor).SetValidator(agentValidator!));
        When(x => x.Debtor is not null, () => RuleFor(x => x.Debtor).SetValidator(agentValidator!));

        When(
            x => x.CreditorAccount is not null,
            () => RuleFor(x => x.CreditorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.DebtorAccount is not null,
            () => RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!)
        );

        When(
            x => x.ExecutionType is not null,
            () => RuleFor(x => x.ExecutionType).SetValidator(executionTypeValidator!)
        );
        When(
            x => x.ValidityPeriod is not null,
            () => RuleFor(x => x.ValidityPeriod).SetValidator(validityPeriodValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every nested building block is
    /// validated by its own default validator (<see cref="Amount2Choice_Validator"/>,
    /// <see cref="BranchAndFinancialInstitutionIdentification8Validator"/>,
    /// <see cref="CashAccount40Validator"/>, <see cref="ExecutionType1Choice_Validator"/>,
    /// <see cref="DatePeriod2Choice_Validator"/>). Convenience constructor for callers not using
    /// a DI container.
    /// </summary>
    public StandingOrder10Validator()
        : this(
            new Amount2Choice_Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new ExecutionType1Choice_Validator(),
            new DatePeriod2Choice_Validator()
        ) { }
}
