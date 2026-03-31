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

namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.015.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:|The PartyQuery message is sent by a central securities depository, a national central bank, a central securities depository participant, a central counter party, a payment bank, a trading party or a stock exchange to the executing party to query for the party reference data of a party defined in the system.
/// </summary>
[Description(
    @"Scope:|The PartyQuery message is sent by a central securities depository, a national central bank, a central securities depository participant, a central counter party, a payment bank, a trading party or a stock exchange to the executing party to query for the party reference data of a party defined in the system."
)]
[IsoId("_6z5WgZeSEeen_cyMrluY4w")]
[DisplayName("Party Query V")]
public record PartyQueryV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.015.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyQry";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.015.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Point to point reference elements, as assigned by the instructing party, to unambiguously identify the query message.
    /// </summary>
    [IsoId("_6z5Wg5eSEeen_cyMrluY4w")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public MessageHeader2? MessageHeader { get; init; }

    /// <summary>
    /// Defines the criteria to be used to query the party reference data by the executing system.
    /// </summary>
    [IsoId("_6z5WiZeSEeen_cyMrluY4w")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required PartyDataSearchCriteria2 SearchCriteria { get; init; }

    /// <summary>
    /// Defines the expected party reference data to be returned.
    /// </summary>
    [IsoId("_6z5Wi5eSEeen_cyMrluY4w")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public PartyDataReturnCriteria2? ReturnCriteria { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_6z5WjZeSEeen_cyMrluY4w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since PartyQueryV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyQueryV01.
