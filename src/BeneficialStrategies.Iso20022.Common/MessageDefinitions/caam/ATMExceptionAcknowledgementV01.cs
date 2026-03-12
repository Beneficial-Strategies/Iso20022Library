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



namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// This record is an implementation of the caam.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMExceptionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMExceptionAdvice message.
/// </summary>
[Description(@"The ATMExceptionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMExceptionAdvice message.")]
[IsoId("_YFLI0K5GEeWCgYcWSNgX5g")]
[DisplayName("ATM Exception Acknowledgement V")]
public partial record ATMExceptionAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.012.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMXcptnAck";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.012.001.01";
    
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
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_fpPXMK5GEeWCgYcWSNgX5g")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header32 Header { get; init; } 
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_k_u6wK5GEeWCgYcWSNgX5g")]
    [DisplayName("Protected ATM Exception Acknowledgement")]
    [IsoXmlTag("PrtctdATMXcptnAck")]
    public ContentInformationType10? ProtectedATMExceptionAcknowledgement { get; init; } 
    
    /// <summary>
    /// Information related to the acknowledgement of an ATM exception.
    /// </summary>
    [IsoId("_ogUFkK5GEeWCgYcWSNgX5g")]
    [DisplayName("ATM Exception Acknowledgement")]
    [IsoXmlTag("ATMXcptnAck")]
    public ATMExceptionAcknowledgement1? ATMExceptionAcknowledgement { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_kRgtYK5HEeWCgYcWSNgX5g")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since ATMExceptionAcknowledgementV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMExceptionAcknowledgementV01.

