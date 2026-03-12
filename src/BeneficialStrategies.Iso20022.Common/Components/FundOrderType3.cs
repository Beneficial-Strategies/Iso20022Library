// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[IsoId("_TSu6Etp-Ed-ak6NoX_4Aeg_1141291305")]
[DisplayName("Fund Order Type")]
public partial record FundOrderType3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_TSu6E9p-Ed-ak6NoX_4Aeg_1141291307")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public required FundOrderType4Code OrderType { get; init; } 
    
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_TSu6FNp-Ed-ak6NoX_4Aeg_1141291995")]
    [DisplayName("Extended Order Type")]
    [IsoXmlTag("XtndedOrdrTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedOrderType { get; init; } 
    
    
    #nullable disable
    
}
