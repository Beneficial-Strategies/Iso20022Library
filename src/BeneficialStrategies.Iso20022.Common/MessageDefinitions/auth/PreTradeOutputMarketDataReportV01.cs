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
/// This record is an implementation of the auth.123.001.01 ISO standard message type.
/// The PreTradeOutputMarketDataReport message is sent by the Consolidated Tape Provider, based on data submitted by Trading Venues, in accordance with local regulations. The message contains consolidated pre-trade transparency data for financial instruments, including aggregated bid and ask prices, order sizes, type of auction, and timestamps.
/// </summary>
[Description(
    @"The PreTradeOutputMarketDataReport message is sent by the Consolidated Tape Provider, based on data submitted by Trading Venues, in accordance with local regulations. The message contains consolidated pre-trade transparency data for financial instruments, including aggregated bid and ask prices, order sizes, type of auction, and timestamps."
)]
[IsoId("_dilHEGIUEfCeoPFCHQnhvA")]
[DisplayName("Pre Trade Output Market Data Report V01")]
public record PreTradeOutputMarketDataReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.123.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PreTradOutptMktDataRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.123.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides general information on the pre-trade core output data report.
    /// </summary>
    [IsoId("_t1bqgGIUEfCeoPFCHQnhvA")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public SecuritiesMarketReportHeader5? ReportHeader { get; init; }

    /// <summary>
    /// Report related to the output of pre-trade transparency data for financial instruments.
    /// </summary>
    [IsoId("_6rf-AGIUEfCeoPFCHQnhvA")]
    [DisplayName("Output Data Report")]
    [IsoXmlTag("OutptDataRpt")]
    [MinLength(1)]
    public ValueList<OutputData1Choice_> OutputDataReport { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1JfuAGIUEfCeoPFCHQnhvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
