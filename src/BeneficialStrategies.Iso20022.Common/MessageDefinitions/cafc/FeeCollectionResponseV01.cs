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



namespace BeneficialStrategies.Iso20022.cafc;

/// <summary>
/// This record is an implementation of the cafc.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FeeCollectionResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a FeeCollectionInitiation message.
/// </summary>
[Description(@"The FeeCollectionResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a FeeCollectionInitiation message.")]
[IsoId("_WzFGdFciEeeFltjJxERUxw")]
[DisplayName("Fee Collection Response V")]
public partial record FeeCollectionResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cafc.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FeeColltnRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafc.002.001.01";
    
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
    /// ISO 8583 MTI
    /// </summary>
    [IsoId("_WzFGd1ciEeeFltjJxERUxw")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header48 Header { get; init; } 
    
    /// <summary>
    /// Information related to the response of a fee collection initiation message..
    /// </summary>
    [IsoId("_WzFGdlciEeeFltjJxERUxw")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required FeeCollectionResponse1 Body { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_WzFGdVciEeeFltjJxERUxw")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since FeeCollectionResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FeeCollectionResponseV01.

