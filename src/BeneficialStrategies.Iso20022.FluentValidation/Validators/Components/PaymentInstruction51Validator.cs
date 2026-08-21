// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentInstruction51"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: a376f506-35bc-4f88-9925-eceabe35beea
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Characteristics that apply to the debit side of the payment transactions included in the
/// credit transfer initiation.
/// <list type="table">
///   <item><term>PaymentInformationIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>PaymentMethod</term><description>PaymentMethod3Code — required (1..1), closed enum, fully enforced</description></item>
///   <item><term>RequestedAdviceType</term><description>AdviceType1 — optional (0..1)</description></item>
///   <item><term>BatchBooking</term><description>BatchBookingIndicator — optional (0..1), fully struct-enforced</description></item>
///   <item><term>NumberOfTransactions</term><description>Max15NumericText — optional (0..1), fully struct-enforced</description></item>
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1), fully struct-enforced</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation26 — optional (0..1)</description></item>
///   <item><term>RequestedExecutionDate</term><description>DateAndDateTime2Choice_ — required (1..1)</description></item>
///   <item><term>PoolingAdjustmentDate</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Debtor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — required (1..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>InstructionForDebtorAgent</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>UltimateDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>ChargesAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>ChargesAccountAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>CreditTransferTransactionInformation</term><description>CreditTransferTransaction76 collection — required, min 1 (1..n)</description></item>
/// </list>
///
/// Known model defect: <c>CreditTransferTransactionInformation</c> is <c>ValueList&lt;T&gt; = []</c>,
/// which allows an empty collection at the C# level even though the spec requires Min=1..&#8734;.
/// Enforced here via an explicit <c>NotEmpty</c> rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: every optional/required building block above is validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="PartyIdentification272"/> validator instance is reused across <c>Debtor</c> and
/// <c>UltimateDebtor</c>, the same <see cref="CashAccount40"/> validator instance across all
/// three account fields, and the same <see cref="BranchAndFinancialInstitutionIdentification8"/>
/// validator instance across <c>DebtorAgent</c> and <c>ChargesAccountAgent</c> — see the two
/// constructors below. (Upgraded 2026-08-21 from an earlier abbreviated version that only
/// enforced the multiplicity gap above — <see cref="CreditTransferTransaction76Validator"/> did
/// not exist yet at that time.)
/// </remarks>
public class PaymentInstruction51Validator : AbstractValidator<PaymentInstruction51>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PaymentInstruction51Validator(
        IValidator<AdviceType1> requestedAdviceTypeValidator,
        IValidator<PaymentTypeInformation26> paymentTypeInformationValidator,
        IValidator<DateAndDateTime2Choice_> requestedExecutionDateValidator,
        IValidator<PartyIdentification272> partyValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CreditTransferTransaction76> creditTransferTransactionInformationValidator
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
        RuleFor(x => x.RequestedExecutionDate).SetValidator(requestedExecutionDateValidator!);
        RuleFor(x => x.Debtor).SetValidator(partyValidator!);
        RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!);
        RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!);
        When(
            x => x.DebtorAgentAccount is not null,
            () => RuleFor(x => x.DebtorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.UltimateDebtor is not null,
            () => RuleFor(x => x.UltimateDebtor).SetValidator(partyValidator!)
        );
        When(
            x => x.ChargesAccount is not null,
            () => RuleFor(x => x.ChargesAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.ChargesAccountAgent is not null,
            () => RuleFor(x => x.ChargesAccountAgent).SetValidator(agentValidator!)
        );

        RuleFor(x => x.CreditTransferTransactionInformation)
            .NotEmpty()
            .WithMessage(
                "PaymentInstruction51.CreditTransferTransactionInformation must contain at least one element (1..∞)."
            );
        RuleForEach(x => x.CreditTransferTransactionInformation)
            .SetValidator(creditTransferTransactionInformationValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentInstruction51Validator()
        : this(
            new AdviceType1Validator(),
            new PaymentTypeInformation26Validator(),
            new DateAndDateTime2Choice_Validator(),
            new PartyIdentification272Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CreditTransferTransaction76Validator()
        ) { }
}
