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

namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// This record is an implementation of the fxtr.032.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeCaptureReportRequest message is sent by a trading member to the trading system for inquiry of trade capture report.
/// Usage
/// The request is sent by the trading member to the trading system to inquire trade capture report.
/// Note a capture request could be rejected.
/// </summary>
[Description(
    @"Scope|The ForeignExchangeTradeCaptureReportRequest message is sent by a trading member to the trading system for inquiry of trade capture report. |Usage|The request is sent by the trading member to the trading system to inquire trade capture report. |Note a capture request could be rejected."
)]
[IsoId("_KgkR8oHHEeSY3ulMDfpmvA")]
[DisplayName("Foreign Exchange Trade Capture Report Request V")]
public record ForeignExchangeTradeCaptureReportRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.032.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradCaptrRptReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the capture request message.
    /// </summary>
    [IsoId("_VzU_oIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query Request Identification")]
    [IsoXmlTag("QryReqId")]
    public required MessageIdentification1 QueryRequestIdentification { get; init; }

    /// <summary>
    /// Range of the trade for the inquire.
    /// </summary>
    [IsoId("_bTutIIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query Order Status")]
    [IsoXmlTag("QryOrdrSts")]
    public required QueryOrderStatus1Code QueryOrderStatus { get; init; }

    /// <summary>
    /// Specifies the inquiry type of the data.
    /// </summary>
    [IsoId("_JCuBAKbAEeSxuMLA5o46jQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryDataType1Code? QueryType { get; init; }

    /// <summary>
    /// Start number in request result.
    /// </summary>
    [IsoId("_e_2ZkIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query Start Number")]
    [IsoXmlTag("QryStartNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public required IsoMax35NumericText QueryStartNumber { get; init; }

    /// <summary>
    /// Indicates whether the request is query trade for a period of time.
    /// </summary>
    [IsoId("_iSHbkIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query By Period")]
    [IsoXmlTag("QryByPrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator QueryByPeriod { get; init; }

    /// <summary>
    /// Period of the inquiry.
    /// </summary>
    [IsoId("_uLTQEIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query Period")]
    [IsoXmlTag("QryPrd")]
    public Period4? QueryPeriod { get; init; }

    /// <summary>
    /// States the identification of the trade which the trading member inquires.
    /// </summary>
    [IsoId("_r0UKkIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query Trade Identification")]
    [IsoXmlTag("QryTradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryTradeIdentification { get; init; }

    /// <summary>
    /// Identifies the end of the request result.
    /// </summary>
    [IsoId("_BOrPMKa7EeSxuMLA5o46jQ")]
    [DisplayName("Query End Identification")]
    [IsoXmlTag("QryEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryEndIdentification { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_a2e2MKHhEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }

    /// <summary>
    /// Largest number of request result.
    /// </summary>
    [IsoId("_eP9iMKa9EeSxuMLA5o46jQ")]
    [DisplayName("Query Page Size")]
    [IsoXmlTag("QryPgSz")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? QueryPageSize { get; init; }

    /// <summary>
    /// Specifies the inquiry value of the parameter.
    /// </summary>
    [IsoId("_Ex-IEKbBEeSxuMLA5o46jQ")]
    [DisplayName("Query Parameter Value")]
    [IsoXmlTag("QryParamVal")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryParameterValue { get; init; }
}

// Since ForeignExchangeTradeCaptureReportRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeCaptureReportRequestV01.
