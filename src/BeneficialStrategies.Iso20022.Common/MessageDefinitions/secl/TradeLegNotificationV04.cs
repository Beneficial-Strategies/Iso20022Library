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

namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// This record is an implementation of the secl.001.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_YZ-MQYcPEe-m68RYMhvgvg")]
[DisplayName("Trade Leg Notification V04")]
public record TradeLegNotificationV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.001.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TradLegNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.001.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Clearing Account.
    /// </summary>
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public required SecuritiesAccount18 ClearingAccount { get; init; }

    /// <summary>
    /// Clearing Details.
    /// </summary>
    [DisplayName("Clearing Details")]
    [IsoXmlTag("ClrDtls")]
    public Clearing7? ClearingDetails { get; init; }

    /// <summary>
    /// Clearing Member.
    /// </summary>
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public required PartyIdentification253Choice_ ClearingMember { get; init; }

    /// <summary>
    /// Delivery Account.
    /// </summary>
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; }

    /// <summary>
    /// Non Clearing Member.
    /// </summary>
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount227? NonClearingMember { get; init; }

    /// <summary>
    /// Settlement Details.
    /// </summary>
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required Settlement2 SettlementDetails { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Trade Leg Details.
    /// </summary>
    [DisplayName("Trade Leg Details")]
    [IsoXmlTag("TradLegDtls")]
    public required TradeLeg11 TradeLegDetails { get; init; }
}

// Since TradeLegNotificationV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TradeLegNotificationV04.
