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

namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingIssuanceNotification message is sent by the party that issued the undertaking to the applicant to notify it of the contents of an undertaking issued electronically or on paper. The undertaking that is notified could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. In addition to containing details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking, the message may provide information from the sender such as confirmation details.
/// </summary>
[Description(
    @"The UndertakingIssuanceNotification message is sent by the party that issued the undertaking to the applicant to notify it of the contents of an undertaking issued electronically or on paper. The undertaking that is notified could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. In addition to containing details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking, the message may provide information from the sender such as confirmation details."
)]
[IsoId("_9ft4hnltEeG7BsjMvd1mEw_-1741086320")]
[DisplayName("Undertaking Issuance Notification V")]
public record UndertakingIssuanceNotificationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.003.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgIssncNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.003.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Details related to the notification of the issued undertaking.
    /// </summary>
    [IsoId("_9ft4h3ltEeG7BsjMvd1mEw_725603216")]
    [DisplayName("Undertaking Issuance Notification Details")]
    [IsoXmlTag("UdrtkgIssncNtfctnDtls")]
    public required UndertakingAdvice2 UndertakingIssuanceNotificationDetails { get; init; }

    /// <summary>
    /// Digital signature of the undertaking notification.
    /// </summary>
    [IsoId("_9ft4iHltEeG7BsjMvd1mEw_-695540807")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
}

// Since UndertakingIssuanceNotificationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingIssuanceNotificationV01.
