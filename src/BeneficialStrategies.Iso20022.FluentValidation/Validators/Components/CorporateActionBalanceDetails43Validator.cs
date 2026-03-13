// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CorporateActionBalanceDetails43"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Tj5YGRuyEeyhRdHRjakS2w
/// Spec source: queried via ISO 20022 MCP server (2026-03-13).
/// All balance fields are optional (0..1 or 0..∞) choice types carrying quantity information.
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>AffectedAndUnaffectedBalanceRule</term>
///     <description>
///       UnaffectedBalance and AffectedBalance should only be mentioned as a result of the
///       process that was run through the event — for instance lottery results, Dutch auction
///       results, or tender offer results. This is a business-context constraint; enforcement
///       is the responsibility of the application layer.
///     </description>
///   </item>
/// </list>
/// </remarks>
public sealed class CorporateActionBalanceDetails43Validator
    : AbstractValidator<CorporateActionBalanceDetails43>
{
    public CorporateActionBalanceDetails43Validator()
    {
        // AffectedAndUnaffectedBalanceRule: business-context only — cannot be enforced
        // structurally. See XML doc on this class for the full constraint text.
    }
}
