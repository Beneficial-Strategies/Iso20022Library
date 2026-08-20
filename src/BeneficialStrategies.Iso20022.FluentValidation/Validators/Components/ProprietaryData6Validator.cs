// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ProprietaryData6"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1gW-cYKYEee7hrXqLO3yQg
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Container for proprietary information. Business content of this element is not specified.
/// <list type="table">
///   <item><term>Any</term><description>SkipPayload — required (1..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. <c>Any</c>'s type
/// (<see cref="ExternalSchema.SkipPayload"/>) deliberately carries no properties at all — the ISO
/// spec's <c>processContents="skip"</c> means the business content is explicitly unspecified and
/// not subject to further validation, matching the type's own doc comment. There is nothing to
/// check at the FluentValidation layer beyond the C# compiler's own <c>required</c> enforcement,
/// so this validator has no rules. It still exists as a first-class type so the coverage-scoping
/// policy (see the FluentValidation project's own <c>CLAUDE.md</c>) can record this type as
/// reviewed rather than silently skipped.
/// </remarks>
public class ProprietaryData6Validator : AbstractValidator<ProprietaryData6> { }
