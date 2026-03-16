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
/// This record is an implementation of the auth.072.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SettlementInternaliserReport message is sent by the settlement internalisers to the relevant competent authority to report aggregated information on all securities transactions that they settle outside securities settlement systems, on a quarterly basis. The report contains aggregated information on the value and volume of all internalised settlement instructions (settled and failed) that have been performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.
///
/// Usage:
/// This report may be used by settlement internalisers to provide aggregated information (volume and value) on internalised settlement instructions (settled and failed) to their competent authorities.
/// </summary>
[Description(
    @"The SettlementInternaliserReport message is sent by the settlement internalisers to the relevant competent authority to report aggregated information on all securities transactions that they settle outside securities settlement systems, on a quarterly basis. The report contains aggregated information on the value and volume of all internalised settlement instructions (settled and failed) that have been performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.||Usage: |This report may be used by settlement internalisers to provide aggregated information (volume and value) on internalised settlement instructions (settled and failed) to their competent authorities."
)]
[IsoId("_m9MVgO3jEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Report V")]
public record SettlementInternaliserReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.072.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SttlmIntlrRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Specifies parameters of the report.
    /// </summary>
    [IsoId("_jW2EcO3kEeaWjpoyrnG6Rw")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public required SettlementInternaliserReportHeader1 ReportHeader { get; init; }

    /// <summary>
    /// Identifies the settlement internaliser for which data is reported.
    /// </summary>
    [IsoId("_lNkVgO3kEeaWjpoyrnG6Rw")]
    [DisplayName("Settlement Internaliser")]
    [IsoXmlTag("SttlmIntlr")]
    public required SettlementInternaliser1 SettlementInternaliser { get; init; }

    /// <summary>
    /// Identifies each issuer CSD (central securities depository) included in the report.
    /// </summary>
    [IsoId("_pgDeYO3kEeaWjpoyrnG6Rw")]
    [DisplayName("Issuer CSD")]
    [IsoXmlTag("IssrCSD")]
    public required IssuerCSDReport1 IssuerCSD { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_D1rv0X9xEeiuTa5SlOUnYg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SettlementInternaliserReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SettlementInternaliserReportV01.
