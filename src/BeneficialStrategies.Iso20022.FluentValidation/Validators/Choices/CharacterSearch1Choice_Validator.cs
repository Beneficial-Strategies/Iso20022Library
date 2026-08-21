// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="CharacterSearch1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _F7k20ZlaEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Set of characters to be matched to be considered as valid.
/// <list type="table">
///   <item><term><see cref="CharacterSearch1Choice.Equal"/></term><description>Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="CharacterSearch1Choice.NotEqual"/></term><description>Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="CharacterSearch1Choice.Contain"/></term><description>Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="CharacterSearch1Choice.NotContain"/></term><description>Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
/// </list>
///
/// All four variants are fully enforced at the struct level already — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class CharacterSearch1Choice_Validator : AbstractValidator<CharacterSearch1Choice_> { }
