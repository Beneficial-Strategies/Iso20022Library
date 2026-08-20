// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OtherContact1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _6SokSZqlEeGSON8vddiWzQ_1969673172
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Communication device number or electronic address used for communication.
/// <list type="table">
///   <item><term>ChannelType</term><description>Max4Text — required (1..1)</description></item>
///   <item><term>Identification</term><description>Max128Text — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
/// </remarks>
public class OtherContact1Validator : AbstractValidator<OtherContact1>
{
    public OtherContact1Validator()
    {
        // ChannelType: Max4Text, required (1..1) and already `required` C# property — length
        // [1..4] enforced by struct constructor.
        // Identification: Max128Text, optional — length [1..128] enforced by struct constructor.
    }
}
