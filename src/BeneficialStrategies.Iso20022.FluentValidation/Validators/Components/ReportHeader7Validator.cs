// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ReportHeader7"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1LHsITEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies generic information about an investigation report.
/// <list type="table">
///   <item><term>Identification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>From</term><description>Party50Choice_ — required (1..1)</description></item>
///   <item><term>To</term><description>Party50Choice_ — required (1..1)</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: <c>From</c> and <c>To</c> share the same
/// <see cref="IValidator{T}"/> for <c>Party50Choice_</c> — one injected validator serves both
/// properties.
/// </remarks>
public class ReportHeader7Validator : AbstractValidator<ReportHeader7>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>From</c>/<c>To</c> building blocks — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="partyValidator">Validator for the <c>From</c> and <c>To</c> building blocks (both Party50Choice_).</param>
    public ReportHeader7Validator(IValidator<Party50Choice_> partyValidator)
    {
        // Identification, CreationDateTime: required (1..1) and already `required` C# properties
        // — format enforced by struct constructors.

        RuleFor(x => x.From).SetValidator(partyValidator);
        RuleFor(x => x.To).SetValidator(partyValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>From</c>/<c>To</c> are validated
    /// by their own default validator (<see cref="Party50Choice_Validator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public ReportHeader7Validator()
        : this(new Party50Choice_Validator()) { }
}
