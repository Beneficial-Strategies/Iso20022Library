// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="RemittanceInformation2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _QFsWVdp-Ed-ak6NoX_4Aeg_-1040515995
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Information supplied to enable the matching of an entry with the items that the transfer is
/// intended to settle.
/// <list type="table">
///   <item><term>Unstructured</term><description>Max140Text collection — optional, no minimum (0..&#8734;); each item's length enforced by struct constructor — no rule needed</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry). The only field is already fully enforced at the struct level —
/// nothing left for FluentValidation to add. Empty shell exists as a first-class type per the
/// coverage-scoping policy ("reviewed and confirmed to need nothing"), same convention as
/// <c>AddressType3Choice_Validator</c>.
/// </remarks>
public class RemittanceInformation2Validator : AbstractValidator<RemittanceInformation2> { }
