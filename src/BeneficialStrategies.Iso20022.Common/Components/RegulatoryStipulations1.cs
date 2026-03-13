// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies regulatory stipulations that financial institutions must be compliant with in the country, region, and/or area they conduct business.
/// </summary>
[IsoId("_AmX48NokEeC60axPepSq7g_4921707")]
[DisplayName("Regulatory Stipulations")]
public partial record RegulatoryStipulations1
{
    #nullable enable
    
    /// <summary>
    /// Nation with its own government, occupying a particular territory.
    /// </summary>
    [IsoId("_Amhp8NokEeC60axPepSq7g_-2124829502")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Specifies regulatory stipulations that financial institutions must be compliant with in the country, region, and/or where they conduct business.
    /// </summary>
    [IsoId("_Amhp8dokEeC60axPepSq7g_1275857359")]
    [DisplayName("Stipulations")]
    [IsoXmlTag("Stiptns")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    public SimpleValueList<System.String> Stipulations { get; init; } = [];
    // ID for the above is _Amhp8dokEeC60axPepSq7g_1275857359
    
    
    #nullable disable
    
}
