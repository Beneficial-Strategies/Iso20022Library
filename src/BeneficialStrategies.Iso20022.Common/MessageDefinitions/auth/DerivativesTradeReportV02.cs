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
/// This record is an implementation of the auth.030.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DerivativesTradeReport is sent by the reporting entities to provide transaction data to the trade repositories (TRs) or by the trade repositories (TRs) to the competent authorities.
/// </summary>
[Description(
    @"The DerivativesTradeReport is sent by the reporting entities to provide transaction data to the trade repositories (TRs) or by the trade repositories (TRs) to the competent authorities."
)]
[IsoId("_6ULEkHg8Eeu3kecHd7QKUQ")]
[DisplayName("Derivatives Trade Report V")]
public record DerivativesTradeReportV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.030.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.030.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Header information related to metadata of report message.
    /// </summary>
    [IsoId("_6ULEkng8Eeu3kecHd7QKUQ")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public required TradeQueryHeader4 ReportHeader { get; init; }

    /// <summary>
    /// Data concerning the reporting trade.
    /// </summary>
    [IsoId("_6ULElHg8Eeu3kecHd7QKUQ")]
    [DisplayName("Trade Data")]
    [IsoXmlTag("TradData")]
    public required TradeData19Choice_ TradeData { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_6ULElng8Eeu3kecHd7QKUQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since DerivativesTradeReportV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DerivativesTradeReportV02.
