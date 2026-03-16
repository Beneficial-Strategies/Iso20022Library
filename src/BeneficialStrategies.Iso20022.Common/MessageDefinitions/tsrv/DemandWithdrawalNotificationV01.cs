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
/// This record is an implementation of the tsrv.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DemandWithdrawalNotification message is sent by the beneficiary to the party that issued the undertaking, either directly or via a presenting or nominated party, to inform the issuer or nominated party that it has elected to withdraw its demand under the demand guarantee or standby letter of credit.
/// </summary>
[Description(
    @"The DemandWithdrawalNotification message is sent by the beneficiary to the party that issued the undertaking, either directly or via a presenting or nominated party, to inform the issuer or nominated party that it has elected to withdraw its demand under the demand guarantee or standby letter of credit."
)]
[IsoId("_9hWQMnltEeG7BsjMvd1mEw_1943951405")]
[DisplayName("Demand Withdrawal Notification V")]
public record DemandWithdrawalNotificationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.017.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DmndWdrwlNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Details of the demand withdrawal notification.
    /// </summary>
    [IsoId("_9hWQM3ltEeG7BsjMvd1mEw_234628498")]
    [DisplayName("Demand Withdrawal Notification Details")]
    [IsoXmlTag("DmndWdrwlNtfctnDtls")]
    public required UndertakingDemandWithdrawal1 DemandWithdrawalNotificationDetails { get; init; }

    /// <summary>
    /// Digital signature of the notification.
    /// </summary>
    [IsoId("_9hWQNHltEeG7BsjMvd1mEw_-1538509071")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
}

// Since DemandWithdrawalNotificationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DemandWithdrawalNotificationV01.
