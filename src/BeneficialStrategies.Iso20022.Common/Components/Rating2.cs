// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rating and source of the rating of the financial instrument.
/// </summary>
[IsoId("_6xRCcL_IEeuexrfMa3dl_Q")]
[DisplayName("Rating")]
public partial record Rating2
{
    #nullable enable
    
    /// <summary>
    /// Provides the rating of the financial instrument.
    /// </summary>
    [IsoId("_Bwe3Ub_JEeuexrfMa3dl_Q")]
    [DisplayName("Rating")]
    [IsoXmlTag("Ratg")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    public required IsoMax10Text Rating { get; init; } 
    
    /// <summary>
    /// Agency, which provides rating services, for example, Moody&apos;s and S&amp;P.
    /// </summary>
    [IsoId("_D8xvwb_JEeuexrfMa3dl_Q")]
    [DisplayName("Source Of Rating")]
    [IsoXmlTag("SrcOfRatg")]
    public required MarketIdentification89 SourceOfRating { get; init; } 
    
    
    #nullable disable
    
}
