// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="FIToFIPaymentCancellationRequestV10"/> (camt.056.001.10)
/// per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _IBjZgdcBEeq_l4BJLVUF2Q  |  XSD: camt.056.001.10
/// Spec source: queried via ISO 20022 MCP server (2026-03-13).
///
/// Building blocks:
/// <list type="table">
///   <item><term>Assignment</term><description>CaseAssignment5 — required (1..1)</description></item>
///   <item><term>Case</term><description>Case5 — optional (0..1)</description></item>
///   <item><term>ControlData</term><description>ControlData1 — optional (0..1)</description></item>
///   <item><term>Underlying</term><description>UnderlyingTransaction28 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..1)</description></item>
/// </list>
///
/// Cross-field constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>MessageOrGroupCaseRule / MessageOrTransactionCaseRule</term>
///     <description>
///       A Case identification must appear at most once across the three possible
///       locations: message-level Case, Underlying.OriginalGroupInformationAndCancellation.Case,
///       and Underlying.TransactionInformation.Case.
///     </description>
///   </item>
///   <item>
///     <term>SupplementaryDataRule</term>
///     <description>
///       The message-level SupplementaryData block must not be used to convey
///       additional information about an individual transaction; use the
///       transaction-level SupplementaryData for that purpose.
///     </description>
///   </item>
/// </list>
/// </remarks>
public sealed class FIToFIPaymentCancellationRequestV10Validator
    : AbstractValidator<FIToFIPaymentCancellationRequestV10>
{
    public FIToFIPaymentCancellationRequestV10Validator()
    {
        // ── Required building blocks ─────────────────────────────────────────────────

        RuleFor(x => x.Assignment)
            .NotNull()
            .WithMessage(
                "FIToFIPaymentCancellationRequestV10.Assignment is required (CaseAssignment5, 1..1)."
            )
            .SetValidator(new CaseAssignment5Validator());

        RuleFor(x => x.Underlying)
            .NotNull()
            .WithMessage(
                "FIToFIPaymentCancellationRequestV10.Underlying is required (UnderlyingTransaction28, 1..1)."
            )
            .SetValidator(new UnderlyingTransaction28Validator());

        // ── Optional building blocks — validate when present ─────────────────────────

        When(
            x => x.Case is not null,
            () => RuleFor(x => x.Case).SetValidator(new Case5Validator()!)
        );

        When(
            x => x.ControlData is not null,
            () => RuleFor(x => x.ControlData).SetValidator(new ControlData1Validator()!)
        );

        // ── Cross-field: MessageOrGroupCaseRule / MessageOrTransactionCaseRule ───────
        // Spec: Case may be present at either Case, OriginalGroupInformationAndCancellation,
        // or TransactionInformation level — not more than one simultaneously.
        RuleFor(x => x)
            .Must(NoCaseDuplication)
            .WithName("MessageOrGroupCaseRule")
            .WithMessage(
                "Case identification must appear in at most one location: message-level Case, "
                    + "Underlying.OriginalGroupInformationAndCancellation.Case, or "
                    + "Underlying.TransactionInformation.Case "
                    + "(MessageOrGroupCaseRule / MessageOrTransactionCaseRule)."
            );
    }

    private static bool NoCaseDuplication(FIToFIPaymentCancellationRequestV10 msg)
    {
        int count = 0;
        if (msg.Case is not null)
            count++;
        if (msg.Underlying?.OriginalGroupInformationAndCancellation?.Case is not null)
            count++;
        if (msg.Underlying?.TransactionInformation?.Case is not null)
            count++;
        return count <= 1;
    }
}
