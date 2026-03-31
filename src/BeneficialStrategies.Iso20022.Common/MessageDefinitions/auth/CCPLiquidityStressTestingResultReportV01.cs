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
/// This record is an implementation of the auth.063.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPLiquidityStressTestingResultReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the results of the liquidity stress tests.
/// </summary>
[Description(
    @"The CCPLiquidityStressTestingResultReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the results of the liquidity stress tests."
)]
[IsoId("_FO6mYeUREem3X-64-NKdqg")]
[DisplayName("CCP Liquidity Stress Testing Result Report V")]
public record CCPLiquidityStressTestingResultReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.063.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPLqdtyStrssTstgRsltRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.063.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Results from a scenario used to stress the liquidity needs of the CCP.
    /// </summary>
    [IsoId("_FO6maeUREem3X-64-NKdqg")]
    [DisplayName("Liquidity Stress Test Result")]
    [IsoXmlTag("LqdtyStrssTstRslt")]
    public required LiquidityStressTestResult1 LiquidityStressTestResult { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_FO6ma-UREem3X-64-NKdqg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CCPLiquidityStressTestingResultReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CCPLiquidityStressTestingResultReportV01.
