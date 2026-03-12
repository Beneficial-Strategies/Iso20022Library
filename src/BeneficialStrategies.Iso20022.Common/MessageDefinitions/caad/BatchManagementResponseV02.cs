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
/// This record is an implementation of the caad.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The BatchManagementResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a BatchManagementInitiation message.
/// </summary>
[Description(@"The BatchManagementResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a BatchManagementInitiation message.")]
[IsoId("_6VroYYdOEeuBS50MFjViNw")]
[DisplayName("Batch Management Response V")]
public partial record BatchManagementResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caad.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BtchMgmtRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.002.001.02";
    
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
    [IsoId("_6VroY4dOEeuBS50MFjViNw")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header69 Header { get; init; } 
    
    /// <summary>
    /// Information related to the batch management.
    /// </summary>
    [IsoId("_6VroZYdOEeuBS50MFjViNw")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required BatchManagementResponse2 Body { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_6VroZ4dOEeuBS50MFjViNw")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since BatchManagementResponseV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BatchManagementResponseV02.

