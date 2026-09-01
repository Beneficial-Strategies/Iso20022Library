// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="AdviceType1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _u3TXw9omEembTrt_WixjyQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the type of advice requested for the transaction.
/// <list type="table">
///   <item><term><see cref="Choices.AdviceType1Choice.Code"/></term><description>Value: AdviceType1Code (closed enum, fully enforced, no further rule needed)</description></item>
///   <item><term><see cref="Choices.AdviceType1Choice.Proprietary"/></term><description>Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct/enum level already — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class AdviceType1Choice_Validator : AbstractValidator<AdviceType1Choice_> { }
