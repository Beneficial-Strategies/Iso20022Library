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
/// Transaction Report information for one transaction.
/// </summary>
[IsoId("_z7EngU0yEeybj420QgWBkA")]
[DisplayName("Point Of Interaction Transaction Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionTransactionReport4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteractionTransactionReport4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteractionTransactionReport4( ResponseType11 reqResponse )
    {
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Response for this specific transaction.
    /// </summary>
    [IsoId("_0BjC8U0yEeybj420QgWBkA")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType11 Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType11 Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType11 Response { get; init; } 
    #else
    public ResponseType11 Response { get; set; } 
    #endif
    
    /// <summary>
    /// Data responded to a Payment request.
    /// </summary>
    [IsoId("_0BjC800yEeybj420QgWBkA")]
    [DisplayName("Payment Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRspn")]
    #endif
    [IsoXmlTag("PmtRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentResponse4? PaymentResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentResponse4? PaymentResponse { get; init; } 
    #else
    public PaymentResponse4? PaymentResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
