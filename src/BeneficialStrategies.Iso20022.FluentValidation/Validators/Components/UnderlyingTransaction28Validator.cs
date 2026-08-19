// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="UnderlyingTransaction28"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _c7S7gdcZEeqRFcf2R4bPBw
/// Spec source: queried via ISO 20022 MCP server (2026-03-13).
/// <list type="table">
///   <item><term>OriginalGroupInformationAndCancellation</term><description>OriginalGroupHeader15 — optional (0..1)</description></item>
///   <item><term>TransactionInformation</term><description>PaymentTransaction137 — optional (0..∞)</description></item>
/// </list>
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>GroupCancellationAndReasonRule</term>
///     <description>
///       If OriginalGroupInformationAndCancellation/GroupCancellation is true, then
///       OriginalGroupInformationAndCancellation/CancellationReasonInformation/Reason must be present.
///     </description>
///   </item>
///   <item>
///     <term>GroupCancellationAndNumberOfTransactionsRule</term>
///     <description>
///       If OriginalGroupInformationAndCancellation/GroupCancellation is false, then
///       NumberOfTransactions must equal the number of occurrences of TransactionInformation.
///       Note: the C# model represents TransactionInformation as a single nullable (0 or 1),
///       so NumberOfTransactions must be "0" or "1" matching that count.
///     </description>
///   </item>
///   <item>
///     <term>GroupCancellationTrueAndTransactionInformationRule</term>
///     <description>If OriginalGroupInformationAndCancellation/GroupCancellation is true, then TransactionInformation is not allowed.</description>
///   </item>
///   <item>
///     <term>GroupCancellationFalseAndTransactionInformationRule</term>
///     <description>If OriginalGroupInformationAndCancellation/GroupCancellation is false, then TransactionInformation must be present.</description>
///   </item>
///   <item>
///     <term>GroupOrTransactionCaseRule</term>
///     <description>
///       Case may be present at either OriginalGroupInformationAndCancellation or
///       TransactionInformation level, but not both simultaneously within this component.
///       (The broader rule across message-level Case is enforced in the message validator.)
///     </description>
///   </item>
/// </list>
///
/// Dependency injection: the <c>OriginalGroupInformationAndCancellation</c> building block and
/// the <c>TransactionInformation</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class UnderlyingTransaction28Validator : AbstractValidator<UnderlyingTransaction28>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>OriginalGroupInformationAndCancellation</c> building block and for the
    /// <c>TransactionInformation</c> collection's item type — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="originalGroupInformationAndCancellationValidator">
    /// Validator for the optional <c>OriginalGroupInformationAndCancellation</c> building block
    /// (OriginalGroupHeader15, 0..1) — only invoked when present.
    /// </param>
    /// <param name="transactionInformationValidator">
    /// Validator for each item of the <c>TransactionInformation</c> collection
    /// (PaymentTransaction137, 0..∞).
    /// </param>
    public UnderlyingTransaction28Validator(
        IValidator<OriginalGroupHeader15> originalGroupInformationAndCancellationValidator,
        IValidator<PaymentTransaction137> transactionInformationValidator
    )
    {
        // Practical check: at least one cancellation target must be specified.
        RuleFor(x => x)
            .Must(x =>
                x.OriginalGroupInformationAndCancellation is not null
                || x.TransactionInformation.Count > 0
            )
            .WithName("UnderlyingTransaction28")
            .WithMessage(
                "UnderlyingTransaction28: at least one of OriginalGroupInformationAndCancellation "
                    + "or TransactionInformation must be present."
            );

        // ── GroupCancellationAndReasonRule ───────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
            {
                if (x.OriginalGroupInformationAndCancellation?.GroupCancellation?.BoolValue != true)
                    return true;
                return x.OriginalGroupInformationAndCancellation
                    .CancellationReasonInformation
                    .Any(r => r.Reason is not null);
            })
            .WithName("GroupCancellationAndReasonRule")
            .WithMessage(
                "If GroupCancellation is true, CancellationReasonInformation/Reason must be present "
                    + "(GroupCancellationAndReasonRule)."
            );

        // ── GroupCancellationAndNumberOfTransactionsRule ─────────────────────────
        RuleFor(x => x)
            .Must(x =>
            {
                if (x.OriginalGroupInformationAndCancellation?.GroupCancellation?.BoolValue != false)
                    return true;
                var nbStr = x.OriginalGroupInformationAndCancellation.NumberOfTransactions;
                if (nbStr is null)
                    return true; // NumberOfTransactions is optional — skip if absent
                if (!int.TryParse(nbStr, out int nb))
                    return false;
                int txCount = x.TransactionInformation.Count;
                return nb == txCount;
            })
            .WithName("GroupCancellationAndNumberOfTransactionsRule")
            .WithMessage(
                "If GroupCancellation is false, NumberOfTransactions must equal the number of "
                    + "TransactionInformation occurrences (GroupCancellationAndNumberOfTransactionsRule)."
            );

        // ── GroupCancellationTrueAndTransactionInformationRule ───────────────────
        RuleFor(x => x)
            .Must(x =>
                !(
                    x.OriginalGroupInformationAndCancellation?.GroupCancellation?.BoolValue == true
                    && x.TransactionInformation.Count > 0
                )
            )
            .WithName("GroupCancellationTrueAndTransactionInformationRule")
            .WithMessage(
                "If GroupCancellation is true, TransactionInformation must not be present "
                    + "(GroupCancellationTrueAndTransactionInformationRule)."
            );

        // ── GroupCancellationFalseAndTransactionInformationRule ──────────────────
        RuleFor(x => x)
            .Must(x =>
                !(
                    x.OriginalGroupInformationAndCancellation?.GroupCancellation?.BoolValue == false
                    && x.TransactionInformation.Count == 0
                )
            )
            .WithName("GroupCancellationFalseAndTransactionInformationRule")
            .WithMessage(
                "If GroupCancellation is false, TransactionInformation must be present "
                    + "(GroupCancellationFalseAndTransactionInformationRule)."
            );

        // ── GroupOrTransactionCaseRule ───────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                !(
                    x.OriginalGroupInformationAndCancellation?.Case is not null
                    && x.TransactionInformation.Any(t => t.Case is not null)
                )
            )
            .WithName("GroupOrTransactionCaseRule")
            .WithMessage(
                "Case may be present at either OriginalGroupInformationAndCancellation or "
                    + "TransactionInformation level, but not both (GroupOrTransactionCaseRule)."
            );

        // ── Nested component validators ──────────────────────────────────────────
        When(
            x => x.OriginalGroupInformationAndCancellation is not null,
            () =>
                RuleFor(x => x.OriginalGroupInformationAndCancellation)
                    .SetValidator(originalGroupInformationAndCancellationValidator!)
        );

        RuleForEach(x => x.TransactionInformation).SetValidator(transactionInformationValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the
    /// <c>OriginalGroupInformationAndCancellation</c> building block and the
    /// <c>TransactionInformation</c> collection are each validated by their own default validator
    /// (<see cref="OriginalGroupHeader15Validator"/>, <see cref="PaymentTransaction137Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public UnderlyingTransaction28Validator()
        : this(new OriginalGroupHeader15Validator(), new PaymentTransaction137Validator()) { }
}
