// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of a bulk or multiple or switch order that was previously received.
/// </summary>
[IsoId("_RMBsRNp-Ed-ak6NoX_4Aeg_-571096042")]
[DisplayName("Order Status And Reason")]
public partial record OrderStatusAndReason7
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_RMBsRdp-Ed-ak6NoX_4Aeg_1226343818")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Status of all the orders in the order message. There is no reason attached.
    /// </summary>
    [IsoId("_RMBsRtp-Ed-ak6NoX_4Aeg_-570172884")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required OrderStatus4Code Status { get; init; } 
    
    /// <summary>
    /// Status of all the orders in the order message is cancelled. This status is used for orders that have been accepted or that have been entered in an order book but that can not be executed.
    /// </summary>
    [IsoId("_RMBsR9p-Ed-ak6NoX_4Aeg_-568323684")]
    [DisplayName("Cancelled")]
    [IsoXmlTag("Canc")]
    public required CancelledStatus2 Cancelled { get; init; } 
    
    /// <summary>
    /// Status of all the orders in the order message is conditionally accepted.
    /// </summary>
    [IsoId("_RMBsSNp-Ed-ak6NoX_4Aeg_-568326132")]
    [DisplayName("Conditionally Accepted")]
    [IsoXmlTag("CondlyAccptd")]
    public required ConditionallyAcceptedStatus2 ConditionallyAccepted { get; init; } 
    
    /// <summary>
    /// Status of all the orders in the order message is rejected. This status is used for orders that have not been accepted or entered in an order book.
    /// </summary>
    [IsoId("_RMBsSdp-Ed-ak6NoX_4Aeg_-569247483")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<RejectedStatus6> Rejected { get; init; } = [];
    
    /// <summary>
    /// Status of all the orders in the order message is suspended.
    /// </summary>
    [IsoId("_RMLdQNp-Ed-ak6NoX_4Aeg_-559090757")]
    [DisplayName("Suspended")]
    [IsoXmlTag("Sspd")]
    public required SuspendedStatus2 Suspended { get; init; } 
    
    /// <summary>
    /// Status of all the orders in the order message is partially settled.
    /// </summary>
    [IsoId("_RMLdQdp-Ed-ak6NoX_4Aeg_782962567")]
    [DisplayName("Partially Settled")]
    [IsoXmlTag("PrtlySttld")]
    public required PartiallySettledStatus1 PartiallySettled { get; init; } 
    
    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("_RMLdQtp-Ed-ak6NoX_4Aeg_-567402082")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    
    
    #nullable disable
    
}
