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
/// This record is an implementation of the auth.036.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingReferenceDataDeltaReport message is sent by the trading venues to the national competent authority to report on changes that have occurred in the base data between reference data file generation.
/// </summary>
[Description(
    @"The FinancialInstrumentReportingReferenceDataDeltaReport message is sent by the trading venues to the national competent authority to report on changes that have occurred in the base data between reference data file generation."
)]
[IsoId("_dA7JAaWuEeqZmriXpMtonA")]
[DisplayName("Financial Instrument Reporting Reference Data Delta Report V")]
public record FinancialInstrumentReportingReferenceDataDeltaReportV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.036.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgRefDataDltaRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.036.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_dA7JA6WuEeqZmriXpMtonA")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; }

    /// <summary>
    /// Provides the details of the reference data that have been updated (since the last report).
    /// </summary>
    [IsoId("_dA7JBaWuEeqZmriXpMtonA")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public SecuritiesReferenceDeltaStatusReport5Choice_? FinancialInstrument { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_dA7JB6WuEeqZmriXpMtonA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since FinancialInstrumentReportingReferenceDataDeltaReportV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingReferenceDataDeltaReportV03.
