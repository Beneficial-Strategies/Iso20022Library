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
/// This record is an implementation of the auth.120.001.01 ISO standard message type.
/// The InstrumentStatusReport message is sent by the Trading Venue to the Consolidated Tape Provider, which disseminates the data to their users on a consolidated basis. The InstrumentStatusReport message contains the latest trading status of financial instruments on a per-venue basis, including information such as whether an instrument is active, suspended, halted, or removed, along with its current trading phase.
/// </summary>
[Description(
    @"The InstrumentStatusReport message is sent by the Trading Venue to the Consolidated Tape Provider, which disseminates the data to their users on a consolidated basis. The InstrumentStatusReport message contains the latest trading status of financial instruments on a per-venue basis, including information such as whether an instrument is active, suspended, halted, or removed, along with its current trading phase."
)]
[IsoId("_ahM2QGFPEfC91ZUW7iS7ww")]
[DisplayName("Financial Instrument Status Report V01")]
public record FinancialInstrumentStatusReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.120.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.120.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides general information on the instruments report.
    /// </summary>
    [IsoId("_wMMtoGFQEfC91ZUW7iS7ww")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public SecuritiesMarketReportHeader5? ReportHeader { get; init; }

    /// <summary>
    /// Report related to the status of financial instruments traded on a given venue.
    /// </summary>
    [IsoId("_C3pgIGFREfC91ZUW7iS7ww")]
    [DisplayName("Instrument Report")]
    [IsoXmlTag("InstrmRpt")]
    [MinLength(1)]
    public ValueList<InstrumentReport1Choice_> InstrumentReport { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_axV5IGFREfC91ZUW7iS7ww")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
