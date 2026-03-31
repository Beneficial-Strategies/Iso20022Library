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
/// This record is an implementation of the camt.078.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The IntraBalanceMovementQuery message is sent from an account owner/requestor to a settlement infrastructure to query intra-balance movement instructions, along with their current status, based on a set of search criteria.
/// The message may also be used to:
/// - re-send a message sent by the account owner to the account servicer (the sub-function of the message is &quot;Duplicate&quot;)
/// - provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is &quot;Copy&quot;)
/// - re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is &quot;Copy Duplicate&quot;).
///
/// </summary>
[Description(
    @"The IntraBalanceMovementQuery message is sent from an account owner/requestor to a settlement infrastructure to query intra-balance movement instructions, along with their current status, based on a set of search criteria.|The message may also be used to: |- re-send a message sent by the account owner to the account servicer (the sub-function of the message is ""Duplicate"") |- provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy"") |- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy Duplicate"").|"
)]
[IsoId("_DLtLYzncEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Movement Query V")]
public record IntraBalanceMovementQueryV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.078.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntQry";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.078.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unambiguous identification of the message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_DLtLazncEem7JZMuWtwtsg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public DocumentIdentification51? Identification { get; init; }

    /// <summary>
    /// Defines the intra-balance movement instruction query criteria.
    /// </summary>
    [IsoId("_DLtLbTncEem7JZMuWtwtsg")]
    [DisplayName("Query Definition")]
    [IsoXmlTag("QryDef")]
    public required IntraBalanceQueryDefinition9 QueryDefinition { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DLtLbzncEem7JZMuWtwtsg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since IntraBalanceMovementQueryV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraBalanceMovementQueryV01.
