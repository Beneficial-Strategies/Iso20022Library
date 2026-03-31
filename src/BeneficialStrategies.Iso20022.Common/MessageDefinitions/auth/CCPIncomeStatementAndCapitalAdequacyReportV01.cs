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
/// This record is an implementation of the auth.059.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPIncomeStatementAndCapitalAdequacyReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the financial performance and regulatory capital holdings of the central counterparty.
/// </summary>
[Description(
    @"The CCPIncomeStatementAndCapitalAdequacyReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the financial performance and regulatory capital holdings of the central counterparty."
)]
[IsoId("_DzbYceUUEem3X-64-NKdqg")]
[DisplayName("CCP Income Statement And Capital Adequacy Report V")]
public record CCPIncomeStatementAndCapitalAdequacyReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.059.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPIncmStmtAndCptlAdqcyRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.059.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Income statement of the CCP.
    /// </summary>
    [IsoId("_DzbYeeUUEem3X-64-NKdqg")]
    [DisplayName("Income Statement")]
    [IsoXmlTag("IncmStmt")]
    public required IncomeStatement1 IncomeStatement { get; init; }

    /// <summary>
    /// Report of the breakdown of the components for the capital requirement for central counterparty.
    /// </summary>
    [IsoId("_DzbYe-UUEem3X-64-NKdqg")]
    [DisplayName("Capital Requirements")]
    [IsoXmlTag("CptlRqrmnts")]
    public required CapitalRequirement1 CapitalRequirements { get; init; }

    /// <summary>
    /// Sum of the CCP&apos;s capital requirements for operational expenses; for winding down or restructuring its activities; for overall operational and legal risk; for uncovered credit, counterparty credit and market risks and business risks.
    /// </summary>
    [IsoId("_DzbYfeUUEem3X-64-NKdqg")]
    [DisplayName("Total Capital")]
    [IsoXmlTag("TtlCptl")]
    public required ActiveCurrencyAndAmount TotalCapital { get; init; }

    /// <summary>
    /// Total capital resources invested in liquid financial resources.
    /// </summary>
    [IsoId("_DzbYf-UUEem3X-64-NKdqg")]
    [DisplayName("Liquid Financial Resources")]
    [IsoXmlTag("LqdFinRsrcs")]
    public required ActiveCurrencyAndAmount LiquidFinancialResources { get; init; }

    /// <summary>
    /// Hypothetical capital requirement due to counterparty credit risk exposures to all clearing members.
    /// </summary>
    [IsoId("_DzbYgeUUEem3X-64-NKdqg")]
    [DisplayName("Hypothetical Capital Measure")]
    [IsoXmlTag("HpthtclCptlMeasr")]
    public required HypotheticalCapitalMeasure1 HypotheticalCapitalMeasure { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DzbYg-UUEem3X-64-NKdqg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CCPIncomeStatementAndCapitalAdequacyReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CCPIncomeStatementAndCapitalAdequacyReportV01.
