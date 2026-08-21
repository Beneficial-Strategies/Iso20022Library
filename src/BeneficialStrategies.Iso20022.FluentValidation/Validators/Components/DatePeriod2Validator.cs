// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DatePeriod2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _lZP5MYaDEee8r9VKRbnJSg
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Range of time defined by a start date and an end date.
/// <list type="table">
///   <item><term>FromDate</term><description>ISODate — required (1..1), fully struct-enforced</description></item>
///   <item><term>ToDate</term><description>ISODate — required (1..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry) — in particular, MCP publishes no rule requiring
/// <c>FromDate &lt;= ToDate</c>, so none is added here.
///
/// Both fields are fully enforced at the struct level already — there is no additional rule to
/// add at the FluentValidation layer, so this validator has no rules. It still exists as a
/// first-class type so the coverage-scoping policy (see the FluentValidation project's own
/// <c>CLAUDE.md</c>) can record this type as reviewed rather than silently skipped.
/// </remarks>
public class DatePeriod2Validator : AbstractValidator<DatePeriod2> { }
