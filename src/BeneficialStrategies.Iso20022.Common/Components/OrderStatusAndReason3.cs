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
[IsoId("_Uvkrg9p-Ed-ak6NoX_4Aeg_-1625631905")]
[DisplayName("Order Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrderStatusAndReason3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OrderStatusAndReason3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OrderStatusAndReason3( OrderStatus2Code reqStatus,CancelledStatus1 reqCancelled,ConditionallyAcceptedStatus1 reqConditionallyAccepted,RejectedStatus3 reqRejected,SuspendedStatus1 reqSuspended )
    {
        Status = reqStatus;
        Cancelled = reqCancelled;
        ConditionallyAccepted = reqConditionallyAccepted;
        Rejected = reqRejected;
        Suspended = reqSuspended;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of the order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    [IsoId("_UvkrhNp-Ed-ak6NoX_4Aeg_-1625631879")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderStatus2Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderStatus2Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderStatus2Code Status { get; init; } 
    #else
    public OrderStatus2Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the order details is cancelled. This status is used for orders that have been accepted or that have been entered in an order book but that can not be executed.
    /// </summary>
    [IsoId("_Uvkrhdp-Ed-ak6NoX_4Aeg_-1625631489")]
    [DisplayName("Cancelled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Canc")]
    #endif
    [IsoXmlTag("Canc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelledStatus1 Cancelled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancelledStatus1 Cancelled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancelledStatus1 Cancelled { get; init; } 
    #else
    public CancelledStatus1 Cancelled { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the order details is conditionally accepted.
    /// </summary>
    [IsoId("_Uvkrhtp-Ed-ak6NoX_4Aeg_-1625631429")]
    [DisplayName("Conditionally Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondlyAccptd")]
    #endif
    [IsoXmlTag("CondlyAccptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConditionallyAcceptedStatus1 ConditionallyAccepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConditionallyAcceptedStatus1 ConditionallyAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConditionallyAcceptedStatus1 ConditionallyAccepted { get; init; } 
    #else
    public ConditionallyAcceptedStatus1 ConditionallyAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the order details is rejected. This status is used for orders that have not been accepted or entered in an order book.
    /// </summary>
    [IsoId("_Uvkrh9p-Ed-ak6NoX_4Aeg_-1626490033")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedStatus3 Rejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectedStatus3 Rejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedStatus3 Rejected { get; init; } 
    #else
    public RejectedStatus3 Rejected { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the order details is suspended.
    /// </summary>
    [IsoId("_UvkriNp-Ed-ak6NoX_4Aeg_-1564859742")]
    [DisplayName("Suspended")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sspd")]
    #endif
    [IsoXmlTag("Sspd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SuspendedStatus1 Suspended { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SuspendedStatus1 Suspended { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SuspendedStatus1 Suspended { get; init; } 
    #else
    public SuspendedStatus1 Suspended { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("_Uvkridp-Ed-ak6NoX_4Aeg_-899308644")]
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
    
    /// <summary>
    /// Unique and unambiguous technical identification of an instance of a leg within a switch.
    /// </summary>
    [IsoId("_Uvt1cNp-Ed-ak6NoX_4Aeg_-1625631819")]
    [DisplayName("Switch Order Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwtchOrdrLegId")]
    #endif
    [IsoXmlTag("SwtchOrdrLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SwitchOrderLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SwitchOrderLegIdentification { get; init; } 
    #else
    public System.String? SwitchOrderLegIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
