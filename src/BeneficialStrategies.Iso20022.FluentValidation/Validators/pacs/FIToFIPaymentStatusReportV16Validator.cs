// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

/// <summary>
/// Validates <see cref="FIToFIPaymentStatusReportV16"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pacs.002.001.16 (42d3d142-0665-41d5-b5b7-87bdd32671d8), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-25). Fifth message built for the pacs
/// business area.
///
/// The FIToFIPaymentStatusReport message is sent by an instructed agent to the previous party in
/// the payment chain. It is used to inform this party about the positive or negative status of an
/// instruction (either single or file). It is also used to report on a pending instruction.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader120 — required (1..1)</description></item>
///   <item><term>OriginalGroupInformationAndStatus</term><description>OriginalGroupHeader22 collection — optional (0..&#8734;)</description></item>
///   <item><term>TransactionInformationAndStatus</term><description>PaymentTransaction177 collection — optional (0..&#8734;)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// Constraints (from spec) — 7 of 9 enforced here (the sibling
/// <c>OriginalGroupInformationAbsenceRule</c>/<c>SinglePresenceRule</c>/<c>MultiplePresenceRule</c>
/// trio, same 3-way count-keyed rule as <c>FIToFIPaymentStatusRequestV07Validator</c>, plus four
/// GroupStatus-conditioned rules; 1 is not independently enforceable, noted below):
/// <list type="bullet">
///   <item>
///     <term>OriginalGroupInformationAbsenceRule</term>
///     <description>If OriginalGroupInformationAndStatus is absent, every TransactionInformationAndStatus[*].OriginalGroupInformation must be present.</description>
///   </item>
///   <item>
///     <term>OriginalGroupInformationSinglePresenceRule</term>
///     <description>If OriginalGroupInformationAndStatus is present exactly once, every TransactionInformationAndStatus[*].OriginalGroupInformation must be absent.</description>
///   </item>
///   <item>
///     <term>OriginalGroupInformationMultiplePresenceRule</term>
///     <description>If OriginalGroupInformationAndStatus is present more than once, every TransactionInformationAndStatus[*].OriginalGroupInformation must be present.</description>
///   </item>
///   <item>
///     <term>GroupStatusAcceptedRule</term>
///     <description>If any OriginalGroupInformationAndStatus[*].GroupStatus is ACTC/ACCP/ACSP/ACSC/ACWC, every TransactionInformationAndStatus[*].TransactionStatus must differ from RJCT.</description>
///   </item>
///   <item>
///     <term>GroupStatusPendingRule</term>
///     <description>If any OriginalGroupInformationAndStatus[*].GroupStatus is PDNG, every TransactionInformationAndStatus[*].TransactionStatus must differ from RJCT.</description>
///   </item>
///   <item>
///     <term>GroupStatusRejectedRule</term>
///     <description>If any OriginalGroupInformationAndStatus[*].GroupStatus is RJCT, every TransactionInformationAndStatus[*].TransactionStatus, when present, must equal RJCT.</description>
///   </item>
///   <item>
///     <term>GroupStatusReceivedRule</term>
///     <description>If any OriginalGroupInformationAndStatus[*].GroupStatus is RCVD, every TransactionInformationAndStatus[*].TransactionStatus must be absent.</description>
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
/// The GroupStatus rules reference "OriginalGroupInformationAndStatus/GroupStatus" and
/// "TransactionInformationAndStatus/TransactionStatus" without indexing, even though both are
/// collections in this message version — interpreted here (consistent with how the sibling
/// Presence-rule trio treats the same collection) as: if <em>any</em> element of
/// <c>OriginalGroupInformationAndStatus</c> carries the triggering <c>GroupStatus</c>, the
/// consequent constrains <em>every</em> element of <c>TransactionInformationAndStatus</c>.
///
/// Dependency injection: <c>GroupHeader</c>, <c>OriginalGroupInformationAndStatus</c> (each
/// item), <c>TransactionInformationAndStatus</c> (each item), and <c>SupplementaryData</c> (each
/// item) are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c> — see the two constructors below.
/// </remarks>
public class FIToFIPaymentStatusReportV16Validator : AbstractValidator<FIToFIPaymentStatusReportV16>
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
    public FIToFIPaymentStatusReportV16Validator(
        IValidator<GroupHeader120> groupHeaderValidator,
        IValidator<OriginalGroupHeader22> originalGroupInformationAndStatusValidator,
        IValidator<PaymentTransaction177> transactionInformationAndStatusValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);

        RuleForEach(x => x.OriginalGroupInformationAndStatus)
            .SetValidator(originalGroupInformationAndStatusValidator!);
        RuleForEach(x => x.TransactionInformationAndStatus).SetValidator(transactionInformationAndStatusValidator!);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);

        // ── OriginalGroupInformationAbsenceRule ──────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformationAndStatus.Count != 0
                || x.TransactionInformationAndStatus.All(t => t.OriginalGroupInformation is not null)
            )
            .WithName("OriginalGroupInformationAbsenceRule")
            .WithMessage(
                "FIToFIPaymentStatusReportV16: if OriginalGroupInformationAndStatus is absent, every "
                    + "TransactionInformationAndStatus[*].OriginalGroupInformation must be present "
                    + "(OriginalGroupInformationAbsenceRule)."
            );

        // ── OriginalGroupInformationSinglePresenceRule ───────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformationAndStatus.Count != 1
                || x.TransactionInformationAndStatus.All(t => t.OriginalGroupInformation is null)
            )
            .WithName("OriginalGroupInformationSinglePresenceRule")
            .WithMessage(
                "FIToFIPaymentStatusReportV16: if OriginalGroupInformationAndStatus is present "
                    + "exactly once, every TransactionInformationAndStatus[*].OriginalGroupInformation "
                    + "must be absent (OriginalGroupInformationSinglePresenceRule)."
            );

        // ── OriginalGroupInformationMultiplePresenceRule ─────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformationAndStatus.Count <= 1
                || x.TransactionInformationAndStatus.All(t => t.OriginalGroupInformation is not null)
            )
            .WithName("OriginalGroupInformationMultiplePresenceRule")
            .WithMessage(
                "FIToFIPaymentStatusReportV16: if OriginalGroupInformationAndStatus is present more "
                    + "than once, every TransactionInformationAndStatus[*].OriginalGroupInformation "
                    + "must be present (OriginalGroupInformationMultiplePresenceRule)."
            );

        // ── GroupStatusAcceptedRule ───────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                !x.OriginalGroupInformationAndStatus.Any(g =>
                    g.GroupStatus is not null && AcceptedStatuses.Contains(g.GroupStatus.Value)
                )
                || x.TransactionInformationAndStatus.All(t =>
                    t.TransactionStatus != ExternalPaymentTransactionStatus1Code.Rejected
                )
            )
            .WithName("GroupStatusAcceptedRule")
            .WithMessage(
                "FIToFIPaymentStatusReportV16: if any OriginalGroupInformationAndStatus[*].GroupStatus "
                    + "is ACTC/ACCP/ACSP/ACSC/ACWC, every "
                    + "TransactionInformationAndStatus[*].TransactionStatus must differ from RJCT "
                    + "(GroupStatusAcceptedRule)."
            );

        // ── GroupStatusPendingRule ────────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                !x.OriginalGroupInformationAndStatus.Any(g => g.GroupStatus == ExternalPaymentGroupStatus1Code.Pending)
                || x.TransactionInformationAndStatus.All(t =>
                    t.TransactionStatus != ExternalPaymentTransactionStatus1Code.Rejected
                )
            )
            .WithName("GroupStatusPendingRule")
            .WithMessage(
                "FIToFIPaymentStatusReportV16: if any OriginalGroupInformationAndStatus[*].GroupStatus "
                    + "is PDNG, every TransactionInformationAndStatus[*].TransactionStatus must differ "
                    + "from RJCT (GroupStatusPendingRule)."
            );

        // ── GroupStatusRejectedRule ───────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                !x.OriginalGroupInformationAndStatus.Any(g =>
                    g.GroupStatus == ExternalPaymentGroupStatus1Code.Rejected
                )
                || x.TransactionInformationAndStatus.All(t =>
                    t.TransactionStatus is null || t.TransactionStatus == ExternalPaymentTransactionStatus1Code.Rejected
                )
            )
            .WithName("GroupStatusRejectedRule")
            .WithMessage(
                "FIToFIPaymentStatusReportV16: if any OriginalGroupInformationAndStatus[*].GroupStatus "
                    + "is RJCT, every TransactionInformationAndStatus[*].TransactionStatus, when "
                    + "present, must equal RJCT (GroupStatusRejectedRule)."
            );

        // ── GroupStatusReceivedRule ───────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                !x.OriginalGroupInformationAndStatus.Any(g =>
                    g.GroupStatus == ExternalPaymentGroupStatus1Code.Received
                )
                || x.TransactionInformationAndStatus.All(t => t.TransactionStatus is null)
            )
            .WithName("GroupStatusReceivedRule")
            .WithMessage(
                "FIToFIPaymentStatusReportV16: if any OriginalGroupInformationAndStatus[*].GroupStatus "
                    + "is RCVD, every TransactionInformationAndStatus[*].TransactionStatus must be "
                    + "absent (GroupStatusReceivedRule)."
            );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public FIToFIPaymentStatusReportV16Validator()
        : this(
            new GroupHeader120Validator(),
            new OriginalGroupHeader22Validator(),
            new PaymentTransaction177Validator(),
            new SupplementaryData1Validator()
        ) { }
}
