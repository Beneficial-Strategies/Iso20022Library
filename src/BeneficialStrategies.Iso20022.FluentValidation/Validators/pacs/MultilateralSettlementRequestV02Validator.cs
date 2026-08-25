// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

/// <summary>
/// Validates <see cref="MultilateralSettlementRequestV02"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: pacs.029.001.02 (_R3QfeTEZEe6kQ-WGAhcVPQ), Registered.
/// Spec source: queried via ISO 20022 MCP server (2026-08-25). First message built for the pacs
/// business area — see the pacs scoping summary for the reachable-graph analysis.
///
/// The MultilateralSettlementRequest message is sent from an instructing agent to a market
/// infrastructure to settle obligations between their participants using accounts held in a
/// settlement service.
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader104 — required (1..1)</description></item>
///   <item><term>SettlementRequest</term><description>MultilateralSettlementRequest3 collection — required, min 1 (1..&#8734;) per MCP's <c>minOccurs=1</c> on this building block</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Known model defect: <c>SettlementRequest</c> is <c>ValueList&lt;T&gt; = []</c>, which allows an
/// empty collection at the C# level even though the spec requires Min=1..&#8734;. Enforced here via
/// an explicit <c>NotEmpty</c> rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// Dependency injection: <c>GroupHeader</c>, <c>SettlementRequest</c>, and <c>SupplementaryData</c>
/// are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c> — see the two constructors below.
/// </remarks>
public class MultilateralSettlementRequestV02Validator : AbstractValidator<MultilateralSettlementRequestV02>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public MultilateralSettlementRequestV02Validator(
        IValidator<GroupHeader104> groupHeaderValidator,
        IValidator<MultilateralSettlementRequest3> settlementRequestValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator!);

        RuleFor(x => x.SettlementRequest)
            .NotEmpty()
            .WithMessage(
                "MultilateralSettlementRequestV02.SettlementRequest must contain at least one element (1..∞)."
            );
        RuleForEach(x => x.SettlementRequest).SetValidator(settlementRequestValidator!);

        When(
            x => x.SupplementaryData is not null,
            () => RuleFor(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public MultilateralSettlementRequestV02Validator()
        : this(
            new GroupHeader104Validator(),
            new MultilateralSettlementRequest3Validator(),
            new SupplementaryData1Validator()
        ) { }
}
