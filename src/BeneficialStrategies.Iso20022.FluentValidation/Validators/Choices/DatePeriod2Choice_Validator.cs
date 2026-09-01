// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="DatePeriod2Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _jNAKm5lPEee-Zps0fZQaFQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Range of time defined by a start date and an end date.
/// <list type="table">
///   <item><term><see cref="Choices.DatePeriod2Choice.FromDate"/></term><description>Value: ISODate (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="Choices.DatePeriod2Choice.ToDate"/></term><description>Value: ISODate (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="Choices.DatePeriod2Choice.FromToDate"/></term><description>FromDate, ToDate — both ISODate, fully struct-enforced, no further rule needed</description></item>
/// </list>
///
/// All three variants are fully enforced at the struct level already — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class DatePeriod2Choice_Validator : AbstractValidator<DatePeriod2Choice_> { }
