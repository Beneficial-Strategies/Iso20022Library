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
/// This record is an implementation of the catp.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMWithdrawalResponse message is sent by an acquirer or its agent to an ATM in response to the ATMWithdrawalRequest to inform the ATM of the approval or decline of the withdrawal transaction.
/// </summary>
[Description(@"The ATMWithdrawalResponse message is sent by an acquirer or its agent to an ATM in response to the ATMWithdrawalRequest to inform the ATM of the approval or decline of the withdrawal transaction.")]
[IsoId("_yPVcAIp0EeS3NqNpgnMh2w")]
[DisplayName("ATM Withdrawal Response V")]
public partial record ATMWithdrawalResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMWdrwlRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.002.001.01";
    
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
    [IsoId("_KlPP4Ip1EeS3NqNpgnMh2w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header20 Header { get; init; } 
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_QcTJ4Ip1EeS3NqNpgnMh2w")]
    [DisplayName("Protected ATM Withdrawal Response")]
    [IsoXmlTag("PrtctdATMWdrwlRspn")]
    public ContentInformationType10? ProtectedATMWithdrawalResponse { get; init; } 
    
    /// <summary>
    /// Information related to the response of an ATM withdrawal transaction from an ATM manager.
    /// </summary>
    [IsoId("_eGmWsIp1EeS3NqNpgnMh2w")]
    [DisplayName("ATM Withdrawal Response")]
    [IsoXmlTag("ATMWdrwlRspn")]
    public ATMWithdrawalResponse1? ATMWithdrawalResponse { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_H-D60IqMEeSRT5rEzcAHEw")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since ATMWithdrawalResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMWithdrawalResponseV01.

