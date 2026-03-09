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
/// Identification of partners involved in exchange from the ATM to the issuer, with the relative timestamp of their exchanges.
/// </summary>
[IsoId("_iwOuUYnzEeS9F4Qrq_eaVA")]
[DisplayName("Traceability")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Traceability4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Traceability4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Traceability4( GenericIdentification77 reqRelayIdentification,System.DateTime reqTraceDateTimeIn,System.DateTime reqTraceDateTimeOut )
    {
        RelayIdentification = reqRelayIdentification;
        TraceDateTimeIn = reqTraceDateTimeIn;
        TraceDateTimeOut = reqTraceDateTimeOut;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a partner of a message exchange.
    /// </summary>
    [IsoId("_i854YYnzEeS9F4Qrq_eaVA")]
    [DisplayName("Relay Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RlayId")]
    #endif
    [IsoXmlTag("RlayId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification77 RelayIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification77 RelayIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification77 RelayIdentification { get; init; } 
    #else
    public GenericIdentification77 RelayIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the relay node in the path, to enable identification of several hosts in parallel.
    /// </summary>
    [IsoId("_rXzs8Cq5EeWRf8RNsvC5fQ")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SequenceNumber { get; init; } 
    #else
    public System.String? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of incoming data exchange for relaying or processing.
    /// </summary>
    [IsoId("_i854Y4nzEeS9F4Qrq_eaVA")]
    [DisplayName("Trace Date Time In")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TracDtTmIn")]
    #endif
    [IsoXmlTag("TracDtTmIn")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TraceDateTimeIn { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TraceDateTimeIn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TraceDateTimeIn { get; init; } 
    #else
    public System.DateTime TraceDateTimeIn { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the outgoing exchange for relaying or processing.
    /// </summary>
    [IsoId("_i854ZYnzEeS9F4Qrq_eaVA")]
    [DisplayName("Trace Date Time Out")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TracDtTmOut")]
    #endif
    [IsoXmlTag("TracDtTmOut")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TraceDateTimeOut { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TraceDateTimeOut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TraceDateTimeOut { get; init; } 
    #else
    public System.DateTime TraceDateTimeOut { get; set; } 
    #endif
    
    
    #nullable disable
    
}
