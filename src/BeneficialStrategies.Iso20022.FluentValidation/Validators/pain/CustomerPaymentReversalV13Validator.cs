// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

/// <summary>
/// Validates <see cref="CustomerPaymentReversalV13"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pain.007.001.13 (bf413c78-37ae-4bd7-bfe4-b88659e3626d), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// The CustomerPaymentReversal message is sent by the initiating party to the next party in the
/// payment chain. It is used to reverse a payment previously executed.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader124 — required (1..1)</description></item>
///   <item><term>OriginalGroupInformation</term><description>OriginalGroupHeader20 — required (1..1)</description></item>
///   <item><term>OriginalPaymentInformationAndReversal</term><description>OriginalPaymentInstruction53 collection — optional per the C# model (0..n), but conditionally required/forbidden by <c>GroupReversal</c> — see cross-field rules below</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..n)</description></item>
/// </list>
///
/// Cross-field constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>GroupReversalAndPaymentInformationNotPresentRule</term>
///     <description>
///       If GroupHeader/GroupReversal is true, then OriginalPaymentInformationAndReversal is not
///       allowed.
///     </description>
///   </item>
///   <item>
///     <term>GroupReversalAndReasonRule</term>
///     <description>
///       If GroupHeader/GroupReversal is true, then OriginalGroupInformation/
///       ReversalReasonInformation/Reason must be present (at least one entry with a non-null
///       Reason).
///     </description>
///   </item>
///   <item>
///     <term>GroupReversalAndPaymentInformationPresentRule</term>
///     <description>
///       If GroupHeader/GroupReversal is false, then at least one occurrence of
///       OriginalPaymentInformationAndReversal must be present. Combined with
///       GroupReversalAndPaymentInformationNotPresentRule above, this makes
///       OriginalPaymentInformationAndReversal presence an exact complement of
///       GroupReversal — present if and only if GroupReversal is not true. A <c>null</c>
///       GroupReversal is treated the same as <c>false</c> (not explicitly stated in the two
///       source rules' text, but the only reading under which every message satisfies exactly
///       one of the two rules).
///     </description>
///   </item>
///   <item>
///     <term>GroupReversalAndNumberOfTransactionsGuideline</term>
///     <description>
///       If GroupHeader/GroupReversal is false and every present
///       OriginalPaymentInformationAndReversal[*]/PaymentInformationReversal is false, then
///       NumberOfTransactions must equal the total number of occurrences of
///       OriginalPaymentInformationAndReversal[*]/TransactionInformation across the whole
///       message. A <c>null</c> PaymentInformationReversal on any entry is treated the same as
///       <c>false</c> for this check, consistent with the GroupReversal treatment above.
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
/// <c>OriginalPaymentInformationAndReversal</c>, and <c>SupplementaryData</c> are each validated
/// by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class CustomerPaymentReversalV13Validator : AbstractValidator<CustomerPaymentReversalV13>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CustomerPaymentReversalV13Validator(
        IValidator<GroupHeader124> groupHeaderValidator,
        IValidator<OriginalGroupHeader20> originalGroupInformationValidator,
        IValidator<OriginalPaymentInstruction53> originalPaymentInformationAndReversalValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);
        RuleFor(x => x.OriginalGroupInformation).SetValidator(originalGroupInformationValidator!);
        RuleForEach(x => x.OriginalPaymentInformationAndReversal)
            .SetValidator(originalPaymentInformationAndReversalValidator!);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);

        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.GroupReversal is not { BoolValue: true }
                || x.OriginalPaymentInformationAndReversal.Count == 0
            )
            .WithName("GroupReversalAndPaymentInformationNotPresentRule")
            .WithMessage(
                "CustomerPaymentReversalV13: when GroupHeader.GroupReversal is true, OriginalPaymentInformationAndReversal is not allowed (GroupReversalAndPaymentInformationNotPresentRule)."
            );

        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.GroupReversal is not { BoolValue: true }
                || x.OriginalGroupInformation.ReversalReasonInformation.Any(r => r.Reason is not null)
            )
            .WithName("GroupReversalAndReasonRule")
            .WithMessage(
                "CustomerPaymentReversalV13: when GroupHeader.GroupReversal is true, OriginalGroupInformation.ReversalReasonInformation must contain at least one entry with Reason present (GroupReversalAndReasonRule)."
            );

        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.GroupReversal is { BoolValue: true }
                || x.OriginalPaymentInformationAndReversal.Count > 0
            )
            .WithName("GroupReversalAndPaymentInformationPresentRule")
            .WithMessage(
                "CustomerPaymentReversalV13: when GroupHeader.GroupReversal is false, at least one OriginalPaymentInformationAndReversal entry must be present (GroupReversalAndPaymentInformationPresentRule)."
            );

        RuleFor(x => x)
            .Must(x =>
                x.GroupHeader.GroupReversal is { BoolValue: true }
                || x.OriginalPaymentInformationAndReversal.Any(p => p.PaymentInformationReversal is { BoolValue: true })
                || int.Parse(x.GroupHeader.NumberOfTransactions.ToString())
                    == x.OriginalPaymentInformationAndReversal.Sum(p => p.TransactionInformation.Count)
            )
            .WithName("GroupReversalAndNumberOfTransactionsGuideline")
            .WithMessage(
                "CustomerPaymentReversalV13: when GroupHeader.GroupReversal is false and every OriginalPaymentInformationAndReversal entry's PaymentInformationReversal is false, GroupHeader.NumberOfTransactions must equal the total count of TransactionInformation entries across the message (GroupReversalAndNumberOfTransactionsGuideline)."
            );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CustomerPaymentReversalV13Validator()
        : this(
            new GroupHeader124Validator(),
            new OriginalGroupHeader20Validator(),
            new OriginalPaymentInstruction53Validator(),
            new SupplementaryData1Validator()
        ) { }
}
