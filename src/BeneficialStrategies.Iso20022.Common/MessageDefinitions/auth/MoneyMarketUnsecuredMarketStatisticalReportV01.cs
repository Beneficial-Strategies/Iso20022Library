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
/// This record is an implementation of the auth.013.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MoneyMarketUnsecuredMarketStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report all relevant unsecured money market transactions.
/// </summary>
[Description(
    @"The MoneyMarketUnsecuredMarketStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report all relevant unsecured money market transactions."
)]
[IsoId("_zmNG4aieEeWHO_l3hf2rlA")]
[DisplayName("Money Market Unsecured Market Statistical Report V")]
public record MoneyMarketUnsecuredMarketStatisticalReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.013.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MnyMktUscrdMktSttstclRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.013.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides the elements specific to the report.
    /// </summary>
    [IsoId("_zmNG46ieEeWHO_l3hf2rlA")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public required MoneyMarketReportHeader1 ReportHeader { get; init; }

    /// <summary>
    /// Provides the reason why no activity is reported or the required list of transactions for the unsecured market segment.
    /// </summary>
    [IsoId("_zmNG5aieEeWHO_l3hf2rlA")]
    [DisplayName("Unsecured Market Report")]
    [IsoXmlTag("UscrdMktRpt")]
    public required UnsecuredMarketReport3Choice_ UnsecuredMarketReport { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_zmNG56ieEeWHO_l3hf2rlA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MoneyMarketUnsecuredMarketStatisticalReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MoneyMarketUnsecuredMarketStatisticalReportV01.
