// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Valuation details for the securities position.
/// </summary>
[IsoId("_h4b_UMYeEeiSF9q-coWegA")]
[DisplayName("Valuations Details")]
public record ValuationsDetails1
{
    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_1mKU0MvJEeiWUeUVHQmKaw")]
    [DisplayName("Market Price")]
    [IsoXmlTag("MktPric")]
    public Price7? MarketPrice { get; init; }

    /// <summary>
    /// Source of the price quotation.
    /// </summary>
    [IsoId("_AFnWQMvKEeiWUeUVHQmKaw")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification89? SourceOfPrice { get; init; }

    /// <summary>
    /// Date and time at which the financial instruments are to be delivered or received effectively (Effective Settlement Date and Time).
    /// </summary>
    [IsoId("_YtBAEM4KEeiirviLm7P0IA")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateAndDateTime2Choice_? SettlementDate { get; init; }

    /// <summary>
    /// Securities collateral position valuation amounts.
    /// </summary>
    [IsoId("_q4_dwM4JEeiirviLm7P0IA")]
    [DisplayName("Valuation Details Amount")]
    [IsoXmlTag("ValtnDtlsAmt")]
    public required CollateralAmount4 ValuationDetailsAmount { get; init; }

    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods for a given financial instrument.
    /// </summary>
    [IsoId("_A_yTsTYgEeuD7rm9md9zvg")]
    [DisplayName("Accrued Interest")]
    [IsoXmlTag("AcrdIntrst")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterest { get; init; }

    /// <summary>
    /// Price amount excluding the accrued interest for a given financial instrument.
    /// </summary>
    [IsoId("_MfnNATYgEeuD7rm9md9zvg")]
    [DisplayName("Clean Price")]
    [IsoXmlTag("CleanPric")]
    public ActiveOrHistoricCurrencyAndAmount? CleanPrice { get; init; }

    /// <summary>
    /// Valuation factors.
    /// </summary>
    [IsoId("_t-xx0DYoEeuD7rm9md9zvg")]
    [DisplayName("Valuation Factor Breakdown")]
    [IsoXmlTag("ValtnFctrBrkdwn")]
    public required ValuationFactorBreakdown1 ValuationFactorBreakdown { get; init; }

    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_jGmV8M39EeiirviLm7P0IA")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Number of days since the last pricing update.
    /// </summary>
    [IsoId("_QWBWYM3-EeiirviLm7P0IA")]
    [DisplayName("Quotation Age")]
    [IsoXmlTag("QtnAge")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? QuotationAge { get; init; }
}
