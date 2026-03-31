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

namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CollateralValueQuery message is sent by a system member (such as a directly connected party) to the system transaction administrator to query the current available value of securities for auto collateralisation for one specific or several cash accounts.
/// </summary>
[Description(
    @"The CollateralValueQuery message is sent by a system member (such as a directly connected party) to the system transaction administrator to query the current available value of securities for auto collateralisation for one specific or several cash accounts."
)]
[IsoId("_5SjM8TooEemaN9GkhmGkfg")]
[DisplayName("Collateral Value Query V")]
public record CollateralValueQueryV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.001.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollValQry";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.001.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of elements to identify the collateral value query message.
    /// </summary>
    [IsoId("_5SjM-TooEemaN9GkhmGkfg")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader3 MessageHeader { get; init; }

    /// <summary>
    /// Definition of the collateral query.
    /// </summary>
    [IsoId("_5SjM-zooEemaN9GkhmGkfg")]
    [DisplayName("Collateral Value Query Definition")]
    [IsoXmlTag("CollValQryDef")]
    public CollateralValueCriteriaDefinition3Choice_? CollateralValueQueryDefinition { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5SjM_TooEemaN9GkhmGkfg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CollateralValueQueryV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CollateralValueQueryV01.
