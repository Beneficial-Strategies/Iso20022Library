// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="Frequency36Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _sVM2vWk2Eeanu6HLe77Rkg
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Choice of format for a frequency, for example, the frequency of payment.
/// <list type="table">
///   <item><term><see cref="Choices.Frequency36Choice.Type"/></term><description>Specifies a frequency in terms of a specified period type — Value: Frequency6Code</description></item>
///   <item><term><see cref="Choices.Frequency36Choice.Period"/></term><description>Specifies a frequency in terms of a count per period within a specified period type — Type: Frequency6Code, CountPerPeriod: DecimalNumber</description></item>
///   <item><term><see cref="Choices.Frequency36Choice.PointInTime"/></term><description>Specifies a frequency in terms of an exact point in time or moment within a specified period type — Type: Frequency6Code, Value: Exact2NumericText</description></item>
/// </list>
///
/// Every variant's fields are fully enforced at the struct level already (closed codeset enum /
/// pattern-constrained <c>IIsoSimpleValue&lt;T&gt;</c> wrappers) — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class Frequency36Choice_Validator : AbstractValidator<Frequency36Choice_> { }
