// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MultilateralSettlementRequest3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _z-2GQTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-25). Promoted from an abbreviated
/// validator (Defect 2 minimum-collection-size rule only) to full-spec as part of scoping the
/// pacs business area's <c>MultilateralSettlementRequestV02</c>.
///
/// Provides details specific to the individual settlement instruction(s) included in the message.
/// <list type="table">
///   <item><term>InstructionIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>InstructionPriority</term><description>Priority3Code — optional (0..1); closed enum, no rule needed</description></item>
///   <item><term>MovementRecord</term><description>MovementRecord2 collection — required, min 2 (2..&#8734;) per MCP's <c>minOccurs=2</c> on this member</description></item>
///   <item><term>NumberOfMovementRecords</term><description>Number — optional (0..1)</description></item>
///   <item><term>SettlementCycle</term><description>Max35Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>SettlementPriority</term><description>Priority3Code — optional (0..1); closed enum, no rule needed</description></item>
///   <item><term>SettlementTimeRequest</term><description>SettlementTimeRequest2 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Known model defect: <c>MovementRecord</c> is <c>ValueList&lt;T&gt; = []</c>, which allows an
/// empty collection at the C# level even though the spec requires Min=2..&#8734;. Enforced here via
/// an explicit minimum-count rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// Dependency injection: <c>MovementRecord</c> (each item) and <c>SettlementTimeRequest</c> are
/// each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> —
/// see the two constructors below.
/// </remarks>
public class MultilateralSettlementRequest3Validator : AbstractValidator<MultilateralSettlementRequest3>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the <c>MovementRecord</c> collection's item type and the optional
    /// <c>SettlementTimeRequest</c> building block — e.g. resolved from a DI container — instead
    /// of this type constructing its own.
    /// </summary>
    /// <param name="movementRecordValidator">
    /// Validator for each item of the <c>MovementRecord</c> collection (MovementRecord2, 2..&#8734;).
    /// </param>
    /// <param name="settlementTimeRequestValidator">
    /// Validator for the optional <c>SettlementTimeRequest</c> building block
    /// (SettlementTimeRequest2, 0..1) — only invoked when present.
    /// </param>
    public MultilateralSettlementRequest3Validator(
        IValidator<MovementRecord2> movementRecordValidator,
        IValidator<SettlementTimeRequest2> settlementTimeRequestValidator
    )
    {
        // InstructionIdentification, SettlementCycle: length enforced by struct constructors — no rule needed.
        // InstructionPriority, SettlementPriority: closed Priority3Code enum, optional — no rule needed.
        // NumberOfMovementRecords: optional scalar — no rule needed.

        RuleFor(x => x.MovementRecord)
            .Must(records => records.Count >= 2)
            .WithMessage(
                "MultilateralSettlementRequest3.MovementRecord must contain at least two elements (2..∞)."
            );
        RuleForEach(x => x.MovementRecord).SetValidator(movementRecordValidator!);

        When(
            x => x.SettlementTimeRequest is not null,
            () => RuleFor(x => x.SettlementTimeRequest).SetValidator(settlementTimeRequestValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>MovementRecord</c> and
    /// <c>SettlementTimeRequest</c> are each validated by their own default validator
    /// (<see cref="MovementRecord2Validator"/>, <see cref="SettlementTimeRequest2Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MultilateralSettlementRequest3Validator()
        : this(new MovementRecord2Validator(), new SettlementTimeRequest2Validator()) { }
}
