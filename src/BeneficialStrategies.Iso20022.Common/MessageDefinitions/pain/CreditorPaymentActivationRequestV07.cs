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

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.013.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CreditorPaymentActivationRequest message is sent by the Creditor sending party to the Debtor receiving party, directly or through agents. It is used by a Creditor to request movement of funds from the debtor account to a creditor.
/// </summary>
[Description(
    @"The CreditorPaymentActivationRequest message is sent by the Creditor sending party to the Debtor receiving party, directly or through agents. It is used by a Creditor to request movement of funds from the debtor account to a creditor."
)]
[IsoId("_eYI_5W2PEei3KuUgpx7Xcw")]
[DisplayName("Creditor Payment Activation Request V")]
public record CreditorPaymentActivationRequestV07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.013.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CdtrPmtActvtnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.013.001.07";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_eYI_6W2PEei3KuUgpx7Xcw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader78 GroupHeader { get; init; }

    /// <summary>
    /// Set of characteristics that applies to the debit side of the payment transactions included in the creditor payment initiation.
    /// </summary>
    [IsoId("_eYI_622PEei3KuUgpx7Xcw")]
    [DisplayName("Payment Information")]
    [IsoXmlTag("PmtInf")]
    public required PaymentInstruction31 PaymentInformation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eYI_7W2PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CreditorPaymentActivationRequestV07Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CreditorPaymentActivationRequestV07.
