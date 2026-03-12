// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.040.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, such as a transfer agent, sends the FundEstimatedCashForecastReport message to the report user, such as an investment manager, to report the estimated cash incomings and outgoings of one or more investment funds on one or more trade dates.
/// The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.
/// Usage
/// The FundEstimatedCashForecastReport is used to report estimated cash movements, i.e., it is sent prior to the cut-off time and/or the price valuation of the fund.
/// The FundEstimatedCashForecastReport contains incoming and outgoing cash flows that are estimated, i.e., the price has not been applied. If the price is definitive, then the FundConfirmedCashForecastReport message must be used.
/// This message allows the report provider to report estimated cash movements in or out of a fund, but does not allow the Sender to categorise these movements, for example by country, or to give details of the underlying orders, commission or charges. If the report provider wishes to give detailed information related to estimated cash movements, then the FundDetailedEstimatedCashForecastReport message must be used.
/// </summary>
[Description(@"Scope|A report provider, such as a transfer agent, sends the FundEstimatedCashForecastReport message to the report user, such as an investment manager, to report the estimated cash incomings and outgoings of one or more investment funds on one or more trade dates.|The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.|Usage|The FundEstimatedCashForecastReport is used to report estimated cash movements, i.e., it is sent prior to the cut-off time and/or the price valuation of the fund.|The FundEstimatedCashForecastReport contains incoming and outgoing cash flows that are estimated, i.e., the price has not been applied. If the price is definitive, then the FundConfirmedCashForecastReport message must be used.|This message allows the report provider to report estimated cash movements in or out of a fund, but does not allow the Sender to categorise these movements, for example by country, or to give details of the underlying orders, commission or charges. If the report provider wishes to give detailed information related to estimated cash movements, then the FundDetailedEstimatedCashForecastReport message must be used.")]
[IsoId("_eao2q9E-Ed-BzquC8wXy7w_-1220596512")]
[DisplayName("Fund Estimated Cash Forecast Report V")]
public partial record FundEstimatedCashForecastReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.040.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndEstmtdCshFcstRptV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_eao2rNE-Ed-BzquC8wXy7w_-483893780")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_eao2rdE-Ed-BzquC8wXy7w_164683431")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_eayAkNE-Ed-BzquC8wXy7w_175764938")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_eayAkdE-Ed-BzquC8wXy7w_178535315")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; } 
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_eayAktE-Ed-BzquC8wXy7w_-130954619")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; } 
    
    /// <summary>
    /// Information related to the estimated cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switch to/from a specified investment fund.
    /// </summary>
    [IsoId("_eayAk9E-Ed-BzquC8wXy7w_-23057057")]
    [DisplayName("Estimated Fund Cash Forecast Details")]
    [IsoXmlTag("EstmtdFndCshFcstDtls")]
    public required EstimatedFundCashForecast3 EstimatedFundCashForecastDetails { get; init; } 
    
    /// <summary>
    /// Estimated net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_eayAlNE-Ed-BzquC8wXy7w_263671934")]
    [DisplayName("Consolidated Net Cash Forecast")]
    [IsoXmlTag("CnsltdNetCshFcst")]
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_eayAldE-Ed-BzquC8wXy7w_-753498487")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since FundEstimatedCashForecastReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundEstimatedCashForecastReportV03.

