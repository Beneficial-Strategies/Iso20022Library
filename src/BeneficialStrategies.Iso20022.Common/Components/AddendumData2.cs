// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addendum data structure is applicable to certain merchant verticals that require industry-specific data within transaction messages. 
/// </summary>
[IsoId("_AG2Jwf5pEeiLerArw36g0w")]
[DisplayName("Addendum Data")]
public partial record AddendumData2
{
    #nullable enable
    
    /// <summary>
    /// Fleet data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_AP7NXf5pEeiLerArw36g0w")]
    [DisplayName("Fleet")]
    [IsoXmlTag("Fleet")]
    public FleetData3? Fleet { get; init; } 
    
    /// <summary>
    /// Contains additional data for the addendum.
    /// </summary>
    [IsoId("_3ZTS8f75Eeic54G0fOJNMg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
