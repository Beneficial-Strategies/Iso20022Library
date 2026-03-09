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
/// Status report of a bulk or multiple or switch order cancellation instruction that was previously received.
/// </summary>
[IsoId("_Uvt1dNp-Ed-ak6NoX_4Aeg_816044413")]
[DisplayName("Order Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrderStatusAndReason4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OrderStatusAndReason4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OrderStatusAndReason4( OrderStatus3Code reqStatus,RejectedStatus4 reqRejected )
    {
        Status = reqStatus;
        Rejected = reqRejected;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of the order.
    /// </summary>
    [IsoId("_Uvt1ddp-Ed-ak6NoX_4Aeg_816044680")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderStatus3Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderStatus3Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderStatus3Code Status { get; init; } 
    #else
    public OrderStatus3Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the order is rejected.
    /// </summary>
    [IsoId("_Uvt1dtp-Ed-ak6NoX_4Aeg_816044757")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedStatus4 Rejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectedStatus4 Rejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedStatus4 Rejected { get; init; } 
    #else
    public RejectedStatus4 Rejected { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("_Uvt1d9p-Ed-ak6NoX_4Aeg_-1485745021")]
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
