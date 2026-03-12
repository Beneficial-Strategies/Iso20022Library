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



namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// This record is an implementation of the catp.010.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMPINManagementRequest message is sent by an ATM to an ATM manager to request an operation on the cardholder PIN.
/// </summary>
[Description(@"The ATMPINManagementRequest message is sent by an ATM to an ATM manager to request an operation on the cardholder PIN.")]
[IsoId("_YLWGQa4aEeW_TaP-ygI0SQ")]
[DisplayName("ATMPIN Management Request V")]
public partial record ATMPINManagementRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.010.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMPINMgmtReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.010.001.02";
    
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
    [IsoId("_YLWGQ64aEeW_TaP-ygI0SQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header31 Header { get; init; } 
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_YLWGRa4aEeW_TaP-ygI0SQ")]
    [DisplayName("Protected ATMPIN Management Request")]
    [IsoXmlTag("PrtctdATMPINMgmtReq")]
    public ContentInformationType10? ProtectedATMPINManagementRequest { get; init; } 
    
    /// <summary>
    /// Information related to the request of a PIN management from an ATM.
    /// </summary>
    [IsoId("_YLWGR64aEeW_TaP-ygI0SQ")]
    [DisplayName("ATMPIN Management Request")]
    [IsoXmlTag("ATMPINMgmtReq")]
    public ATMPINManagementRequest2? ATMPINManagementRequest { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_YLWGSa4aEeW_TaP-ygI0SQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since ATMPINManagementRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMPINManagementRequestV02.

