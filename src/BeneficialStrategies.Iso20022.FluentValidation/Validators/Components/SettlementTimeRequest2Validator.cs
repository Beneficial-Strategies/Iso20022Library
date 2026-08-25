// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="SettlementTimeRequest2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _QIrY6dp-Ed-ak6NoX_4Aeg_2050617089
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Provides information on the requested settlement time(s) of the payment instruction.
/// <list type="table">
///   <item><term>CLSTime</term><description>ISOTime — optional (0..1)</description></item>
///   <item><term>TillTime</term><description>ISOTime — optional (0..1)</description></item>
///   <item><term>FromTime</term><description>ISOTime — optional (0..1)</description></item>
///   <item><term>RejectTime</term><description>ISOTime — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry — no ordering rule between FromTime/TillTime/RejectTime/CLSTime is
/// specified). All four fields are already fully enforced at the <see cref="ISOTime"/> struct
/// level (lexical form parsing) — nothing left for FluentValidation to add. Empty shell exists as
/// a first-class type per the coverage-scoping policy ("reviewed and confirmed to need nothing"),
/// same convention as <c>AddressType3Choice_Validator</c>.
/// </remarks>
public class SettlementTimeRequest2Validator : AbstractValidator<SettlementTimeRequest2> { }
