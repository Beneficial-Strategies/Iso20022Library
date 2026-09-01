// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalMessageInformation1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _PgJZVdp-Ed-ak6NoX_4Aeg_1129957204
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Unique identification, as assigned by the original instructing party, to unambiguously
/// identify the message.
/// <list type="table">
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>MessageNameIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
/// </remarks>
public class OriginalMessageInformation1Validator : AbstractValidator<OriginalMessageInformation1>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="OriginalMessageInformation1"/>.
    /// </summary>
    public OriginalMessageInformation1Validator()
    {
        // MessageIdentification, MessageNameIdentification: Max35Text, required (1..1) and
        // already `required` C# properties — length [1..35] enforced by struct constructor.
        // CreationDateTime: ISODateTime, optional — no additional constraint beyond the type itself.
    }
}
