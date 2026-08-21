// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

/// <summary>
/// Validates <see cref="CreditorPaymentActivationRequestStatusReportV12"/> per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: pain.014.001.12 (f36c5c5e-539b-48a7-974d-3cfeeacd209e), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party
/// in the creditor payment activation request chain. It is used to inform the latter about the
/// positive or negative status of a creditor payment activation request (either single or file).
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader111 — required (1..1)</description></item>
///   <item><term>OriginalGroupInformationAndStatus</term><description>OriginalGroupInformation32 — required (1..1)</description></item>
///   <item><term>OriginalPaymentInformationAndStatus</term><description>OriginalPaymentInstruction52 collection — optional (0..n)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..n)</description></item>
/// </list>
///
/// Cross-field constraints (from spec) — all four reference
/// <c>OriginalGroupInformationAndStatus/GroupStatus</c> together with
/// <c>OriginalPaymentInformationAndStatus[*]/PaymentInformationStatus</c>, both
/// <see cref="ExternalPaymentGroupStatus1Code"/>-typed, so a single named rule applies uniformly
/// across every payment-information entry:
/// <list type="bullet">
///   <item>
///     <term>GroupStatusAcceptedRule</term>
///     <description>
///       If GroupStatus is present and is equal to ACTC (AcceptedTechnicalValidation), ACCP
///       (AcceptedCustomerProfile), ACSP (AcceptedSettlementInProcess), ACSC
///       (AcceptedSettlementCompleted) or ACWC (AcceptedWithChange), then every present
///       PaymentInformationStatus must be different from RJCT (Rejected).
///     </description>
///   </item>
///   <item>
///     <term>GroupStatusPendingRule</term>
///     <description>
///       If GroupStatus is present and is equal to PDNG (Pending), then every present
///       PaymentInformationStatus must be different from RJCT (Rejected).
///     </description>
///   </item>
///   <item>
///     <term>GroupStatusRejectedRule</term>
///     <description>
///       If GroupStatus is present and is equal to RJCT (Rejected), then every present
///       PaymentInformationStatus must be equal to RJCT (Rejected).
///     </description>
///   </item>
///   <item>
///     <term>GroupStatusReceivedRule</term>
///     <description>
///       If GroupStatus is present and is equal to RCVD (Received), then
///       PaymentInformationStatus is not allowed on any entry.
///     </description>
///   </item>
///   <item>
///     <term>SupplementaryDataRule</term>
///     <description>
///       The SupplementaryData building block at message level must not be used to provide
///       additional information about a transaction — the SupplementaryData element at
///       transaction level should be used for that purpose instead. Not independently
///       enforceable by this library — no structural signal distinguishes message-level-scoped
///       content from transaction-scoped content inside a <see cref="SupplementaryData1"/>
///       instance at the C# model level.
///     </description>
///   </item>
/// </list>
///
/// Dependency injection: <c>GroupHeader</c>, <c>OriginalGroupInformationAndStatus</c>,
/// <c>OriginalPaymentInformationAndStatus</c>, and <c>SupplementaryData</c> are each validated by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class CreditorPaymentActivationRequestStatusReportV12Validator
    : AbstractValidator<CreditorPaymentActivationRequestStatusReportV12>
{
    private static readonly ExternalPaymentGroupStatus1Code[] AcceptedStatuses =
    [
        ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation,
        ExternalPaymentGroupStatus1Code.AcceptedCustomerProfile,
        ExternalPaymentGroupStatus1Code.AcceptedSettlementInProcess,
        ExternalPaymentGroupStatus1Code.AcceptedSettlementCompletedDebitorAccount,
        ExternalPaymentGroupStatus1Code.AcceptedWithChange,
    ];

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CreditorPaymentActivationRequestStatusReportV12Validator(
        IValidator<GroupHeader111> groupHeaderValidator,
        IValidator<OriginalGroupInformation32> originalGroupInformationAndStatusValidator,
        IValidator<OriginalPaymentInstruction52> originalPaymentInformationAndStatusValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);
        RuleFor(x => x.OriginalGroupInformationAndStatus).SetValidator(originalGroupInformationAndStatusValidator!);
        RuleForEach(x => x.OriginalPaymentInformationAndStatus)
            .SetValidator(originalPaymentInformationAndStatusValidator!);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);

        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformationAndStatus.GroupStatus is not { } status
                || !AcceptedStatuses.Contains(status)
                || x.OriginalPaymentInformationAndStatus.All(p =>
                    p.PaymentInformationStatus != ExternalPaymentGroupStatus1Code.Rejected
                )
            )
            .WithName("GroupStatusAcceptedRule")
            .WithMessage(
                "CreditorPaymentActivationRequestStatusReportV12: when OriginalGroupInformationAndStatus.GroupStatus is ACTC/ACCP/ACSP/ACSC/ACWC, no OriginalPaymentInformationAndStatus entry's PaymentInformationStatus may be RJCT (GroupStatusAcceptedRule)."
            );

        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformationAndStatus.GroupStatus != ExternalPaymentGroupStatus1Code.Pending
                || x.OriginalPaymentInformationAndStatus.All(p =>
                    p.PaymentInformationStatus != ExternalPaymentGroupStatus1Code.Rejected
                )
            )
            .WithName("GroupStatusPendingRule")
            .WithMessage(
                "CreditorPaymentActivationRequestStatusReportV12: when OriginalGroupInformationAndStatus.GroupStatus is PDNG, no OriginalPaymentInformationAndStatus entry's PaymentInformationStatus may be RJCT (GroupStatusPendingRule)."
            );

        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformationAndStatus.GroupStatus != ExternalPaymentGroupStatus1Code.Rejected
                || x.OriginalPaymentInformationAndStatus.All(p =>
                    p.PaymentInformationStatus is null
                    || p.PaymentInformationStatus == ExternalPaymentGroupStatus1Code.Rejected
                )
            )
            .WithName("GroupStatusRejectedRule")
            .WithMessage(
                "CreditorPaymentActivationRequestStatusReportV12: when OriginalGroupInformationAndStatus.GroupStatus is RJCT, every present OriginalPaymentInformationAndStatus entry's PaymentInformationStatus must also be RJCT (GroupStatusRejectedRule)."
            );

        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformationAndStatus.GroupStatus != ExternalPaymentGroupStatus1Code.Received
                || x.OriginalPaymentInformationAndStatus.All(p => p.PaymentInformationStatus is null)
            )
            .WithName("GroupStatusReceivedRule")
            .WithMessage(
                "CreditorPaymentActivationRequestStatusReportV12: when OriginalGroupInformationAndStatus.GroupStatus is RCVD, no OriginalPaymentInformationAndStatus entry may have a PaymentInformationStatus (GroupStatusReceivedRule)."
            );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CreditorPaymentActivationRequestStatusReportV12Validator()
        : this(
            new GroupHeader111Validator(),
            new OriginalGroupInformation32Validator(),
            new OriginalPaymentInstruction52Validator(),
            new SupplementaryData1Validator()
        ) { }
}
