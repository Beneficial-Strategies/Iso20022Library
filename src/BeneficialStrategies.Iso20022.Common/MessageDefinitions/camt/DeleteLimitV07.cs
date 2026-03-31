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
/// This record is an implementation of the camt.012.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The DeleteLimit message is sent by a member to the transaction administrator.
/// It is used to request the deletion of one particular, several or all limits set by the member and managed by the transaction administrator.
/// The DeleteLimit message may delete several types of current limits (risk or liquidity management limit), based on a multiple requests.
/// Usage
/// The member will submit a DeleteLimit message identifying which limit(s) it wants to delete (current limit risk/liquidity limit concepts have been merged) based on following criteria:
/// - type of limit(s) (current/default)
/// - value of the limit(s) (default and/or current limit(s))
/// - identification of the counterparty (bilateral limit)
/// Based on the criteria received within the DeleteLimit message, the transaction administrator will execute or reject the requested modifications.
/// The transaction administrator may send a Receipt message as a reply to the DeleteLimit request.
/// To verify the outcome of the request, the member may submit a GetLimit message with the appropriate search criteria.
/// </summary>
[Description(
    @"Scope|The DeleteLimit message is sent by a member to the transaction administrator.|It is used to request the deletion of one particular, several or all limits set by the member and managed by the transaction administrator.|The DeleteLimit message may delete several types of current limits (risk or liquidity management limit), based on a multiple requests.|Usage|The member will submit a DeleteLimit message identifying which limit(s) it wants to delete (current limit risk/liquidity limit concepts have been merged) based on following criteria:|- type of limit(s) (current/default)|- value of the limit(s) (default and/or current limit(s))|- identification of the counterparty (bilateral limit)|Based on the criteria received within the DeleteLimit message, the transaction administrator will execute or reject the requested modifications.|The transaction administrator may send a Receipt message as a reply to the DeleteLimit request.|To verify the outcome of the request, the member may submit a GetLimit message with the appropriate search criteria."
)]
[IsoId("_jwlbTxbvEeiyVv5j1vf1VQ")]
[DisplayName("Delete Limit V")]
public record DeleteLimitV07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.012.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DelLmt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.012.001.07";

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
    [IsoId("_jwlbURbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader1 MessageHeader { get; init; }

    /// <summary>
    /// Identifies one particular limit set by the member and managed by the transaction administrator.
    /// </summary>
    [IsoId("_jwlbUxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Limit Details")]
    [IsoXmlTag("LmtDtls")]
    public required LimitStructure2Choice_ LimitDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbVRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since DeleteLimitV07Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DeleteLimitV07.
