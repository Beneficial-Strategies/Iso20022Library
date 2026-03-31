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
/// This record is an implementation of the secl.004.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Net Position Report message is sent by the central counterparty (CCP) to a clearing member to confirm the net position of all trade legs reported during the day.
///
/// The message definition is intended for use with the ISO 20022 Business Application Header.
///
/// Usage
/// The central counterparty (CCP) nets all the positions per clearing account and sends the Net Position report message to the Clearing member.
/// </summary>
[Description(
    @"Scope|The Net Position Report message is sent by the central counterparty (CCP) to a clearing member to confirm the net position of all trade legs reported during the day.||The message definition is intended for use with the ISO 20022 Business Application Header.||Usage|The central counterparty (CCP) nets all the positions per clearing account and sends the Net Position report message to the Clearing member."
)]
[IsoId("_9C7fsS0lEeSRe9rElPHBfg")]
[DisplayName("Net Position V")]
public record NetPositionV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.004.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetPos";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.004.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides parameters of the margin report such as the creation date and time, the report currency or the calculation date and time.
    /// </summary>
    [IsoId("_9C7fsy0lEeSRe9rElPHBfg")]
    [DisplayName("Report Parameters")]
    [IsoXmlTag("RptParams")]
    public required ReportParameters1 ReportParameters { get; init; }

    /// <summary>
    /// Provides information about the number of used pages.
    /// </summary>
    [IsoId("_9C7ftS0lEeSRe9rElPHBfg")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination Pagination { get; init; }

    /// <summary>
    /// Provides the identification of the account owner, that is the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_9C7fty0lEeSRe9rElPHBfg")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public required PartyIdentification35Choice_ ClearingMember { get; init; }

    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows Clearing Member Firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, Clearing Member Firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_9C7fuS0lEeSRe9rElPHBfg")]
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification35Choice_? ClearingSegment { get; init; }

    /// <summary>
    /// Provides the net position details such as the average deal price and net quantity.
    /// </summary>
    [IsoId("_9C7fuy0lEeSRe9rElPHBfg")]
    [DisplayName("Net Position Report")]
    [IsoXmlTag("NetPosRpt")]
    public required NetPosition3 NetPositionReport { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_9C7fvS0lEeSRe9rElPHBfg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since NetPositionV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NetPositionV03.
