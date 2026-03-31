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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.102.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CreateStandingOrder message is sent by a member to the transaction administrator.
/// It is used to create a permanent order for the transfer of funds between two accounts belonging to the same member and being held at the transaction administrator.
/// Usage
/// Based on the criteria defined in the CreateStandingOrder message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// </summary>
[Description(
    @"Scope|The CreateStandingOrder message is sent by a member to the transaction administrator.|It is used to create a permanent order for the transfer of funds between two accounts belonging to the same member and being held at the transaction administrator.|Usage|Based on the criteria defined in the CreateStandingOrder message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request."
)]
[IsoId("_P8uPkckHEem3UrxZgQhVAw")]
[DisplayName("Create Standing Order V")]
public record CreateStandingOrderV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.102.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretStgOrdr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.102.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_P8uPmckHEem3UrxZgQhVAw")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader1 MessageHeader { get; init; }

    /// <summary>
    /// Identifies the standing order.
    /// </summary>
    [IsoId("_P8uPm8kHEem3UrxZgQhVAw")]
    [DisplayName("Standing Order Identification")]
    [IsoXmlTag("StgOrdrId")]
    public required StandingOrderIdentification4 StandingOrderIdentification { get; init; }

    /// <summary>
    /// Set of values for the standing order.
    /// </summary>
    [IsoId("_P8uPnckHEem3UrxZgQhVAw")]
    [DisplayName("Value Set")]
    [IsoXmlTag("ValSet")]
    public required StandingOrder7 ValueSet { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_P8uPn8kHEem3UrxZgQhVAw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CreateStandingOrderV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CreateStandingOrderV01.
