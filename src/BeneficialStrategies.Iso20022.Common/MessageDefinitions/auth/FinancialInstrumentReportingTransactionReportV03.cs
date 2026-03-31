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
/// This record is an implementation of the auth.016.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingTransactionReport message is sent by the reporting agent to the competent authority to report on the securities transactions or by the competent authority to another competent authority when the transaction needs to be exchanged between the competent authorities.
/// </summary>
[Description(
    @"The FinancialInstrumentReportingTransactionReport message is sent by the reporting agent to the competent authority to report on the securities transactions or by the competent authority to another competent authority when the transaction needs to be exchanged between the competent authorities."
)]
[IsoId("_YfqlMQxPEe6IZ4NJLf_INA")]
[DisplayName("Financial Instrument Reporting Transaction Report V")]
public record FinancialInstrumentReportingTransactionReportV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.016.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgTxRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.016.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides the details of the reported securities transactions.
    /// </summary>
    [IsoId("_YfqlNQxPEe6IZ4NJLf_INA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ReportingTransactionType3Choice_ Transaction { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_YfrMQQxPEe6IZ4NJLf_INA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since FinancialInstrumentReportingTransactionReportV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingTransactionReportV03.
