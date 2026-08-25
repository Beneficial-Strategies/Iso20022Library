// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CreditTransferTransaction66"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _66vhYTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-25). Promoted from an abbreviated
/// validator (Defect 2 minimum-collection-size rule only) to full-spec as part of building out
/// the pacs business area's <c>FinancialInstitutionDirectDebitV06</c>.
///
/// Provides further details specific to the individual transaction(s) included in the message.
/// <list type="table">
///   <item><term>CreditIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>BatchBooking</term><description>BatchBookingIndicator — optional (0..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation28 — optional (0..1)</description></item>
///   <item><term>TotalInterbankSettlementAmount</term><description>ActiveCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>InterbankSettlementDate</term><description>ISODate — optional (0..1)</description></item>
///   <item><term>SettlementTimeIndication</term><description>SettlementDateTimeIndication1 — optional (0..1)</description></item>
///   <item><term>InstructingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>IntermediaryAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Creditor</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructionForCreditorAgent</term><description>InstructionForCreditorAgent3 collection — optional (0..&#8734;)</description></item>
///   <item><term>DirectDebitTransactionInformation</term><description>DirectDebitTransactionInformation33 collection — required, min 1 (1..&#8734;) per MCP's <c>minOccurs=1</c> on this member</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// <c>TotalInterbankSettlementAmount</c> is an <c>ActiveCurrencyAndAmount</c> (plain record, not
/// an <see cref="IIsoSimpleValue{T}"/> wrapper) — its <c>Currency</c> and <c>Amount</c> fields are
/// validated inline here per the established convention (see <c>PaymentTransaction137Validator</c>
/// and <c>AmountAndDirection5Validator</c>): ISO 4217 three-letter currency pattern, amount
/// greater than zero. Only checked when the field is present (0..1).
///
/// Known model defect: <c>DirectDebitTransactionInformation</c> is <c>ValueList&lt;T&gt; = []</c>,
/// which allows an empty collection at the C# level even though the spec requires Min=1..&#8734;.
/// Enforced here via an explicit <c>NotEmpty</c> rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// Dependency injection: every Component-typed field is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class CreditTransferTransaction66Validator : AbstractValidator<CreditTransferTransaction66>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the required <c>Creditor</c> and <c>DirectDebitTransactionInformation</c> collection,
    /// and every other optional building block — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    public CreditTransferTransaction66Validator(
        IValidator<PaymentTypeInformation28> paymentTypeInformationValidator,
        IValidator<SettlementDateTimeIndication1> settlementTimeIndicationValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructingAgentValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructedAgentValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> intermediaryAgent1Validator,
        IValidator<CashAccount40> intermediaryAgent1AccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> intermediaryAgent2Validator,
        IValidator<CashAccount40> intermediaryAgent2AccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> intermediaryAgent3Validator,
        IValidator<CashAccount40> intermediaryAgent3AccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> creditorAgentValidator,
        IValidator<CashAccount40> creditorAgentAccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> creditorValidator,
        IValidator<CashAccount40> creditorAccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> ultimateCreditorValidator,
        IValidator<InstructionForCreditorAgent3> instructionForCreditorAgentValidator,
        IValidator<DirectDebitTransactionInformation33> directDebitTransactionInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.Creditor).SetValidator(creditorValidator!);

        RuleFor(x => x.DirectDebitTransactionInformation)
            .NotEmpty()
            .WithMessage(
                "CreditTransferTransaction66.DirectDebitTransactionInformation must contain at least one element (1..∞)."
            );
        RuleForEach(x => x.DirectDebitTransactionInformation)
            .SetValidator(directDebitTransactionInformationValidator!);

        // CreditIdentification: Max35Text, required — length enforced by struct constructor, no rule needed.
        // BatchBooking: BatchBookingIndicator, optional — no rule needed.

        When(
            x => x.TotalInterbankSettlementAmount is not null,
            () =>
            {
                RuleFor(x => x.TotalInterbankSettlementAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "CreditTransferTransaction66.TotalInterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );

                RuleFor(x => x.TotalInterbankSettlementAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage(
                        "CreditTransferTransaction66.TotalInterbankSettlementAmount.Amount must be greater than zero."
                    );
            }
        );

        When(
            x => x.PaymentTypeInformation is not null,
            () => RuleFor(x => x.PaymentTypeInformation).SetValidator(paymentTypeInformationValidator!)
        );

        When(
            x => x.SettlementTimeIndication is not null,
            () => RuleFor(x => x.SettlementTimeIndication).SetValidator(settlementTimeIndicationValidator!)
        );

        When(
            x => x.InstructingAgent is not null,
            () => RuleFor(x => x.InstructingAgent).SetValidator(instructingAgentValidator!)
        );

        When(
            x => x.InstructedAgent is not null,
            () => RuleFor(x => x.InstructedAgent).SetValidator(instructedAgentValidator!)
        );

        When(
            x => x.IntermediaryAgent1 is not null,
            () => RuleFor(x => x.IntermediaryAgent1).SetValidator(intermediaryAgent1Validator!)
        );
        When(
            x => x.IntermediaryAgent1Account is not null,
            () => RuleFor(x => x.IntermediaryAgent1Account).SetValidator(intermediaryAgent1AccountValidator!)
        );

        When(
            x => x.IntermediaryAgent2 is not null,
            () => RuleFor(x => x.IntermediaryAgent2).SetValidator(intermediaryAgent2Validator!)
        );
        When(
            x => x.IntermediaryAgent2Account is not null,
            () => RuleFor(x => x.IntermediaryAgent2Account).SetValidator(intermediaryAgent2AccountValidator!)
        );

        When(
            x => x.IntermediaryAgent3 is not null,
            () => RuleFor(x => x.IntermediaryAgent3).SetValidator(intermediaryAgent3Validator!)
        );
        When(
            x => x.IntermediaryAgent3Account is not null,
            () => RuleFor(x => x.IntermediaryAgent3Account).SetValidator(intermediaryAgent3AccountValidator!)
        );

        When(
            x => x.CreditorAgent is not null,
            () => RuleFor(x => x.CreditorAgent).SetValidator(creditorAgentValidator!)
        );
        When(
            x => x.CreditorAgentAccount is not null,
            () => RuleFor(x => x.CreditorAgentAccount).SetValidator(creditorAgentAccountValidator!)
        );

        When(
            x => x.CreditorAccount is not null,
            () => RuleFor(x => x.CreditorAccount).SetValidator(creditorAccountValidator!)
        );

        When(
            x => x.UltimateCreditor is not null,
            () => RuleFor(x => x.UltimateCreditor).SetValidator(ultimateCreditorValidator!)
        );

        RuleForEach(x => x.InstructionForCreditorAgent).SetValidator(instructionForCreditorAgentValidator!);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CreditTransferTransaction66Validator()
        : this(
            new PaymentTypeInformation28Validator(),
            new SettlementDateTimeIndication1Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new InstructionForCreditorAgent3Validator(),
            new DirectDebitTransactionInformation33Validator(),
            new SupplementaryData1Validator()
        ) { }
}
