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
/// This record is an implementation of the auth.061.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPInvestmentsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about how the central counterparty invests the cash balances deposited with it as collateral by its clearing members.
/// </summary>
[Description(
    @"The CCPInvestmentsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about how the central counterparty invests the cash balances deposited with it as collateral by its clearing members."
)]
[IsoId("_JJKuEeUUEem3X-64-NKdqg")]
[DisplayName("CCP Investments Report V")]
public record CCPInvestmentsReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.061.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPInvstmtsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.061.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Specifies a financial instrument purchased by a central counterparty using clearing member assets.
    /// </summary>
    [IsoId("_JJKuGeUUEem3X-64-NKdqg")]
    [DisplayName("Investment")]
    [IsoXmlTag("Invstmt")]
    public required Investment1Choice_ Investment { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_JJKuG-UUEem3X-64-NKdqg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CCPInvestmentsReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CCPInvestmentsReportV01.
