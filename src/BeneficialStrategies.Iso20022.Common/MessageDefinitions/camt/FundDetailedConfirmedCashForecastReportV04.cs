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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.043.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, such as a transfer agent, sends the FundDetailedConfirmedCashForecastReport message to the report user, such as an investment manager or pricing agent, to report the confirmed cash incomings and outgoings, sorted by country, institution name or other criteria defined by the user of one or more share classes of an investment fund on one or more trade dates.
/// The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.
/// Usage
/// The FundDetailedConfirmedCashForecastReport is used to provide definitive cash movements, that is, it is sent after the cut-off time and/or the price valuation of the fund.
/// If the price is not yet definitive, then the FundDetailedEstimatedCashForecastReport message must be used.
/// The message structure allows for the following uses:
/// -	to provide cash in and cash out amounts for a fund/sub fund and one or more share classes (a FundOrSubFundDetails sequence and one or FundCashForecastDetails sequences are used),
/// -	to provide cash in and cash out amounts for one or more share classes (one or more FundCashForecastDetails sequences are used).
/// If the report is to provide cash in and cash out for a fund/sub fund only and not for one or more share classes, then the FundConfirmedCashForecastReport message must be used.
/// The FundDetailedConfirmedCashForecastReport message is used to report cash movements in or out of a fund, organised by party, such as fund management company, country, currency or by some other criteria defined by the report provider. If the report is used to given the cash-in and cash-out for a party, then additional criteria, such as currency and country, can be specified.
/// In addition, the underlying transaction type for the cash-in or cash-out movement can be specified, as well as information about the cash movement&apos;s underlying orders, such as commission and charges.
/// </summary>
[Description(
    @"Scope|A report provider, such as a transfer agent, sends the FundDetailedConfirmedCashForecastReport message to the report user, such as an investment manager or pricing agent, to report the confirmed cash incomings and outgoings, sorted by country, institution name or other criteria defined by the user of one or more share classes of an investment fund on one or more trade dates.|The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.|Usage|The FundDetailedConfirmedCashForecastReport is used to provide definitive cash movements, that is, it is sent after the cut-off time and/or the price valuation of the fund. |If the price is not yet definitive, then the FundDetailedEstimatedCashForecastReport message must be used.|The message structure allows for the following uses:|-	to provide cash in and cash out amounts for a fund/sub fund and one or more share classes (a FundOrSubFundDetails sequence and one or FundCashForecastDetails sequences are used),|-	to provide cash in and cash out amounts for one or more share classes (one or more FundCashForecastDetails sequences are used).|If the report is to provide cash in and cash out for a fund/sub fund only and not for one or more share classes, then the FundConfirmedCashForecastReport message must be used.|The FundDetailedConfirmedCashForecastReport message is used to report cash movements in or out of a fund, organised by party, such as fund management company, country, currency or by some other criteria defined by the report provider. If the report is used to given the cash-in and cash-out for a party, then additional criteria, such as currency and country, can be specified.|In addition, the underlying transaction type for the cash-in or cash-out movement can be specified, as well as information about the cash movement's underlying orders, such as commission and charges."
)]
[IsoId("_LgMJUQasEeSrXeb3pHPmbg")]
[DisplayName("Fund Detailed Confirmed Cash Forecast Report V")]
public record FundDetailedConfirmedCashForecastReportV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.043.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndDtldConfdCshFcstRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.043.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_LgMJVQasEeSrXeb3pHPmbg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_LgMJVwasEeSrXeb3pHPmbg")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_LgMJWQasEeSrXeb3pHPmbg")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_LgMJWwasEeSrXeb3pHPmbg")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_LgMJXQasEeSrXeb3pHPmbg")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// Information about the fund/sub fund when the report either specifies cash flow for the fund/sub fund or for a share class of the fund/sub fund.
    /// </summary>
    [IsoId("_WS7C8Qc3EeSyIPzOZ6VzBQ")]
    [DisplayName("Fund Or Sub Fund Details")]
    [IsoXmlTag("FndOrSubFndDtls")]
    public Fund4? FundOrSubFundDetails { get; init; }

    /// <summary>
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of transactions in shares in an investment fund, for example, subscriptions, redemptions or switches. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.
    /// </summary>
    [IsoId("_LgMJXwasEeSrXeb3pHPmbg")]
    [DisplayName("Fund Cash Forecast Details")]
    [IsoXmlTag("FndCshFcstDtls")]
    public required FundCashForecast6 FundCashForecastDetails { get; init; }

    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified in the fund cash forecast details.
    /// </summary>
    [IsoId("_LgMJYQasEeSrXeb3pHPmbg")]
    [DisplayName("Consolidated Net Cash Forecast")]
    [IsoXmlTag("CnsltdNetCshFcst")]
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_LgMJYwasEeSrXeb3pHPmbg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since FundDetailedConfirmedCashForecastReportV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundDetailedConfirmedCashForecastReportV04.
