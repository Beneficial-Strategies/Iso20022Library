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
/// This record is an implementation of the cain.013.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcquirerRejection message is sent by any party, to reject an Acquirer to Issuer message.
/// </summary>
[Description(@"The AcquirerRejection message is sent by any party, to reject an Acquirer to Issuer message.")]
[IsoId("_ohEDEHvSEeS2PZh7wUMQog")]
[DisplayName("Acquirer Rejection")]
public partial record AcquirerRejection : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.013.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcqrrRjctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.013.001.01";
    
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
    [IsoId("_DiKccHvUEeS7Wv4oKCO8_A")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header19 Header { get; init; } 
    
    /// <summary>
    /// Information related to the reject.
    /// </summary>
    [IsoId("_e8V5oHvUEeS7Wv4oKCO8_A")]
    [DisplayName("Reject")]
    [IsoXmlTag("Rjct")]
    public required AcceptorRejection4 Reject { get; init; } 
    
    
    #nullable disable
    
}


// Since AcquirerRejectionDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcquirerRejection.

