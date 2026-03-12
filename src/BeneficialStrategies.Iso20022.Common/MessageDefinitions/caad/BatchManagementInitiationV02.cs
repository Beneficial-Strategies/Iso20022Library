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
/// This record is an implementation of the caad.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The BatchManagementInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer) connected to a network.
/// 
/// This message provides flow control information enabling a series of messages in batches and batches in collections to start, end or require checkpoints during the flow.
/// </summary>
[Description(@"The BatchManagementInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer) connected to a network.||This message provides flow control information enabling a series of messages in batches and batches in collections to start, end or require checkpoints during the flow.")]
[IsoId("_31KMYYdOEeuBS50MFjViNw")]
[DisplayName("Batch Management Initiation V")]
public partial record BatchManagementInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caad.001.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BtchMgmtInitn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.001.001.02";
    
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
    [IsoId("_31KMY4dOEeuBS50MFjViNw")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header69 Header { get; init; } 
    
    /// <summary>
    /// Information related to the batch management.
    /// </summary>
    [IsoId("_31KMZYdOEeuBS50MFjViNw")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required BatchManagementInitiation2 Body { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_31KMZ4dOEeuBS50MFjViNw")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since BatchManagementInitiationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BatchManagementInitiationV02.

