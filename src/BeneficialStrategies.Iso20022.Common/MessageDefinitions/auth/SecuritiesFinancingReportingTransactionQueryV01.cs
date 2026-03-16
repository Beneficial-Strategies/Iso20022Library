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

namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.094.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesFinancingReportingTransactionQuery message is sent by the authority to the trade repositories, to query data based on the search criteria for the  transactions as defined by the system user.
/// </summary>
[Description(
    @"The SecuritiesFinancingReportingTransactionQuery message is sent by the authority to the trade repositories, to query data based on the search criteria for the  transactions as defined by the system user."
)]
[IsoId("_2zvMFQuAEeqVvtu9Ny8FDA")]
[DisplayName("Securities Financing Reporting Transaction Query V")]
public record SecuritiesFinancingReportingTransactionQueryV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.094.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgTxQry";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.094.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Indicates the authority that requests the query report.
    /// </summary>
    [IsoId("_2zvMFwuAEeqVvtu9Ny8FDA")]
    [DisplayName("Requesting Authority")]
    [IsoXmlTag("RqstngAuthrty")]
    public required PartyIdentification121Choice_ RequestingAuthority { get; init; }

    /// <summary>
    /// Criteria for defining recurrent and ad-hoc queries.
    /// </summary>
    [IsoId("_2zvMGQuAEeqVvtu9Ny8FDA")]
    [DisplayName("Trade Query Data")]
    [IsoXmlTag("TradQryData")]
    public required TradeReportQuery8Choice_ TradeQueryData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2zvMGwuAEeqVvtu9Ny8FDA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesFinancingReportingTransactionQueryV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesFinancingReportingTransactionQueryV01.
