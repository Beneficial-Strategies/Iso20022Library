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

namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.024.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The PaymentRegulatoryInformationNotification message is sent by the reporting party to the registration agent to provide details on the transaction, when a payment has to be recorded against the registered currency control contract.
///
/// In some cases, the registration agent may also sent this message to the reporting party.
/// </summary>
[Description(
    @"The PaymentRegulatoryInformationNotification message is sent by the reporting party to the registration agent to provide details on the transaction, when a payment has to be recorded against the registered currency control contract. ||In some cases, the registration agent may also sent this message to the reporting party."
)]
[IsoId("_bf9R622PEei3KuUgpx7Xcw")]
[DisplayName("Payment Regulatory Information Notification V")]
public record PaymentRegulatoryInformationNotificationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.024.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PmtRgltryInfNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.024.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_bf9R7W2PEei3KuUgpx7Xcw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required CurrencyControlHeader5 GroupHeader { get; init; }

    /// <summary>
    /// Notification of information related to a regulatory reporting on a payment.
    /// </summary>
    [IsoId("_bf9R722PEei3KuUgpx7Xcw")]
    [DisplayName("Transaction Notification")]
    [IsoXmlTag("TxNtfctn")]
    public required RegulatoryReportingNotification2 TransactionNotification { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9R8W2PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since PaymentRegulatoryInformationNotificationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PaymentRegulatoryInformationNotificationV02.
