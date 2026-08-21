// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="InformationQualifierType1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _59y2N5lZEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Further qualifies the information provided in terms of its importance and its format.
/// <list type="table">
///   <item><term>IsFormatted</term><description>YesNoIndicator — optional (0..1)</description></item>
///   <item><term>Priority</term><description>Priority1Code — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. Both fields are already fully
/// enforced at the struct/enum level — there is no additional cross-field or business rule to add
/// at the FluentValidation layer, so this validator has no rules. It still exists as a
/// first-class type so the coverage-scoping policy (see the FluentValidation project's own
/// <c>CLAUDE.md</c>) can record this type as reviewed rather than silently skipped.
/// </remarks>
public class InformationQualifierType1Validator : AbstractValidator<InformationQualifierType1> { }
