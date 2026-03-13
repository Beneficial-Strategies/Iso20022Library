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
/// </remarks>
public sealed class UnderlyingTransaction28Validator : AbstractValidator<UnderlyingTransaction28>
{
    public UnderlyingTransaction28Validator()
    {
        // Practical check: at least one cancellation target must be specified.
        RuleFor(x => x)
            .Must(x => x.OriginalGroupInformationAndCancellation is not null
                    || x.TransactionInformation is not null)
                .WithName("UnderlyingTransaction28")
                .WithMessage(
                    "UnderlyingTransaction28: at least one of OriginalGroupInformationAndCancellation " +
                    "or TransactionInformation must be present.");

        // ── GroupCancellationAndReasonRule ───────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
            {
                if (x.OriginalGroupInformationAndCancellation?.GroupCancellation != "true")
                    return true;
                return x.OriginalGroupInformationAndCancellation
                         .CancellationReasonInformation?.Reason is not null;
            })
                .WithName("GroupCancellationAndReasonRule")
                .WithMessage(
                    "If GroupCancellation is true, CancellationReasonInformation/Reason must be present " +
                    "(GroupCancellationAndReasonRule).");

        // ── GroupCancellationAndNumberOfTransactionsRule ─────────────────────────
        RuleFor(x => x)
            .Must(x =>
            {
                if (x.OriginalGroupInformationAndCancellation?.GroupCancellation != "false")
                    return true;
                var nbStr = x.OriginalGroupInformationAndCancellation.NumberOfTransactions;
                if (nbStr is null) return true; // NumberOfTransactions is optional — skip if absent
                if (!int.TryParse(nbStr, out int nb)) return false;
                int txCount = x.TransactionInformation is null ? 0 : 1;
                return nb == txCount;
            })
                .WithName("GroupCancellationAndNumberOfTransactionsRule")
                .WithMessage(
                    "If GroupCancellation is false, NumberOfTransactions must equal the number of " +
                    "TransactionInformation occurrences (GroupCancellationAndNumberOfTransactionsRule).");

        // ── GroupCancellationTrueAndTransactionInformationRule ───────────────────
        RuleFor(x => x)
            .Must(x =>
                !(x.OriginalGroupInformationAndCancellation?.GroupCancellation == "true"
                  && x.TransactionInformation is not null))
                .WithName("GroupCancellationTrueAndTransactionInformationRule")
                .WithMessage(
                    "If GroupCancellation is true, TransactionInformation must not be present " +
                    "(GroupCancellationTrueAndTransactionInformationRule).");

        // ── GroupCancellationFalseAndTransactionInformationRule ──────────────────
        RuleFor(x => x)
            .Must(x =>
                !(x.OriginalGroupInformationAndCancellation?.GroupCancellation == "false"
                  && x.TransactionInformation is null))
                .WithName("GroupCancellationFalseAndTransactionInformationRule")
                .WithMessage(
                    "If GroupCancellation is false, TransactionInformation must be present " +
                    "(GroupCancellationFalseAndTransactionInformationRule).");

        // ── GroupOrTransactionCaseRule ───────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                !(x.OriginalGroupInformationAndCancellation?.Case is not null
                  && x.TransactionInformation?.Case is not null))
                .WithName("GroupOrTransactionCaseRule")
                .WithMessage(
                    "Case may be present at either OriginalGroupInformationAndCancellation or " +
                    "TransactionInformation level, but not both (GroupOrTransactionCaseRule).");

        // ── Nested component validators ──────────────────────────────────────────
        When(x => x.OriginalGroupInformationAndCancellation is not null, () =>
            RuleFor(x => x.OriginalGroupInformationAndCancellation)
                .SetValidator(new OriginalGroupHeader15Validator()!));

        When(x => x.TransactionInformation is not null, () =>
            RuleFor(x => x.TransactionInformation)
                .SetValidator(new PaymentTransaction137Validator()!));
    }
}
