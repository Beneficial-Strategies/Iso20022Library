// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DebitAuthorisationConfirmation2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _T9pfVdp-Ed-ak6NoX_4Aeg_-1701633190
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies whether or not the debit authorisation is granted.
/// <list type="table">
///   <item><term>DebitAuthorisation</term><description>YesNoIndicator — required (1..1)</description></item>
///   <item><term>AmountToDebit</term><description>ActiveCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>ValueDateToDebit</term><description>ISODate — optional (0..1)</description></item>
///   <item><term>Reason</term><description>Max140Text — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. Every field is already fully
/// enforced at the struct level (<c>DebitAuthorisation</c> is a boolean-style indicator,
/// <c>Reason</c> is a length-constrained string, <c>AmountToDebit</c>/<c>ValueDateToDebit</c> are
/// their own self-validating types) — there is no additional cross-field or business rule to add
/// at the FluentValidation layer, so this validator has no rules. It still exists as a
/// first-class type so the coverage-scoping policy (see the FluentValidation project's own
/// <c>CLAUDE.md</c>) can record this type as reviewed rather than silently skipped.
/// </remarks>
public class DebitAuthorisationConfirmation2Validator : AbstractValidator<DebitAuthorisationConfirmation2> { }
