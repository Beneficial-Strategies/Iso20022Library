// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the mis-matched situation between two baselines or between a baseline and a data set.
/// </summary>
[IsoId("_UsvZ9tp-Ed-ak6NoX_4Aeg_1894133920")]
[DisplayName("Mis Match Report")]
public partial record MisMatchReport2
{
    #nullable enable
    
    /// <summary>
    /// Total number of mismatches between two baselines or between one baseline and one data set.
    /// </summary>
    [IsoId("_UsvZ99p-Ed-ak6NoX_4Aeg_1894133939")]
    [DisplayName("Number Of Mis Matches")]
    [IsoXmlTag("NbOfMisMtchs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfMisMatches { get; init; } 
    
    /// <summary>
    /// Details of each mismatch occurrence.
    /// </summary>
    [IsoId("_Us5K8Np-Ed-ak6NoX_4Aeg_1894133964")]
    [DisplayName("Mis Match Information")]
    [IsoXmlTag("MisMtchInf")]
    public ValidationResult4? MisMatchInformation { get; init; } 
    
    
    #nullable disable
    
}
