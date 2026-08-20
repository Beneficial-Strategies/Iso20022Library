// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="LimitType1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _79FX8KMgEeCJ6YNENx4h-w_1397757128
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Nature of the risk management limit defined as a choice between a coded list or a proprietary
/// limit.
/// <list type="table">
///   <item><term><see cref="LimitType1Choice.Code"/></term><description>Specifies the type of risk management limit — Value: LimitType3Code (closed enum, fully enforced, no further rule needed)</description></item>
///   <item><term><see cref="LimitType1Choice.Proprietary"/></term><description>Type of the limit, in a proprietary form — Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct/enum level already — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class LimitType1Choice_Validator : AbstractValidator<LimitType1Choice_> { }
