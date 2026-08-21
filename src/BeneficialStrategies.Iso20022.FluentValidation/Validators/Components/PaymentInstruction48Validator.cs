// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentInstruction48"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 41f45edb-b794-450d-b6d0-63ff93e72ea6
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator.
/// This instruction may have to be forwarded several times to complete the settlement chain.
/// <list type="table">
///   <item><term>PaymentInformationIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>PaymentMethod</term><description>PaymentMethod7Code — required (1..1), closed enum, fully enforced</description></item>
///   <item><term>RequestedAdviceType</term><description>AdviceType1 — optional (0..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation29 — optional (0..1)</description></item>
///   <item><term>RequestedExecutionDate</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>ExpiryDate</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>PaymentCondition</term><description>PaymentCondition2 — optional (0..1)</description></item>
///   <item><term>Debtor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>CreditTransferTransaction</term><description>CreditTransferTransaction74 collection — required, min 1 (1..n)</description></item>
/// </list>
///
/// Known model defect: <c>CreditTransferTransaction</c> is <c>ValueList&lt;T&gt; = []</c>, which
/// allows an empty collection at the C# level even though the spec requires Min=1..&#8734;. Enforced
/// here via an explicit <c>NotEmpty</c> rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// Dependency injection: every optional/required building block above is validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="PartyIdentification272"/> validator instance is reused across <c>Debtor</c> and
/// <c>UltimateDebtor</c>, the same <see cref="CashAccount40"/> validator instance across
/// <c>DebtorAccount</c> and <c>DebtorAgentAccount</c>, and the same
/// <see cref="DateAndDateTime2Choice_"/> validator instance across <c>RequestedExecutionDate</c>
/// and <c>ExpiryDate</c> — see the two constructors below.
///
/// Known test-coverage gap (2026-08-21): the <c>CreditTransferTransaction</c> minimum-count rule
/// is genuinely proven by the test suite (<c>EmptyCreditTransferTransaction_HasValidationError</c>),
/// but the remaining <c>SetValidator</c> wiring (<c>RequestedAdviceType</c>,
/// <c>PaymentTypeInformation</c>, the two dates, <c>PaymentCondition</c>, <c>Debtor</c>,
/// <c>DebtorAccount</c>, <c>DebtorAgent</c>, <c>DebtorAgentAccount</c>, <c>UltimateDebtor</c>) is
/// not — the happy-path test populates each with minimal/default content that cannot fail
/// regardless of wiring. See <see cref="CreditTransferTransaction74Validator"/>'s own remarks for
/// the same gap one level down.
/// </remarks>
public class PaymentInstruction48Validator : AbstractValidator<PaymentInstruction48>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PaymentInstruction48Validator(
        IValidator<AdviceType1> requestedAdviceTypeValidator,
        IValidator<PaymentTypeInformation29> paymentTypeInformationValidator,
        IValidator<DateAndDateTime2Choice_> dateValidator,
        IValidator<PaymentCondition2> paymentConditionValidator,
        IValidator<PartyIdentification272> partyValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CreditTransferTransaction74> creditTransferTransactionValidator
    )
    {
        When(
            x => x.RequestedAdviceType is not null,
            () => RuleFor(x => x.RequestedAdviceType).SetValidator(requestedAdviceTypeValidator!)
        );
        When(
            x => x.PaymentTypeInformation is not null,
            () => RuleFor(x => x.PaymentTypeInformation).SetValidator(paymentTypeInformationValidator!)
        );
        When(
            x => x.RequestedExecutionDate is not null,
            () => RuleFor(x => x.RequestedExecutionDate).SetValidator(dateValidator!)
        );
        When(x => x.ExpiryDate is not null, () => RuleFor(x => x.ExpiryDate).SetValidator(dateValidator!));
        When(
            x => x.PaymentCondition is not null,
            () => RuleFor(x => x.PaymentCondition).SetValidator(paymentConditionValidator!)
        );
        RuleFor(x => x.Debtor).SetValidator(partyValidator!);
        When(
            x => x.DebtorAccount is not null,
            () => RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!)
        );
        RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!);
        When(
            x => x.DebtorAgentAccount is not null,
            () => RuleFor(x => x.DebtorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.UltimateDebtor is not null,
            () => RuleFor(x => x.UltimateDebtor).SetValidator(partyValidator!)
        );

        RuleFor(x => x.CreditTransferTransaction)
            .NotEmpty()
            .WithMessage("PaymentInstruction48.CreditTransferTransaction must contain at least one element (1..∞).");
        RuleForEach(x => x.CreditTransferTransaction).SetValidator(creditTransferTransactionValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentInstruction48Validator()
        : this(
            new AdviceType1Validator(),
            new PaymentTypeInformation29Validator(),
            new DateAndDateTime2Choice_Validator(),
            new PaymentCondition2Validator(),
            new PartyIdentification272Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CreditTransferTransaction74Validator()
        ) { }
}
