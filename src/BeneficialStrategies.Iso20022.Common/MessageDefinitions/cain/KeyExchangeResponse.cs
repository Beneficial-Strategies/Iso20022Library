// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The KeyExchangeResponse message is sent by an acquirer, an issuer or an agent to answer to a KeyExchangeInitiation message and complete a cryptographic key exchange.
/// </summary>
[Description(@"The KeyExchangeResponse message is sent by an acquirer, an issuer or an agent to answer to a KeyExchangeInitiation message and complete a cryptographic key exchange.")]
[IsoId("_UPyNIHvQEeS2PZh7wUMQog")]
[DisplayName("Key Exchange Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record KeyExchangeResponse : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.012.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "KeyXchgRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.012.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a KeyExchangeResponse instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public KeyExchangeResponse( Header17 reqHeader,AcquirerKeyExchangeResponse1 reqKeyExchangeResponseValue,ContentInformationType12 reqSecurityTrailer )
    {
        Header = reqHeader;
        KeyExchangeResponseValue = reqKeyExchangeResponseValue;
        SecurityTrailer = reqSecurityTrailer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_djiQcHvQEeS2PZh7wUMQog")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header17 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header17 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header17 Header { get; init; } 
    #else
    public Header17 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the response to a key exchange.
    /// </summary>
    [IsoId("_MSqJEHvREeS2PZh7wUMQog")]
    [DisplayName("Key Exchange Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyXchgRspn")]
    #endif
    [IsoXmlTag("KeyXchgRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcquirerKeyExchangeResponse1 KeyExchangeResponseValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcquirerKeyExchangeResponse1 KeyExchangeResponseValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerKeyExchangeResponse1 KeyExchangeResponseValue { get; init; } 
    #else
    public AcquirerKeyExchangeResponse1 KeyExchangeResponseValue { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_GvIZoHvSEeS2PZh7wUMQog")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentInformationType12 SecurityTrailer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentInformationType12 SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType12 SecurityTrailer { get; init; } 
    #else
    public ContentInformationType12 SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since KeyExchangeResponseDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to KeyExchangeResponse.

