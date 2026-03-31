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
/// This record is an implementation of the camt.101.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CreateLimit message is sent by a member to the transaction administrator.
/// It is used to create one or several limits set by the member and managed by the transaction administrator.
/// Usage
/// Based on the criteria defined in the CreateLimit message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// </summary>
[Description(
    @"Scope|The CreateLimit message is sent by a member to the transaction administrator.|It is used to create one or several limits set by the member and managed by the transaction administrator.|Usage|Based on the criteria defined in the CreateLimit message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request."
)]
[IsoId("_P8tBcckHEem3UrxZgQhVAw")]
[DisplayName("Create Limit V")]
public record CreateLimitV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.101.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretLmt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.101.001.01";

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
    [IsoId("_P8tBd8kHEem3UrxZgQhVAw")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader1 MessageHeader { get; init; }

    /// <summary>
    /// Identifies one particular limit set by the member and managed by the transaction administrator.
    /// </summary>
    [IsoId("_P8tBeckHEem3UrxZgQhVAw")]
    [DisplayName("Limit Data")]
    [IsoXmlTag("LmtData")]
    public required LimitStructure4 LimitData { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_P8tBe8kHEem3UrxZgQhVAw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CreateLimitV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CreateLimitV01.
