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
///
/// Dependency injection: each nested building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below. IValidator&lt;T&gt;, not AbstractValidator&lt;T&gt;, so that
/// FluentValidation's own <c>AddValidatorsFromAssemblyContaining&lt;T&gt;()</c> DI registration
/// helper (which registers every validator as IValidator&lt;T&gt;) wires the DI constructor up
/// automatically, with no manual per-type registration required from consumers.
/// </remarks>
public class FIToFIPaymentCancellationRequestV10Validator
    : AbstractValidator<FIToFIPaymentCancellationRequestV10>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for each nested building block — e.g. resolved from a DI container — instead of this type
    /// constructing its own. This lets a caller substitute, decorate, or mock any nested
    /// validator independently (e.g. a stricter <see cref="CaseAssignment5Validator"/> subtype)
    /// without forking this class.
    /// </summary>
    /// <param name="caseAssignmentValidator">
    /// Validator for the required <c>Assignment</c> building block (CaseAssignment5, 1..1).
    /// </param>
    /// <param name="underlyingTransactionValidator">
    /// Validator for the required <c>Underlying</c> building block (UnderlyingTransaction28, 1..1).
    /// </param>
    /// <param name="caseValidator">
    /// Validator for the optional <c>Case</c> building block (Case5, 0..1) — only invoked when present.
    /// </param>
    /// <param name="controlDataValidator">
    /// Validator for the optional <c>ControlData</c> building block (ControlData1, 0..1) — only invoked when present.
    /// </param>
    public FIToFIPaymentCancellationRequestV10Validator(
        IValidator<CaseAssignment5> caseAssignmentValidator,
        IValidator<UnderlyingTransaction28> underlyingTransactionValidator,
        IValidator<Case5> caseValidator,
        IValidator<ControlData1> controlDataValidator
    )
    {
        // ── Required building blocks ─────────────────────────────────────────────────

        RuleFor(x => x.Assignment)
            .NotNull()
            .WithMessage(
                "FIToFIPaymentCancellationRequestV10.Assignment is required (CaseAssignment5, 1..1)."
            )
            .SetValidator(caseAssignmentValidator);

        RuleFor(x => x.Underlying)
            .NotNull()
            .WithMessage(
                "FIToFIPaymentCancellationRequestV10.Underlying is required (UnderlyingTransaction28, 1..1)."
            )
            .SetValidator(underlyingTransactionValidator);

        // ── Optional building blocks — validate when present ─────────────────────────

        When(x => x.Case is not null, () => RuleFor(x => x.Case).SetValidator(caseValidator!));

        When(
            x => x.ControlData is not null,
            () => RuleFor(x => x.ControlData).SetValidator(controlDataValidator!)
        );

        // SupplementaryData: SupplementaryData1 (0..1) — no validator exists yet for
        // SupplementaryData1, so the SupplementaryDataRule cross-field constraint documented
        // above (message-level block must not convey per-transaction information) is not yet
        // enforced here.

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

    /// <summary>
    /// Initializes a new instance using default dependencies: each nested building block is
    /// validated by its own default validator (<see cref="CaseAssignment5Validator"/>,
    /// <see cref="UnderlyingTransaction28Validator"/>, <see cref="Case5Validator"/>,
    /// <see cref="ControlData1Validator"/>). Convenience constructor for callers not using a DI
    /// container.
    /// </summary>
    public FIToFIPaymentCancellationRequestV10Validator()
        : this(
            new CaseAssignment5Validator(),
            new UnderlyingTransaction28Validator(),
            new Case5Validator(),
            new ControlData1Validator()
        ) { }

    private static bool NoCaseDuplication(FIToFIPaymentCancellationRequestV10 msg)
    {
        int count = 0;
        if (msg.Case is not null)
            count++;
        if (msg.Underlying?.OriginalGroupInformationAndCancellation?.Case is not null)
            count++;
        if (msg.Underlying?.TransactionInformation?.Any(t => t.Case is not null) == true)
            count++;
        return count <= 1;
    }
}
