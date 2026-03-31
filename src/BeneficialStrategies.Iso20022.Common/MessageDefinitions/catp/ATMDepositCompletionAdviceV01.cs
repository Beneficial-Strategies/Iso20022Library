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
/// This record is an implementation of the catp.014.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMDepositCompletionAdvice message is sent by an ATM to an acquirer or its agent to inform of the result of a deposit transaction at an ATM.
/// If the ATM is configured to only send negative completion, a generic completion message should be used instead of ATMCompletionAdvice.
/// This message can be used each time a bundle is put in the ATM safe and/or at the end of a multi bundle deposit.
/// </summary>
[Description(
    @"The ATMDepositCompletionAdvice message is sent by an ATM to an acquirer or its agent to inform of the result of a deposit transaction at an ATM.|If the ATM is configured to only send negative completion, a generic completion message should be used instead of ATMCompletionAdvice.|This message can be used each time a bundle is put in the ATM safe and/or at the end of a multi bundle deposit."
)]
[IsoId("_-6CQgK4NEeWZgJQOa6iKCQ")]
[DisplayName("ATM Deposit Completion Advice V")]
public record ATMDepositCompletionAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.014.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDpstCmpltnAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.014.001.01";

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
    [IsoId("_Kc-vQK4OEeWZgJQOa6iKCQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header32 Header { get; init; }

    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_PzcdoK4OEeWZgJQOa6iKCQ")]
    [DisplayName("Protected ATM Deposit Completion Advice")]
    [IsoXmlTag("PrtctdATMDpstCmpltnAdvc")]
    public ContentInformationType10? ProtectedATMDepositCompletionAdvice { get; init; }

    /// <summary>
    /// Information related to the completion of a deposit transaction on the ATM.
    /// </summary>
    [IsoId("_SW544K4OEeWZgJQOa6iKCQ")]
    [DisplayName("ATM Deposit Completion Advice")]
    [IsoXmlTag("ATMDpstCmpltnAdvc")]
    public ATMDepositCompletionAdvice1? ATMDepositCompletionAdvice { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_Vo7qUK4OEeWZgJQOa6iKCQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
}

// Since ATMDepositCompletionAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMDepositCompletionAdviceV01.
