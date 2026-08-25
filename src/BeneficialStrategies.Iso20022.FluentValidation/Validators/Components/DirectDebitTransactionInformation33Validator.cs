// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DirectDebitTransactionInformation33"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _69BZlTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Provides further details specific to the individual direct debit transaction(s) included in
/// the message.
/// <list type="table">
///   <item><term>PaymentIdentification</term><description>PaymentIdentification13 — required (1..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation28 — optional (0..1)</description></item>
///   <item><term>InterbankSettlementAmount</term><description>ActiveCurrencyAndAmount — required (1..1)</description></item>
///   <item><term>InterbankSettlementDate</term><description>ISODate — optional (0..1)</description></item>
///   <item><term>SettlementPriority</term><description>Priority3Code — optional (0..1); closed enum, no rule needed</description></item>
///   <item><term>SettlementTimeIndication</term><description>SettlementDateTimeIndication1 — optional (0..1)</description></item>
///   <item><term>SettlementTimeRequest</term><description>SettlementTimeRequest2 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>Debtor</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>InstructionForDebtorAgent</term><description>Max210Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — optional (0..1)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation2 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// <c>InterbankSettlementAmount</c> is an <c>ActiveCurrencyAndAmount</c> (plain record, not an
/// <see cref="IIsoSimpleValue{T}"/> wrapper) — its <c>Currency</c> and <c>Amount</c> fields are
/// validated inline here per the established convention (see <c>PaymentTransaction137Validator</c>
/// and <c>AmountAndDirection5Validator</c>): ISO 4217 three-letter currency pattern, amount
/// greater than zero.
///
/// Dependency injection: <c>PaymentIdentification</c>, <c>PaymentTypeInformation</c>,
/// <c>SettlementTimeIndication</c>, <c>SettlementTimeRequest</c>, <c>UltimateDebtor</c>,
/// <c>Debtor</c>, <c>DebtorAccount</c>, <c>DebtorAgent</c>, <c>DebtorAgentAccount</c>,
/// <c>Purpose</c>, and <c>RemittanceInformation</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class DirectDebitTransactionInformation33Validator : AbstractValidator<DirectDebitTransactionInformation33>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the required <c>PaymentIdentification</c> and <c>Debtor</c> building blocks, and every
    /// other optional building block — e.g. resolved from a DI container — instead of this type
    /// constructing its own.
    /// </summary>
    public DirectDebitTransactionInformation33Validator(
        IValidator<PaymentIdentification13> paymentIdentificationValidator,
        IValidator<PaymentTypeInformation28> paymentTypeInformationValidator,
        IValidator<SettlementDateTimeIndication1> settlementTimeIndicationValidator,
        IValidator<SettlementTimeRequest2> settlementTimeRequestValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> ultimateDebtorValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> debtorValidator,
        IValidator<CashAccount40> debtorAccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> debtorAgentValidator,
        IValidator<CashAccount40> debtorAgentAccountValidator,
        IValidator<Purpose2Choice_> purposeValidator,
        IValidator<RemittanceInformation2> remittanceInformationValidator
    )
    {
        RuleFor(x => x.PaymentIdentification).SetValidator(paymentIdentificationValidator!);
        RuleFor(x => x.Debtor).SetValidator(debtorValidator!);

        // ── InterbankSettlementAmount (ActiveCurrencyAndAmount, required 1..1) ───────
        RuleFor(x => x.InterbankSettlementAmount.Currency)
            .NotEmpty()
            .Matches(CurrencyRegex)
            .WithMessage(
                "DirectDebitTransactionInformation33.InterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
            );

        RuleFor(x => x.InterbankSettlementAmount.Amount)
            .GreaterThan(0)
            .WithMessage(
                "DirectDebitTransactionInformation33.InterbankSettlementAmount.Amount must be greater than zero."
            );

        // InstructionForDebtorAgent: Max210Text, optional — length enforced by struct constructor, no rule needed.
        // SettlementPriority: closed Priority3Code enum, optional — no rule needed.

        When(
            x => x.PaymentTypeInformation is not null,
            () => RuleFor(x => x.PaymentTypeInformation).SetValidator(paymentTypeInformationValidator!)
        );

        When(
            x => x.SettlementTimeIndication is not null,
            () => RuleFor(x => x.SettlementTimeIndication).SetValidator(settlementTimeIndicationValidator!)
        );

        When(
            x => x.SettlementTimeRequest is not null,
            () => RuleFor(x => x.SettlementTimeRequest).SetValidator(settlementTimeRequestValidator!)
        );

        When(
            x => x.UltimateDebtor is not null,
            () => RuleFor(x => x.UltimateDebtor).SetValidator(ultimateDebtorValidator!)
        );

        When(
            x => x.DebtorAccount is not null,
            () => RuleFor(x => x.DebtorAccount).SetValidator(debtorAccountValidator!)
        );

        When(
            x => x.DebtorAgent is not null,
            () => RuleFor(x => x.DebtorAgent).SetValidator(debtorAgentValidator!)
        );

        When(
            x => x.DebtorAgentAccount is not null,
            () => RuleFor(x => x.DebtorAgentAccount).SetValidator(debtorAgentAccountValidator!)
        );

        When(x => x.Purpose is not null, () => RuleFor(x => x.Purpose).SetValidator(purposeValidator!));

        When(
            x => x.RemittanceInformation is not null,
            () => RuleFor(x => x.RemittanceInformation).SetValidator(remittanceInformationValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public DirectDebitTransactionInformation33Validator()
        : this(
            new PaymentIdentification13Validator(),
            new PaymentTypeInformation28Validator(),
            new SettlementDateTimeIndication1Validator(),
            new SettlementTimeRequest2Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new Purpose2Choice_Validator(),
            new RemittanceInformation2Validator()
        ) { }
}
