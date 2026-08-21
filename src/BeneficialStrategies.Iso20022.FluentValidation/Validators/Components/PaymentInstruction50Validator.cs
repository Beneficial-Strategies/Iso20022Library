// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentInstruction50"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 88833a18-3210-4838-a808-05caac40b3f4
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Characteristics that apply to the credit side of the payment transactions included in the
/// direct debit initiation.
/// <list type="table">
///   <item><term>PaymentInformationIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>PaymentMethod</term><description>PaymentMethod2Code — required (1..1), closed enum, fully enforced</description></item>
///   <item><term>RequestedAdviceType</term><description>AdviceType1 — optional (0..1)</description></item>
///   <item><term>BatchBooking</term><description>BatchBookingIndicator — optional (0..1), fully struct-enforced</description></item>
///   <item><term>NumberOfTransactions</term><description>Max15NumericText — optional (0..1), fully struct-enforced</description></item>
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1), fully struct-enforced</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation29 — optional (0..1)</description></item>
///   <item><term>RequestedCollectionDate</term><description>ISODate — required (1..1), fully struct-enforced</description></item>
///   <item><term>Creditor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — required (1..1)</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>ChargesAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>ChargesAccountAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>CreditorSchemeIdentification</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>DirectDebitTransactionInformation</term><description>DirectDebitTransactionInformation34 collection — required, min 1 (1..n)</description></item>
/// </list>
///
/// Known model defect: <c>DirectDebitTransactionInformation</c> is <c>ValueList&lt;T&gt; = []</c>,
/// which allows an empty collection at the C# level even though the spec requires Min=1..&#8734;.
/// Enforced here via an explicit <c>NotEmpty</c> rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: every optional/required building block above is validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="PartyIdentification272"/> validator instance is reused across <c>Creditor</c>,
/// <c>UltimateCreditor</c>, and <c>CreditorSchemeIdentification</c>, the same
/// <see cref="CashAccount40"/> validator instance across all three account fields, and the same
/// <see cref="BranchAndFinancialInstitutionIdentification8"/> validator instance across
/// <c>CreditorAgent</c> and <c>ChargesAccountAgent</c> — see the two constructors below.
/// (Upgraded 2026-08-21 from an earlier abbreviated version that only enforced the multiplicity
/// gap above — <see cref="DirectDebitTransactionInformation34Validator"/> did not exist yet at
/// that time.)
/// </remarks>
public class PaymentInstruction50Validator : AbstractValidator<PaymentInstruction50>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PaymentInstruction50Validator(
        IValidator<AdviceType1> requestedAdviceTypeValidator,
        IValidator<PaymentTypeInformation29> paymentTypeInformationValidator,
        IValidator<PartyIdentification272> partyValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<DirectDebitTransactionInformation34> directDebitTransactionInformationValidator
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
        RuleFor(x => x.Creditor).SetValidator(partyValidator!);
        RuleFor(x => x.CreditorAccount).SetValidator(cashAccountValidator!);
        RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!);
        When(
            x => x.CreditorAgentAccount is not null,
            () => RuleFor(x => x.CreditorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.UltimateCreditor is not null,
            () => RuleFor(x => x.UltimateCreditor).SetValidator(partyValidator!)
        );
        When(
            x => x.ChargesAccount is not null,
            () => RuleFor(x => x.ChargesAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.ChargesAccountAgent is not null,
            () => RuleFor(x => x.ChargesAccountAgent).SetValidator(agentValidator!)
        );
        When(
            x => x.CreditorSchemeIdentification is not null,
            () => RuleFor(x => x.CreditorSchemeIdentification).SetValidator(partyValidator!)
        );

        RuleFor(x => x.DirectDebitTransactionInformation)
            .NotEmpty()
            .WithMessage(
                "PaymentInstruction50.DirectDebitTransactionInformation must contain at least one element (1..∞)."
            );
        RuleForEach(x => x.DirectDebitTransactionInformation).SetValidator(directDebitTransactionInformationValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentInstruction50Validator()
        : this(
            new AdviceType1Validator(),
            new PaymentTypeInformation29Validator(),
            new PartyIdentification272Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new DirectDebitTransactionInformation34Validator()
        ) { }
}
