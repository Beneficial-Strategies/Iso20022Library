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
/// This record is an implementation of the auth.040.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingEquityTradingActivityReport message is sent by the trading venue to the national competent authority to report on equity specific trading activity data, used for the transparency calculations.
/// </summary>
[Description(
    @"The FinancialInstrumentReportingEquityTradingActivityReport message is sent by the trading venue to the national competent authority to report on equity specific trading activity data, used for the transparency calculations."
)]
[IsoId("_4LK8PURNEee7JdgA9zPESA")]
[DisplayName("Financial Instrument Reporting Equity Trading Activity Report V")]
public record FinancialInstrumentReportingEquityTradingActivityReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.040.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgEqtyTradgActvtyRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.040.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Header information related to the global report, common to all reference data.
    /// </summary>
    [IsoId("_4LK8P0RNEee7JdgA9zPESA")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; }

    /// <summary>
    /// Details the transparency data reported by a trading venue.
    /// </summary>
    [IsoId("_4LK8QURNEee7JdgA9zPESA")]
    [DisplayName("Equity Transparency Data")]
    [IsoXmlTag("EqtyTrnsprncyData")]
    public required TransparencyDataReport13 EquityTransparencyData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4LK8Q0RNEee7JdgA9zPESA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since FinancialInstrumentReportingEquityTradingActivityReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingEquityTradingActivityReportV01.
