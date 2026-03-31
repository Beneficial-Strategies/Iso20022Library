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
/// This record is an implementation of the catp.015.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_y9J_AaFFEe-MRKYsaX6JDg")]
[DisplayName("ATM Deposit Completion Acknowledgement V02")]
public record ATMDepositCompletionAcknowledgementV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.015.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDpstCmpltnAck";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.015.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// ATM Deposit Completion Acknowledgement.
    /// </summary>
    [DisplayName("ATM Deposit Completion Acknowledgement")]
    [IsoXmlTag("ATMDpstCmpltnAck")]
    public ATMDepositCompletionAcknowledgement2? ATMDepositCompletionAcknowledgement { get; init; }

    /// <summary>
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header32 Header { get; init; }

    /// <summary>
    /// Protected ATM Deposit Completion Acknowledgement.
    /// </summary>
    [DisplayName("Protected ATM Deposit Completion Acknowledgement")]
    [IsoXmlTag("PrtctdATMDpstCmpltnAck")]
    public ContentInformationType10? ProtectedATMDepositCompletionAcknowledgement { get; init; }

    /// <summary>
    /// Security Trailer.
    /// </summary>
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
}

// Since ATMDepositCompletionAcknowledgementV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMDepositCompletionAcknowledgementV02.
