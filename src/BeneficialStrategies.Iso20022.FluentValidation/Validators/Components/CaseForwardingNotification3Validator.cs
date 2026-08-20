// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CaseForwardingNotification3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _T-ZtQtp-Ed-ak6NoX_4Aeg_-1114775558
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Status of a case resulting from a case assignment.
/// <list type="table">
///   <item><term>Justification</term><description>CaseForwardingNotification3Code — required (1..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. <c>Justification</c> is a closed
/// C# enum — the compiler already rejects any value outside the code set, so there is nothing
/// further to check at the FluentValidation layer, and this validator has no rules. It still
/// exists as a first-class type so the coverage-scoping policy (see the FluentValidation
/// project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than silently skipped.
/// </remarks>
public class CaseForwardingNotification3Validator : AbstractValidator<CaseForwardingNotification3> { }
