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



namespace BeneficialStrategies.Iso20022.caad;

/// <summary>
/// This record is an implementation of the caad.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AdministrativeResponse message is usually sent by any party (processor, clearing or settlement agent) to any party in response to a AdministrativeInitiation Message.
/// </summary>
[Description(@"The AdministrativeResponse message is usually sent by any party (processor, clearing or settlement agent) to any party in response to a AdministrativeInitiation Message.")]
[IsoId("_4xvBUDNQEeylu6lH-gut-A")]
[DisplayName("Administrative Response V")]
public partial record AdministrativeResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caad.009.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AdmstvRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.009.001.01";
    
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
    [IsoId("_ijx78TNREeylu6lH-gut-A")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header66 Header { get; init; } 
    
    /// <summary>
    /// Information related to the Administrative Response.
    /// </summary>
    [IsoId("_KMg-cDZ4EeysP8L3U1Ot-g")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required AdministrativeResponse1 Body { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_jWqxcTNREeylu6lH-gut-A")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since AdministrativeResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AdministrativeResponseV01.

