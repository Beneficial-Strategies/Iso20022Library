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
/// This record is an implementation of the camt.042.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, such as a transfer agent, sends the FundDetailedEstimatedCashForecastReport message to the report user, such as an investment manager or pricing agent, to report the estimated cash incomings and outgoings, sorted by country, institution name or other criteria defined by the user of one or more share classes of an investment fund on one or more trade dates.
/// The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.
/// Usage
/// The FundDetailedEstimatedCashForecastReport is used to provide estimated cash movements, that is, it is sent prior to the cut-off time and/or the price valuation of the fund. The message contains incoming and outgoing cash flows that are estimated, that is, the price has not been applied. If the price is definitive, then the FundDetailedConfirmedCashForecastReport message must be used.
/// The message structure allows for the following uses:
/// -	to provide cash in and cash out amounts for a fund/sub fund and one or more share classes (a FundOrSubFundDetails sequence and one or more EstimatedFundCashForecastDetails sequences are used),
/// -	to provide cash in and cash out amounts for one or more share classes (one or more EstimatedFundCashForecastDetails sequences are used).
/// If the report is to provide estimated cash in and cash out for a fund/sub fund only and not for one or more share classes, then the FundEstimatedCashForecastReport message must be used.
/// The FundDetailedEstimatedCashForecastReport message is used to report cash movements in or out of a fund, organised by party, such as fund management company, country, currency or by some other criteria defined by the report provider. If the report is used to give the cash-in and cash-out for a party, then additional criteria, such as currency and country, can be specified.
/// In addition, the underlying transaction type for the cash-in or cash-out movement can be specified, as well as information about the cash movement&apos;s underlying orders, such as commission and charges.
/// </summary>
[Description(
    @"Scope|A report provider, such as a transfer agent, sends the FundDetailedEstimatedCashForecastReport message to the report user, such as an investment manager or pricing agent, to report the estimated cash incomings and outgoings, sorted by country, institution name or other criteria defined by the user of one or more share classes of an investment fund on one or more trade dates.|The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.|Usage|The FundDetailedEstimatedCashForecastReport is used to provide estimated cash movements, that is, it is sent prior to the cut-off time and/or the price valuation of the fund. The message contains incoming and outgoing cash flows that are estimated, that is, the price has not been applied. If the price is definitive, then the FundDetailedConfirmedCashForecastReport message must be used.|The message structure allows for the following uses:|-	to provide cash in and cash out amounts for a fund/sub fund and one or more share classes (a FundOrSubFundDetails sequence and one or more EstimatedFundCashForecastDetails sequences are used),|-	to provide cash in and cash out amounts for one or more share classes (one or more EstimatedFundCashForecastDetails sequences are used).|If the report is to provide estimated cash in and cash out for a fund/sub fund only and not for one or more share classes, then the FundEstimatedCashForecastReport message must be used.|The FundDetailedEstimatedCashForecastReport message is used to report cash movements in or out of a fund, organised by party, such as fund management company, country, currency or by some other criteria defined by the report provider. If the report is used to give the cash-in and cash-out for a party, then additional criteria, such as currency and country, can be specified.|In addition, the underlying transaction type for the cash-in or cash-out movement can be specified, as well as information about the cash movement's underlying orders, such as commission and charges."
)]
[IsoId("_IaBCkQasEeSrXeb3pHPmbg")]
[DisplayName("Fund Detailed Estimated Cash Forecast Report V")]
public record FundDetailedEstimatedCashForecastReportV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.042.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndDtldEstmtdCshFcstRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.042.001.04";

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
    [IsoId("_IaBClQasEeSrXeb3pHPmbg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_IaBClwasEeSrXeb3pHPmbg")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_IaBCmQasEeSrXeb3pHPmbg")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_IaBCmwasEeSrXeb3pHPmbg")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_IaBCnQasEeSrXeb3pHPmbg")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// Information about the fund/sub fund when the report either specifies cash flow for the fund/sub fund or for a share class of the fund/sub fund.
    /// </summary>
    [IsoId("_1HANcgcyEeSuMrNEGTimoA")]
    [DisplayName("Fund Or Sub Fund Details")]
    [IsoXmlTag("FndOrSubFndDtls")]
    public Fund3? FundOrSubFundDetails { get; init; }

    /// <summary>
    /// Information related to the estimated cash-in and cash-out flows for a specific trade date as a result of transactions in shares in an investment fund, for example, subscriptions, redemptions or switches. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.
    /// </summary>
    [IsoId("_IaBCnwasEeSrXeb3pHPmbg")]
    [DisplayName("Estimated Fund Cash Forecast Details")]
    [IsoXmlTag("EstmtdFndCshFcstDtls")]
    public required EstimatedFundCashForecast5 EstimatedFundCashForecastDetails { get; init; }

    /// <summary>
    /// Estimated net cash as a result of the cash-in and cash-out flows specified in the fund cash forecast details.
    /// </summary>
    [IsoId("_IaBCoQasEeSrXeb3pHPmbg")]
    [DisplayName("Consolidated Net Cash Forecast")]
    [IsoXmlTag("CnsltdNetCshFcst")]
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_IaBCowasEeSrXeb3pHPmbg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since FundDetailedEstimatedCashForecastReportV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundDetailedEstimatedCashForecastReportV04.
