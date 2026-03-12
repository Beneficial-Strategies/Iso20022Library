// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides original client order identification and order modification time.
/// </summary>
[IsoId("_Q8rosdp-Ed-ak6NoX_4Aeg_-706864990")]
[DisplayName("Cross Order Cancel")]
public partial record CrossOrderCancel1
{
    #nullable enable
    
    /// <summary>
    /// Client Order identification of the previous order (NOT the initial order of the day) as assigned by the institution, used to identify the previous order in cancel requests.
    /// </summary>
    [IsoId("_Q8rostp-Ed-ak6NoX_4Aeg_-602509461")]
    [DisplayName("Original Client Order Identification")]
    [IsoXmlTag("OrgnlClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalClientOrderIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the most recent (or current) CreationDateTime reported for the order. The original order modification time is provided as an optional field on Order Cancel Request to identify that the state of the order has not changed since the request was issued.
    /// </summary>
    [IsoId("_Q8ros9p-Ed-ak6NoX_4Aeg_-565566764")]
    [DisplayName("Original Order Modification Time")]
    [IsoXmlTag("OrgnlOrdrModTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalOrderModificationTime { get; init; } 
    
    
    #nullable disable
    
}
