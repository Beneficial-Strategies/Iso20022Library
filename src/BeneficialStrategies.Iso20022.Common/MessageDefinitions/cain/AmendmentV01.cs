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
/// This record is an implementation of the cain.020.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Amendment message can be initiated by any party and received by any party (acquirer, agent or issuer). 
/// 
/// This message is used to inform the originator that the original message has been corrected/amended and then forwarded to the destination on behalf of the originator. It contains a copy of the original message and any errors found. It may also contain any corrections and/or amendments that were made to the original message.
/// 
/// </summary>
[Description(@"The Amendment message can be initiated by any party and received by any party (acquirer, agent or issuer). ||This message is used to inform the originator that the original message has been corrected/amended and then forwarded to the destination on behalf of the originator. It contains a copy of the original message and any errors found. It may also contain any corrections and/or amendments that were made to the original message.|")]
[IsoId("_V-l6VVW1EeeiG_nL4vgKnQ")]
[DisplayName("Amendment V")]
public partial record AmendmentV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.020.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "Amdmnt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.020.001.01";
    
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
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_V-l6WVW1EeeiG_nL4vgKnQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header46 Header { get; init; } 
    
    /// <summary>
    /// Information related to the Amendment message.
    /// </summary>
    [IsoId("_m_ub4FW8EeeiG_nL4vgKnQ")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required Amendment10 Body { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_V-l6V1W1EeeiG_nL4vgKnQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since AmendmentV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AmendmentV01.

