// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="DateAndDateTime2Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _fGuzgZlhEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Choice between a date or a date and time format.
/// <list type="table">
///   <item><term><see cref="Choices.DateAndDateTime2Choice.Date"/></term><description>Value: ISODate (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="Choices.DateAndDateTime2Choice.DateTime"/></term><description>Value: ISODateTime (fully struct-enforced, no further rule needed)</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct level already — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class DateAndDateTime2Choice_Validator : AbstractValidator<DateAndDateTime2Choice_> { }
