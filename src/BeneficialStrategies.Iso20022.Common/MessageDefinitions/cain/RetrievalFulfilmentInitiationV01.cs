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
/// This record is an implementation of the cain.014.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RetrievaFulfilmentInitiation message is sent by an acquirer or agent to an issuer to support an issuer&apos;s retrieval request.
/// 
/// The RetrievaFulfilmentInitiation message is the activity initiated by the acceptor, the acquirer or the relevant agent to support the issuer who has determined that a transaction information document needs to be examined before a potential chargeback is sent or to satisfy another need of the issuer or the cardholder. Only an issuer or its agent can initiate a retrieval request.
/// </summary>
[Description(@"The RetrievaFulfilmentInitiation message is sent by an acquirer or agent to an issuer to support an issuer's retrieval request.||The RetrievaFulfilmentInitiation message is the activity initiated by the acceptor, the acquirer or the relevant agent to support the issuer who has determined that a transaction information document needs to be examined before a potential chargeback is sent or to satisfy another need of the issuer or the cardholder. Only an issuer or its agent can initiate a retrieval request.")]
[IsoId("_I-6FQeE1EeeV6-yubHrZaQ")]
[DisplayName("Retrieval Fulfilment Initiation V")]
public partial record RetrievalFulfilmentInitiationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.014.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrvlFlfmtInitn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.014.001.01";
    
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
    [IsoId("_I-6FQ-E1EeeV6-yubHrZaQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header48 Header { get; init; } 
    
    /// <summary>
    /// Information related to the initiation of a retrieval fulfilment
    /// </summary>
    [IsoId("_I-6FReE1EeeV6-yubHrZaQ")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required RetrievalFulfilmentInitiation1 Body { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_I-6FR-E1EeeV6-yubHrZaQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since RetrievalFulfilmentInitiationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RetrievalFulfilmentInitiationV01.

