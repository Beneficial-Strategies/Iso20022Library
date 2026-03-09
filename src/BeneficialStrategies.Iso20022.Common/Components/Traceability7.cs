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
/// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
/// </summary>
[IsoId("_SnT1wUqOEeenp6hmNprBHg")]
[DisplayName("Traceability")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Traceability7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Traceability7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Traceability7( GenericIdentification172 reqRelayIdentification )
    {
        RelayIdentification = reqRelayIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a partner of a message exchange.
    /// </summary>
    [IsoId("_SxVUcUqOEeenp6hmNprBHg")]
    [DisplayName("Relay Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RlayId")]
    #endif
    [IsoXmlTag("RlayId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification172 RelayIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification172 RelayIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification172 RelayIdentification { get; init; } 
    #else
    public GenericIdentification172 RelayIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of incoming data exchange for relaying or processing.
    /// </summary>
    [IsoId("_SxVUc0qOEeenp6hmNprBHg")]
    [DisplayName("Trace Date Time In")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TracDtTmIn")]
    #endif
    [IsoXmlTag("TracDtTmIn")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TraceDateTimeIn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TraceDateTimeIn { get; init; } 
    #else
    public System.DateTime? TraceDateTimeIn { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the outgoing exchange for relaying or processing.
    /// </summary>
    [IsoId("_SxVUdUqOEeenp6hmNprBHg")]
    [DisplayName("Trace Date Time Out")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TracDtTmOut")]
    #endif
    [IsoXmlTag("TracDtTmOut")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TraceDateTimeOut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TraceDateTimeOut { get; init; } 
    #else
    public System.DateTime? TraceDateTimeOut { get; set; } 
    #endif
    
    
    #nullable disable
    
}
