// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="SupplementaryData1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Qn0zC9p-Ed-ak6NoX_4Aeg_468227563
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Additional information that can not be captured in the structured fields and/or any other
/// specific block.
/// <list type="table">
///   <item><term>PlaceAndName</term><description>Max350Text — optional (0..1)</description></item>
///   <item><term>Envelope</term><description>SupplementaryDataEnvelope1 — required (1..1)</description></item>
/// </list>
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>SupplementaryDataRule</term>
///     <description>
///       This component may not be used without the explicit approval of a SEG and submission to
///       the RA of ISO 20022 compliant structure(s) to be used in the Envelope element. Not
///       independently enforceable by this library — no structural signal distinguishes an
///       approved submission from an unapproved one at the C# model level.
///     </description>
///   </item>
/// </list>
///
/// <see cref="BeneficialStrategies.Iso20022.ExternalSchema.SupplementaryDataEnvelope1"/> is an empty stub record (no properties) — it exists in
/// the C# model only as a placeholder for the ISO-compliant structure the Envelope element
/// ultimately carries, per the SupplementaryDataRule above. There is nothing to validate on it
/// today; <c>required</c> already enforces its presence.
/// </remarks>
public class SupplementaryData1Validator : AbstractValidator<SupplementaryData1>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="SupplementaryData1"/>.
    /// </summary>
    public SupplementaryData1Validator()
    {
        // PlaceAndName: Max350Text, optional — length [1..350] enforced by struct constructor.
        // Envelope: SupplementaryDataEnvelope1, required (1..1) and already `required` C#
        // property; the type itself is an empty stub with nothing further to validate.
    }
}
