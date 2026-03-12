// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of a bulk or multiple or switch order cancellation instruction that was previously received.
/// </summary>
[IsoId("_Uvt1dNp-Ed-ak6NoX_4Aeg_816044413")]
[DisplayName("Order Status And Reason")]
public partial record OrderStatusAndReason4
{
    #nullable enable
    
    /// <summary>
    /// Status of the order.
    /// </summary>
    [IsoId("_Uvt1ddp-Ed-ak6NoX_4Aeg_816044680")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required OrderStatus3Code Status { get; init; } 
    
    /// <summary>
    /// Status of the order is rejected.
    /// </summary>
    [IsoId("_Uvt1dtp-Ed-ak6NoX_4Aeg_816044757")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public required RejectedStatus4 Rejected { get; init; } 
    
    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("_Uvt1d9p-Ed-ak6NoX_4Aeg_-1485745021")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    
    
    #nullable disable
    
}
