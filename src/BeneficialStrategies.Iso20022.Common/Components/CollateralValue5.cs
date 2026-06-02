// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the collateral reference data.
/// </summary>
[IsoId("_1PMM0aX9EeynsLtPxJMJTQ")]
[DisplayName("Collateral Value5")]
public record CollateralValue5
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_1WMMsaX9EeynsLtPxJMJTQ")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification19 SecurityIdentification { get; init; }

    /// <summary>
    /// Valuation date for the price.
    /// </summary>
    [IsoId("_1WMMs6X9EeynsLtPxJMJTQ")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    public required IsoISODate ValuationDate { get; init; }

    /// <summary>
    /// Provides details of the currency of the valuation.
    /// </summary>
    [IsoId("_1WMMtaX9EeynsLtPxJMJTQ")]
    [DisplayName("Valuation Currency")]
    [IsoXmlTag("ValtnCcy")]
    public ActiveCurrencyCode? ValuationCurrency { get; init; }

    /// <summary>
    /// Provides details of the price provided for the security.
    /// </summary>
    [IsoId("_1WMMt6X9EeynsLtPxJMJTQ")]
    [DisplayName("Valuation Price")]
    [IsoXmlTag("ValtnPric")]
    public required AmountOrCoefficientPrice2Choice ValuationPrice { get; init; }

    /// <summary>
    /// Price of the security as of the valuation date in the collateral valuation currency where there is a close link between the credit consumer and the security provided as collateral.
    /// </summary>
    [IsoId("_1WMMuaX9EeynsLtPxJMJTQ")]
    [DisplayName("Valuation Close Link Price")]
    [IsoXmlTag("ValtnClsLkPric")]
    public AmountOrCoefficientPrice2Choice? ValuationCloseLinkPrice { get; init; }

    /// <summary>
    /// Price excluding the accrued interest.
    /// </summary>
    [IsoId("_1WMMu6X9EeynsLtPxJMJTQ")]
    [DisplayName("Clean Price")]
    [IsoXmlTag("CleanPric")]
    public PriceRateOrAmount6Choice? CleanPrice { get; init; }

    /// <summary>
    /// Amount of money or rate accrued interest computed in the case of interest bearing financial instruments.
    /// </summary>
    [IsoId("_1WMMvaX9EeynsLtPxJMJTQ")]
    [DisplayName("Accrued Interest")]
    [IsoXmlTag("AcrdIntrst")]
    public PriceRateOrAmount6Choice? AccruedInterest { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_1WMMv6X9EeynsLtPxJMJTQ")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    public IsoPercentageRate? Haircut { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage in case of close links.
    /// </summary>
    [IsoId("_1WMMwaX9EeynsLtPxJMJTQ")]
    [DisplayName("Close Link Haircut")]
    [IsoXmlTag("ClsLkHrcut")]
    public IsoPercentageRate? CloseLinkHaircut { get; init; }

    /// <summary>
    /// Percentage that applies to price of the securities following a redemption.
    /// </summary>
    [IsoId("_1WMMw6X9EeynsLtPxJMJTQ")]
    [DisplayName("Pool Factor")]
    [IsoXmlTag("PoolFctr")]
    public IsoPercentageRate? PoolFactor { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_1WMMxaX9EeynsLtPxJMJTQ")]
    [DisplayName("Foreign Exchange")]
    [IsoXmlTag("FX")]
    public ForeignExchangeTerms23? ForeignExchange { get; init; }
}
