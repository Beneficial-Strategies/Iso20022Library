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
/// This record is an implementation of the auth.121.001.01 ISO standard message type.
/// The TradingSystemStatusReport message is sent by the Trading Venue to the Consolidated Tape Provider, which disseminates the data to their users on a consolidated basis. The TradingSystemStatusReport message provides the latest operational status of trading systems operated by each Trading Venue, indicating whether a system is active, experiencing an outage, or undergoing a partial outage.
/// </summary>
[Description(
    @"The TradingSystemStatusReport message is sent by the Trading Venue to the Consolidated Tape Provider, which disseminates the data to their users on a consolidated basis. The TradingSystemStatusReport message provides the latest operational status of trading systems operated by each Trading Venue, indicating whether a system is active, experiencing an outage, or undergoing a partial outage."
)]
[IsoId("_PqPn4GFcEfC-1NkZ9TkdKA")]
[DisplayName("Trading System Status Report V01")]
public record TradingSystemStatusReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.121.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TradgSysStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.121.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides general information on the regulatory trading system report.
    /// </summary>
    [IsoId("_dsUbgGFcEfC-1NkZ9TkdKA")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public SecuritiesMarketReportHeader5? ReportHeader { get; init; }

    /// <summary>
    /// Report related to the status of trading systems.
    /// </summary>
    [IsoId("_oZnrsGFcEfC-1NkZ9TkdKA")]
    [DisplayName("Trading System Report")]
    [IsoXmlTag("TradgSysRpt")]
    [MinLength(1)]
    public ValueList<TradingSystemReport1Choice_> TradingSystemReport { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rjEv8GFcEfC-1NkZ9TkdKA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
