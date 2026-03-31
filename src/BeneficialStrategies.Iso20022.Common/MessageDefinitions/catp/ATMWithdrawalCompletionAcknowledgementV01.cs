// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// This record is an implementation of the catp.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMWithdrawalCompletionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMWithdrawalCompletionAdvice message.
/// </summary>
[Description(
    @"The ATMWithdrawalCompletionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMWithdrawalCompletionAdvice message."
)]
[IsoId("_P2qh4IqkEeS4a4abTJTSSw")]
[DisplayName("ATM Withdrawal Completion Acknowledgement V")]
public record ATMWithdrawalCompletionAcknowledgementV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.004.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMWdrwlCmpltnAck";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.004.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_aFDBcIqkEeS4a4abTJTSSw")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header21 Header { get; init; }

    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_fAp_0IqkEeS4a4abTJTSSw")]
    [DisplayName("Protected ATM Withdrawal Completion Acknowledgement")]
    [IsoXmlTag("PrtctdATMWdrwlCmpltnAck")]
    public ContentInformationType10? ProtectedATMWithdrawalCompletionAcknowledgement { get; init; }

    /// <summary>
    /// Information related to the acknowledgement of an ATM withdrawal transaction from the ATM manager.
    /// </summary>
    [IsoId("_yUgPEIqkEeS4a4abTJTSSw")]
    [DisplayName("ATM Withdrawal Completion Acknowledgement")]
    [IsoXmlTag("ATMWdrwlCmpltnAck")]
    public ATMWithdrawalCompletionAcknowledgement1? ATMWithdrawalCompletionAcknowledgement { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_2jjpcIqkEeS4a4abTJTSSw")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
}

// Since ATMWithdrawalCompletionAcknowledgementV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMWithdrawalCompletionAcknowledgementV01.
