// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the order cancel request.
/// </summary>
[IsoId("_Q_qrQ9p-Ed-ak6NoX_4Aeg_213456320")]
[DisplayName("Reference")]
public partial record Reference9
{
    #nullable enable
    
    /// <summary>
    /// Client order identification of the previous non-rejected order (not the initial order of the day) when canceling or replacing an order.
    /// </summary>
    [IsoId("_Q_qrRNp-Ed-ak6NoX_4Aeg_731552924")]
    [DisplayName("Original Client Order Identification")]
    [IsoXmlTag("OrgnlClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalClientOrderIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier of most recent order as assigned by sell-side (broker, exchange.).
    /// </summary>
    [IsoId("_Q_qrRdp-Ed-ak6NoX_4Aeg_1075102845")]
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OrderIdentification { get; init; } 
    
    /// <summary>
    /// TransactionTime of the last state change that occurred to the original order. The original order modification time is provided as an optional field in the order modification request to identify that the state of the order has not changed since the request was issued.
    /// </summary>
    [IsoId("_Q_qrRtp-Ed-ak6NoX_4Aeg_1493832227")]
    [DisplayName("Original Order Modification Time")]
    [IsoXmlTag("OrgnlOrdrModTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalOrderModificationTime { get; init; } 
    
    
    #nullable disable
    
}
