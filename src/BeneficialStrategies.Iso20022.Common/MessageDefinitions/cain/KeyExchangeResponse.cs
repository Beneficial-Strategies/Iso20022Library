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



namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The KeyExchangeResponse message is sent by an acquirer, an issuer or an agent to answer to a KeyExchangeInitiation message and complete a cryptographic key exchange.
/// </summary>
[Description(@"The KeyExchangeResponse message is sent by an acquirer, an issuer or an agent to answer to a KeyExchangeInitiation message and complete a cryptographic key exchange.")]
[IsoId("_UPyNIHvQEeS2PZh7wUMQog")]
[DisplayName("Key Exchange Response")]
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
    
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_djiQcHvQEeS2PZh7wUMQog")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header17 Header { get; init; } 
    
    /// <summary>
    /// Information related to the response to a key exchange.
    /// </summary>
    [IsoId("_MSqJEHvREeS2PZh7wUMQog")]
    [DisplayName("Key Exchange Response")]
    [IsoXmlTag("KeyXchgRspn")]
    public required AcquirerKeyExchangeResponse1 KeyExchangeResponseValue { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_GvIZoHvSEeS2PZh7wUMQog")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType12 SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since KeyExchangeResponseDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to KeyExchangeResponse.

