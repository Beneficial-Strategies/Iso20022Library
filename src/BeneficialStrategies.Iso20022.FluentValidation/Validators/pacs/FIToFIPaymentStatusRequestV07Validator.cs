// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

/// <summary>
/// Validates <see cref="FIToFIPaymentStatusRequestV07"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pacs.028.001.07 (8fa60901-04a4-4c2d-8d76-a9c734a35cb6), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-25). Third message built for the pacs
/// business area.
///
/// The FinancialInstitutionToFinancialInstitutionPaymentStatusRequest message is sent by the
/// debtor agent to the creditor agent, directly or through other agents and/or a payment clearing
/// and settlement system. It is used to request a FIToFIPaymentStatusReport message containing
/// information on the status of a previously sent instruction.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader109 — required (1..1)</description></item>
///   <item><term>OriginalGroupInformation</term><description>OriginalGroupInformation27 collection — optional (0..&#8734;)</description></item>
///   <item><term>TransactionInformation</term><description>PaymentTransaction171 collection — optional (0..&#8734;)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// Constraints (from spec) — all three enforced here, since each depends on the message-level
/// <c>OriginalGroupInformation</c> collection's count alongside each transaction's own field:
/// <list type="bullet">
///   <item>
///     <term>OriginalGroupInformationAbsenceRule</term>
///     <description>
///       If <c>OriginalGroupInformation</c> is absent (count = 0), then every
///       <c>TransactionInformation[*].OriginalGroupInformation</c> must be present.
///     </description>
///   </item>
///   <item>
///     <term>OriginalGroupInformationSinglePresenceRule</term>
///     <description>
///       If <c>OriginalGroupInformation</c> is present exactly once (count = 1), then every
///       <c>TransactionInformation[*].OriginalGroupInformation</c> must be absent — the single
///       message-level original group applies to every transaction.
///     </description>
///   </item>
///   <item>
///     <term>OriginalGroupInformationMultiplePresenceRule</term>
///     <description>
///       If <c>OriginalGroupInformation</c> is present more than once (count &gt; 1), then every
///       <c>TransactionInformation[*].OriginalGroupInformation</c> must be present — with multiple
///       original groups in play, each transaction must disambiguate which one it refers to.
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
/// Dependency injection: <c>GroupHeader</c>, <c>OriginalGroupInformation</c>,
/// <c>TransactionInformation</c>, and <c>SupplementaryData</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class FIToFIPaymentStatusRequestV07Validator : AbstractValidator<FIToFIPaymentStatusRequestV07>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public FIToFIPaymentStatusRequestV07Validator(
        IValidator<GroupHeader109> groupHeaderValidator,
        IValidator<OriginalGroupInformation27> originalGroupInformationValidator,
        IValidator<PaymentTransaction171> transactionInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);

        RuleForEach(x => x.OriginalGroupInformation).SetValidator(originalGroupInformationValidator!);
        RuleForEach(x => x.TransactionInformation).SetValidator(transactionInformationValidator!);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);

        // ── OriginalGroupInformationAbsenceRule ──────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformation.Count != 0
                || x.TransactionInformation.All(t => t.OriginalGroupInformation is not null)
            )
            .WithName("OriginalGroupInformationAbsenceRule")
            .WithMessage(
                "FIToFIPaymentStatusRequestV07: if OriginalGroupInformation is absent, every "
                    + "TransactionInformation[*].OriginalGroupInformation must be present "
                    + "(OriginalGroupInformationAbsenceRule)."
            );

        // ── OriginalGroupInformationSinglePresenceRule ───────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformation.Count != 1
                || x.TransactionInformation.All(t => t.OriginalGroupInformation is null)
            )
            .WithName("OriginalGroupInformationSinglePresenceRule")
            .WithMessage(
                "FIToFIPaymentStatusRequestV07: if OriginalGroupInformation is present exactly "
                    + "once, every TransactionInformation[*].OriginalGroupInformation must be "
                    + "absent (OriginalGroupInformationSinglePresenceRule)."
            );

        // ── OriginalGroupInformationMultiplePresenceRule ─────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformation.Count <= 1
                || x.TransactionInformation.All(t => t.OriginalGroupInformation is not null)
            )
            .WithName("OriginalGroupInformationMultiplePresenceRule")
            .WithMessage(
                "FIToFIPaymentStatusRequestV07: if OriginalGroupInformation is present more than "
                    + "once, every TransactionInformation[*].OriginalGroupInformation must be "
                    + "present (OriginalGroupInformationMultiplePresenceRule)."
            );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public FIToFIPaymentStatusRequestV07Validator()
        : this(
            new GroupHeader109Validator(),
            new OriginalGroupInformation27Validator(),
            new PaymentTransaction171Validator(),
            new SupplementaryData1Validator()
        ) { }
}
