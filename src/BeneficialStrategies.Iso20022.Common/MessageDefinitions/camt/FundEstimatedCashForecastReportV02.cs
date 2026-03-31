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
/// This record is an implementation of the camt.040.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FundEstimatedCashForecastReport message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.
/// This message is used to report the estimated cash incomings and outgoings of one or more investment funds, on one or more trade dates. These cash movements may result from, for example, redemption, subscription, switch transactions or dividends.
/// Usage
/// The FundEstimatedCashForecastReport message is used to report estimated cash movements, i.e., it is sent prior to the cutoff time and/or the price valuation of the fund.
/// </summary>
[Description(
    @"Scope|The FundEstimatedCashForecastReport message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.|This message is used to report the estimated cash incomings and outgoings of one or more investment funds, on one or more trade dates. These cash movements may result from, for example, redemption, subscription, switch transactions or dividends.|Usage|The FundEstimatedCashForecastReport message is used to report estimated cash movements, i.e., it is sent prior to the cutoff time and/or the price valuation of the fund."
)]
[IsoId("_d6JYtdE-Ed-BzquC8wXy7w_78558760")]
[DisplayName("Fund Estimated Cash Forecast Report V")]
public record FundEstimatedCashForecastReportV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.040.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.040.001.02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_d6JYttE-Ed-BzquC8wXy7w_-203432164")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_d6JYt9E-Ed-BzquC8wXy7w_-602392790")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_d6JYuNE-Ed-BzquC8wXy7w_-506346429")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// Information related to the estimated cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switch to/from a specified investment fund.
    /// </summary>
    [IsoId("_d6JYudE-Ed-BzquC8wXy7w_1685167439")]
    [DisplayName("Estimated Fund Cash Forecast Details")]
    [IsoXmlTag("EstmtdFndCshFcstDtls")]
    public required EstimatedFundCashForecast1 EstimatedFundCashForecastDetails { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_d6JYutE-Ed-BzquC8wXy7w_328515513")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since FundEstimatedCashForecastReportV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundEstimatedCashForecastReportV02.
