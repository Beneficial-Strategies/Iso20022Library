// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to identify funds order(s).
/// </summary>
[IsoId("_RMVOSdp-Ed-ak6NoX_4Aeg_-22206736")]
[DisplayName("Message And Business Reference")]
public partial record MessageAndBusinessReference4
{
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_RMVOStp-Ed-ak6NoX_4Aeg_-22206345")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    public AdditionalReference3? OtherReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_RMVOS9p-Ed-ak6NoX_4Aeg_-22206716")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_RMVOTNp-Ed-ak6NoX_4Aeg_-14820633")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifiers of one or more indiviudal order instructions or individual order cancellation requests.
    /// </summary>
    [IsoId("_RMVOTdp-Ed-ak6NoX_4Aeg_-14820658")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public InvestmentFundOrder2? OrderReference { get; init; } 
    
    
    #nullable disable
    
}
