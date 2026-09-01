// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TradeData20"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// TODO: Abbreviated validator — only enforces the known Defect 2 minimum-collection-size gap(s)
/// below. NOT yet reviewed for full spec compliance (other field-level constraints, cross-field
/// rules) or covered by a test file. Full treatment is being done first for CAMT-reachable
/// components; this one was not in that reachable set as of 2026-08-13. See
/// docs/multiplicity-audit-2026-08.md and docs/multiplicity-defect2-2026-08.tsv.
///
/// Known model defect(s):
/// <list type="table">
///   <item><term>ReportStatistics</term><description>ValueList&lt;T&gt; = [] allows empty, spec requires Min=1..&#8734;</description></item>
///   <item><term>TransactionStatistics</term><description>ValueList&lt;T&gt; = [] allows empty, spec requires Min=1..&#8734;</description></item>
/// </list>
/// </remarks>
public class TradeData20Validator : AbstractValidator<TradeData20>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="TradeData20"/>.
    /// </summary>
    public TradeData20Validator()
    {
        RuleFor(x => x.ReportStatistics)
            .NotEmpty()
            .WithMessage("TradeData20.ReportStatistics must contain at least one element (1..∞).");

        RuleFor(x => x.TransactionStatistics)
            .NotEmpty()
            .WithMessage("TradeData20.TransactionStatistics must contain at least one element (1..∞).");
    }
}
