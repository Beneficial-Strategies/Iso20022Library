// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the order modification request.
/// </summary>
[IsoId("_Q_qrR9p-Ed-ak6NoX_4Aeg_-1068514335")]
[DisplayName("Reference")]
public partial record Reference10
{
    #nullable enable
    
    /// <summary>
    /// Client order identification of the previous non-rejected order (not the initial order of the day) when cancelling or replacing an order.
    /// </summary>
    [IsoId("_Q_qrSNp-Ed-ak6NoX_4Aeg_-823782756")]
    [DisplayName("Original Client Order Identification")]
    [IsoXmlTag("OrgnlClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalClientOrderIdentification { get; init; } 
    
    /// <summary>
    /// TransactionTime of the last state change that occurred to the original order. The original order modification time is provided as an optional field in the order modification request to identify that the state of the order has not changed since the request was issued.
    /// </summary>
    [IsoId("_Q_z1MNp-Ed-ak6NoX_4Aeg_-324158223")]
    [DisplayName("Original Order Modification Time")]
    [IsoXmlTag("OrgnlOrdrModTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalOrderModificationTime { get; init; } 
    
    
    #nullable disable
    
}
