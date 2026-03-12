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



namespace BeneficialStrategies.Iso20022.cafm;

/// <summary>
/// This record is an implementation of the cafm.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// A FileActionResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a FileActionInitiation message.
/// </summary>
[Description(@"A FileActionResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a FileActionInitiation message.")]
[IsoId("_1ejJcYKwEeu4svNQ5N-l6w")]
[DisplayName("File Action Response V")]
public partial record FileActionResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cafm.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FileActnRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafm.002.001.02";
    
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
    [IsoId("_1ejJc4KwEeu4svNQ5N-l6w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header60 Header { get; init; } 
    
    /// <summary>
    /// Information related to the response to of a file action.
    /// </summary>
    [IsoId("_1ejJdYKwEeu4svNQ5N-l6w")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required FileActionResponse2 Body { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_1ejJd4KwEeu4svNQ5N-l6w")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since FileActionResponseV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FileActionResponseV02.

