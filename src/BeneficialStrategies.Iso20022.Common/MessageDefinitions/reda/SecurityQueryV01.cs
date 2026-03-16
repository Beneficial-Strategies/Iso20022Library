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
/// This record is an implementation of the reda.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// An instructing party sends a SecurityQuery message to an executing/servicing party to request a report of financial instrument details in their system.
///
/// The instructing party - executing/servicing party relationship may be:
/// - Central Securities Depositories (CSD) who would like to publish security static data, or
/// - a Corporate, or
/// - a Bank, or
/// - a Market Infrastructure, or
/// - a Market Data Provider.
///
/// USAGE
/// The request is sent when the instructing party needs to see data of a security data within the executing/servicing party system.
///
/// Initiator: instructing party.
/// </summary>
[Description(
    @"SCOPE|An instructing party sends a SecurityQuery message to an executing/servicing party to request a report of financial instrument details in their system.||The instructing party - executing/servicing party relationship may be:|- Central Securities Depositories (CSD) who would like to publish security static data, or |- a Corporate, or|- a Bank, or|- a Market Infrastructure, or |- a Market Data Provider.||USAGE|The request is sent when the instructing party needs to see data of a security data within the executing/servicing party system.||Initiator: instructing party."
)]
[IsoId("_jTvN8x62Eeu31YsWNiv_cw")]
[DisplayName("Security Query V")]
public record SecurityQueryV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.010.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctyQry";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.010.001.01";

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
    [IsoId("_Vmf7QZIxEeuAlLVx8pyt3w")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public MessageHeader1? MessageHeader { get; init; }

    /// <summary>
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [IsoId("_16GBoZI1EeuAlLVx8pyt3w")]
    [DisplayName("Request Type")]
    [IsoXmlTag("ReqTp")]
    public GenericIdentification1? RequestType { get; init; }

    /// <summary>
    /// Defines the criteria to be used to query the securities reference data by the executing system.
    /// </summary>
    [IsoId("_jTv02x62Eeu31YsWNiv_cw")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required SecuritiesSearchCriteria4 SearchCriteria { get; init; }

    /// <summary>
    /// Defines the expected securities reference data to be returned.
    /// </summary>
    [IsoId("_jTv03R62Eeu31YsWNiv_cw")]
    [DisplayName("Small Set Return Criteria")]
    [IsoXmlTag("SmlSetRtrCrit")]
    public SecuritiesReturnCriteria1? SmallSetReturnCriteria { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jTv04x62Eeu31YsWNiv_cw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecurityQueryV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecurityQueryV01.
