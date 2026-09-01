// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DatePeriod3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Lk9JgUavEemG5fbqCekzMw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Range of time defined by a start date and an end date.
/// <list type="table">
///   <item><term>FromDate</term><description>ISODate — required (1..1)</description></item>
///   <item><term>ToDate</term><description>ISODate — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry) — in particular, there is no rule requiring ToDate to be on/after
/// FromDate in the spec's own dictionary entry for this component, so none is added here.
/// </remarks>
public class DatePeriod3Validator : AbstractValidator<DatePeriod3>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="DatePeriod3"/>.
    /// </summary>
    public DatePeriod3Validator()
    {
        // FromDate: required (1..1) and already `required` C# property — format enforced by
        // struct constructor.
        // ToDate: optional — format enforced by struct constructor.
    }
}
