// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the mis-matched situation between two baselines or between a baseline and a data set.
/// </summary>
[IsoId("_RaowANp-Ed-ak6NoX_4Aeg_-1146148189")]
[DisplayName("Mis Match Report")]
public record MisMatchReport3
{
    /// <summary>
    /// Total number of mismatches between two baselines or between one baseline and one data set.
    /// </summary>
    [IsoId("_RaowAdp-Ed-ak6NoX_4Aeg_-1146148150")]
    [DisplayName("Number Of Mis Matches")]
    [IsoXmlTag("NbOfMisMtchs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfMisMatches { get; init; }

    /// <summary>
    /// Details of each mismatch occurrence.
    /// </summary>
    [IsoId("_RaowAtp-Ed-ak6NoX_4Aeg_-1146147848")]
    [DisplayName("Mis Match Information")]
    [IsoXmlTag("MisMtchInf")]
    public ValidationResult5? MisMatchInformation { get; init; }
}
