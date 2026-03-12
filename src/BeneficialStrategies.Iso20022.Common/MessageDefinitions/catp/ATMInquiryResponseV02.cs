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
/// This record is an implementation of the catp.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMInquiryResponse message is sent by an ATM manager or its agent to the ATM to provide the information and the outcome of the verifications requested in the ATMInquiryRequest.
/// </summary>
[Description(@"The ATMInquiryResponse message is sent by an ATM manager or its agent to the ATM to provide the information and the outcome of the verifications requested in the ATMInquiryRequest.")]
[IsoId("_P04uca4WEeW_TaP-ygI0SQ")]
[DisplayName("ATM Inquiry Response V")]
public partial record ATMInquiryResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.007.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMNqryRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.007.001.02";
    
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
    [IsoId("_P04uc64WEeW_TaP-ygI0SQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header31 Header { get; init; } 
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_P04uda4WEeW_TaP-ygI0SQ")]
    [DisplayName("Protected ATM Inquiry Response")]
    [IsoXmlTag("PrtctdATMNqryRspn")]
    public ContentInformationType10? ProtectedATMInquiryResponse { get; init; } 
    
    /// <summary>
    /// Information related to the response of an ATM inquiry from an ATM manager.
    /// </summary>
    [IsoId("_P04ud64WEeW_TaP-ygI0SQ")]
    [DisplayName("ATM Inquiry Response")]
    [IsoXmlTag("ATMNqryRspn")]
    public ATMInquiryResponse2? ATMInquiryResponse { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_P04uea4WEeW_TaP-ygI0SQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since ATMInquiryResponseV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMInquiryResponseV02.

