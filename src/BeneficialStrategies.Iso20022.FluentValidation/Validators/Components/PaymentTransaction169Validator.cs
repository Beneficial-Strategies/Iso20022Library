// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentTransaction169"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: f7d74e7a-eafe-4b68-be3f-295ba7da1349
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides further details on the original transactions, to which the status report message
/// refers.
/// <list type="table">
///   <item><term>StatusIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalInstructionIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalEndToEndIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalUETR</term><description>UUIDv4Identifier — optional (0..1), fully struct-enforced</description></item>
///   <item><term>TransactionStatus</term><description>ExternalPaymentTransactionStatus1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>StatusReasonInformation</term><description>StatusReasonInformation14 collection — optional (0..n)</description></item>
///   <item><term>PaymentConditionStatus</term><description>PaymentConditionStatus2 — optional (0..1)</description></item>
///   <item><term>ChargesInformation</term><description>Charges16 collection — optional (0..n)</description></item>
///   <item><term>DebtorDecisionDateTime</term><description>ISODateTime — optional (0..1), fully struct-enforced</description></item>
///   <item><term>AcceptanceDateTime</term><description>ISODateTime — optional (0..1), fully struct-enforced</description></item>
///   <item><term>AccountServicerReference</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>ClearingSystemReference</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalTransactionReference</term><description>OriginalTransactionReference46 — optional (0..1)</description></item>
///   <item><term>EnclosedFile</term><description>Document15 collection — optional (0..n)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: every building block above is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class PaymentTransaction169Validator : AbstractValidator<PaymentTransaction169>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PaymentTransaction169Validator(
        IValidator<StatusReasonInformation14> statusReasonInformationValidator,
        IValidator<PaymentConditionStatus2> paymentConditionStatusValidator,
        IValidator<Charges16> chargesInformationValidator,
        IValidator<OriginalTransactionReference46> originalTransactionReferenceValidator,
        IValidator<Document15> enclosedFileValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleForEach(x => x.StatusReasonInformation).SetValidator(statusReasonInformationValidator!);
        When(
            x => x.PaymentConditionStatus is not null,
            () => RuleFor(x => x.PaymentConditionStatus).SetValidator(paymentConditionStatusValidator!)
        );
        RuleForEach(x => x.ChargesInformation).SetValidator(chargesInformationValidator!);
        When(
            x => x.OriginalTransactionReference is not null,
            () => RuleFor(x => x.OriginalTransactionReference).SetValidator(originalTransactionReferenceValidator!)
        );
        RuleForEach(x => x.EnclosedFile).SetValidator(enclosedFileValidator!);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentTransaction169Validator()
        : this(
            new StatusReasonInformation14Validator(),
            new PaymentConditionStatus2Validator(),
            new Charges16Validator(),
            new OriginalTransactionReference46Validator(),
            new Document15Validator(),
            new SupplementaryData1Validator()
        ) { }
}
