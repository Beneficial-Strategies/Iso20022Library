// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CaseStatus2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _T-GLS9p-Ed-ak6NoX_4Aeg_-1949574113
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the status of an investigation case.
/// <list type="table">
///   <item><term>DateTime</term><description>ISODateTime — required (1..1)</description></item>
///   <item><term>CaseStatus</term><description>CaseStatus2Code — required (1..1)</description></item>
///   <item><term>Reason</term><description>Max140Text — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. Every field is already fully
/// enforced at the struct/enum level (<c>CaseStatus</c> is a closed C# enum, <c>Reason</c> is a
/// length-constrained string, <c>DateTime</c> is a self-validating type) — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class CaseStatus2Validator : AbstractValidator<CaseStatus2> { }
