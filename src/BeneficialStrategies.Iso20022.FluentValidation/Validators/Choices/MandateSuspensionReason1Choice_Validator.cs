// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="MandateSuspensionReason1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _gW_7w4PDEeahmOIR_zFG6A
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the reason for the suspension request of a mandate.
/// <list type="table">
///   <item><term><see cref="MandateSuspensionReason1Choice.Code"/></term><description>Value: ExternalMandateSuspensionReason1Code (closed enum, fully enforced, no further rule needed)</description></item>
///   <item><term><see cref="MandateSuspensionReason1Choice.Proprietary"/></term><description>Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct/enum level already — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class MandateSuspensionReason1Choice_Validator : AbstractValidator<MandateSuspensionReason1Choice_> { }
