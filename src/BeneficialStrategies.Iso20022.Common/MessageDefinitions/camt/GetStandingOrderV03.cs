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
/// This record is an implementation of the camt.069.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The GetStandingOrder message is sent by a member to the transaction administrator.|It is used to request information on the details of one or more standing orders, based on specific request criteria, especially to query the amount of the overall liquidity available. It will allow to query both reserved liquidity and liquidity available for normal operations.|Usage|The member can request information based on the following elements: |- individual standing orders (predefined or standing liquidity transfer orders)|- amount|- account to be credited|- account to be debited|- account owner (for on behalf scenario)|- frequency of payment|- daytime or overnight processing|- dates when the standing order begins and ceases to be effective|This message will be answered by a ReturnStandingOrder message.
/// </summary>
[Description(
    @"Scope|The GetStandingOrder message is sent by a member to the transaction administrator.|It is used to request information on the details of one or more standing orders, based on specific request criteria, especially to query the amount of the overall liquidity available. It will allow to query both reserved liquidity and liquidity available for normal operations.|Usage|The member can request information based on the following elements: |- individual standing orders (predefined or standing liquidity transfer orders)|- amount|- account to be credited|- account to be debited|- account owner (for on behalf scenario)|- frequency of payment|- daytime or overnight processing|- dates when the standing order begins and ceases to be effective|This message will be answered by a ReturnStandingOrder message."
)]
[IsoId("_jwlbnxbvEeiyVv5j1vf1VQ")]
[DisplayName("Get Standing Order V")]
public record GetStandingOrderV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.069.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetStgOrdr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.069.001.03";

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
    [IsoId("_jwlboRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader4 MessageHeader { get; init; }

    /// <summary>
    /// Defines the account query criteria.
    /// </summary>
    [IsoId("_jwlboxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Standing Order Query Definition")]
    [IsoXmlTag("StgOrdrQryDef")]
    public StandingOrderQuery3? StandingOrderQueryDefinition { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbpRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since GetStandingOrderV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to GetStandingOrderV03.
