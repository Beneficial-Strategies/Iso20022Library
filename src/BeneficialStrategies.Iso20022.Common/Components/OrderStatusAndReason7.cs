// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of a bulk or multiple or switch order that was previously received.
/// </summary>
[IsoId("_RMBsRNp-Ed-ak6NoX_4Aeg_-571096042")]
[DisplayName("Order Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrderStatusAndReason7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OrderStatusAndReason7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OrderStatusAndReason7( OrderStatus4Code reqStatus,CancelledStatus2 reqCancelled,ConditionallyAcceptedStatus2 reqConditionallyAccepted,SuspendedStatus2 reqSuspended,PartiallySettledStatus1 reqPartiallySettled )
    {
        Status = reqStatus;
        Cancelled = reqCancelled;
        ConditionallyAccepted = reqConditionallyAccepted;
        Suspended = reqSuspended;
        PartiallySettled = reqPartiallySettled;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_RMBsRdp-Ed-ak6NoX_4Aeg_1226343818")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Status of all the orders in the order message. There is no reason attached.
    /// </summary>
    [IsoId("_RMBsRtp-Ed-ak6NoX_4Aeg_-570172884")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderStatus4Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderStatus4Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderStatus4Code Status { get; init; } 
    #else
    public OrderStatus4Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Status of all the orders in the order message is cancelled. This status is used for orders that have been accepted or that have been entered in an order book but that can not be executed.
    /// </summary>
    [IsoId("_RMBsR9p-Ed-ak6NoX_4Aeg_-568323684")]
    [DisplayName("Cancelled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Canc")]
    #endif
    [IsoXmlTag("Canc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelledStatus2 Cancelled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancelledStatus2 Cancelled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancelledStatus2 Cancelled { get; init; } 
    #else
    public CancelledStatus2 Cancelled { get; set; } 
    #endif
    
    /// <summary>
    /// Status of all the orders in the order message is conditionally accepted.
    /// </summary>
    [IsoId("_RMBsSNp-Ed-ak6NoX_4Aeg_-568326132")]
    [DisplayName("Conditionally Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondlyAccptd")]
    #endif
    [IsoXmlTag("CondlyAccptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConditionallyAcceptedStatus2 ConditionallyAccepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConditionallyAcceptedStatus2 ConditionallyAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConditionallyAcceptedStatus2 ConditionallyAccepted { get; init; } 
    #else
    public ConditionallyAcceptedStatus2 ConditionallyAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Status of all the orders in the order message is rejected. This status is used for orders that have not been accepted or entered in an order book.
    /// </summary>
    [IsoId("_RMBsSdp-Ed-ak6NoX_4Aeg_-569247483")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<RejectedStatus6> Rejected { get; init; } = new ValueList<RejectedStatus6>(){};
    
    /// <summary>
    /// Status of all the orders in the order message is suspended.
    /// </summary>
    [IsoId("_RMLdQNp-Ed-ak6NoX_4Aeg_-559090757")]
    [DisplayName("Suspended")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sspd")]
    #endif
    [IsoXmlTag("Sspd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SuspendedStatus2 Suspended { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SuspendedStatus2 Suspended { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SuspendedStatus2 Suspended { get; init; } 
    #else
    public SuspendedStatus2 Suspended { get; set; } 
    #endif
    
    /// <summary>
    /// Status of all the orders in the order message is partially settled.
    /// </summary>
    [IsoId("_RMLdQdp-Ed-ak6NoX_4Aeg_782962567")]
    [DisplayName("Partially Settled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlySttld")]
    #endif
    [IsoXmlTag("PrtlySttld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartiallySettledStatus1 PartiallySettled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartiallySettledStatus1 PartiallySettled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartiallySettledStatus1 PartiallySettled { get; init; } 
    #else
    public PartiallySettledStatus1 PartiallySettled { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("_RMLdQtp-Ed-ak6NoX_4Aeg_-567402082")]
    [DisplayName("Status Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInitr")]
    #endif
    [IsoXmlTag("StsInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    #else
    public PartyIdentification2Choice_? StatusInitiator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
