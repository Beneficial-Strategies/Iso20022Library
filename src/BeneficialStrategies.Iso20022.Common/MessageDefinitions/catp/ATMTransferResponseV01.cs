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
/// This record is an implementation of the catp.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMTransferResponse message is sent by an acquirer or its agent to inform the ATM of the approval or decline of the transfer transaction.
/// </summary>
[Description(@"The ATMTransferResponse message is sent by an acquirer or its agent to inform the ATM of the approval or decline of the transfer transaction.")]
[IsoId("_jHLDMK4xEeWpsoxRhdX-8A")]
[DisplayName("ATM Transfer Response V")]
public partial record ATMTransferResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.017.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMTrfRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.017.001.01";
    
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
    [IsoId("_unMJwK4xEeWpsoxRhdX-8A")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header31 Header { get; init; } 
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_xu3FUK4xEeWpsoxRhdX-8A")]
    [DisplayName("Protected ATM Transfer Response")]
    [IsoXmlTag("PrtctdATMTrfRspn")]
    public ContentInformationType10? ProtectedATMTransferResponse { get; init; } 
    
    /// <summary>
    /// Information related to the response of an ATM transfer from an ATM manager.
    /// </summary>
    [IsoId("_5-VBIK4xEeWpsoxRhdX-8A")]
    [DisplayName("ATM Transfer Response")]
    [IsoXmlTag("ATMTrfRspn")]
    public ATMTransferResponse1? ATMTransferResponse { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_5IGm8K41EeWpsoxRhdX-8A")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since ATMTransferResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMTransferResponseV01.

