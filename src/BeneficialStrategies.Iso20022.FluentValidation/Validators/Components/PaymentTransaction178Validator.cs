// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentTransaction178"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 11374abc-92e8-4404-9e28-3abe0e95451e
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
///   <item><term>ChargesInformation</term><description>Charges16 collection — optional (0..n)</description></item>
///   <item><term>TrackerData</term><description>TrackerData7 — optional (0..1)</description></item>
///   <item><term>AcceptanceDateTime</term><description>ISODateTime — optional (0..1), fully struct-enforced</description></item>
///   <item><term>AccountServicerReference</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>ClearingSystemReference</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalTransactionReference</term><description>OriginalTransactionReference47 — optional (0..1)</description></item>
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
public class PaymentTransaction178Validator : AbstractValidator<PaymentTransaction178>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PaymentTransaction178Validator(
        IValidator<StatusReasonInformation14> statusReasonInformationValidator,
        IValidator<Charges16> chargesInformationValidator,
        IValidator<TrackerData7> trackerDataValidator,
        IValidator<OriginalTransactionReference47> originalTransactionReferenceValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleForEach(x => x.StatusReasonInformation).SetValidator(statusReasonInformationValidator!);
        RuleForEach(x => x.ChargesInformation).SetValidator(chargesInformationValidator!);
        When(
            x => x.TrackerData is not null,
            () => RuleFor(x => x.TrackerData).SetValidator(trackerDataValidator!)
        );
        When(
            x => x.OriginalTransactionReference is not null,
            () => RuleFor(x => x.OriginalTransactionReference).SetValidator(originalTransactionReferenceValidator!)
        );
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentTransaction178Validator()
        : this(
            new StatusReasonInformation14Validator(),
            new Charges16Validator(),
            new TrackerData7Validator(),
            new OriginalTransactionReference47Validator(),
            new SupplementaryData1Validator()
        ) { }
}
