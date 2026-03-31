// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additionnal details related to the leg.
/// </summary>
[IsoId("_Na1yQQ8qEeSFHsNYty4C9Q")]
[DisplayName("Instrument Leg")]
public record InstrumentLeg6
{
    /// <summary>
    /// Coded list to specify the side of the trade leg.
    /// </summary>
    [IsoId("_fSM1YA8qEeSFHsNYty4C9Q")]
    [DisplayName("Leg Side")]
    [IsoXmlTag("LegSd")]
    public required Side1Code LegSide { get; init; }

    /// <summary>
    /// Specifies the date of settlement, in coded form.
    /// </summary>
    [IsoId("__p-20IaQEeSzIqahkBT6cQ")]
    [DisplayName("Leg Settlement Type")]
    [IsoXmlTag("LegSttlmTp")]
    public required SettlementDateCode LegSettlementType { get; init; }

    /// <summary>
    /// Specifies the date and time on which the trade will be settled.
    /// </summary>
    [IsoId("_vY7BUA8qEeSFHsNYty4C9Q")]
    [DisplayName("Leg Settlement Date")]
    [IsoXmlTag("LegSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime LegSettlementDate { get; init; }

    /// <summary>
    /// Execution price of trade leg.
    /// </summary>
    [IsoId("_2PdbUA8qEeSFHsNYty4C9Q")]
    [DisplayName("Leg Last Price")]
    [IsoXmlTag("LegLastPric")]
    public required ActiveCurrencyAnd13DecimalAmount LegLastPrice { get; init; }

    /// <summary>
    /// Settlement currency of trade leg, agreed by both sides of the trade.
    /// </summary>
    [IsoId("__f7hIA8qEeSFHsNYty4C9Q")]
    [DisplayName("Leg Settlement Currency")]
    [IsoXmlTag("LegSttlmCcy")]
    public required CurrencyCode LegSettlementCurrency { get; init; }

    /// <summary>
    /// Amount of trade leg in trading currency.
    /// </summary>
    [IsoId("_CxIzMA8rEeSFHsNYty4C9Q")]
    [DisplayName("Leg Order Quantity")]
    [IsoXmlTag("LegOrdrQty")]
    public required CurrencyAndAmount LegOrderQuantity { get; init; }

    /// <summary>
    /// Forward points added to last spot rate. May be a negative value. Expressed in decimal form.
    /// </summary>
    [IsoId("_cQ3uABF9EeSahYR-dAI4lQ")]
    [DisplayName("Leg Forward Points")]
    [IsoXmlTag("LegFwdPts")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber LegForwardPoints { get; init; }

    /// <summary>
    /// Used for the calculated quantity of the other side of the currency trade. Can be derived from leg order quantity and leg last price.
    /// </summary>
    [IsoId("_k8h2kBF9EeSahYR-dAI4lQ")]
    [DisplayName("Leg Calculated Counterparty Currency Last Quantity")]
    [IsoXmlTag("LegClctdCtrPtyCcyLastQty")]
    public required CurrencyAndAmount LegCalculatedCounterpartyCurrencyLastQuantity { get; init; }

    /// <summary>
    /// Measurement of the leg trade values in terms of a currency (for example, the amount of trade in US dollars).
    /// </summary>
    [IsoId("_s_18ACKwEeSdYc3boV3myw")]
    [DisplayName("Leg Risk Amount")]
    [IsoXmlTag("LegRskAmt")]
    public required ActiveCurrencyAndAmount LegRiskAmount { get; init; }

    /// <summary>
    /// Specifies the valuation rate used for the trade leg.
    /// </summary>
    [IsoId("_IF3X0BF-EeSahYR-dAI4lQ")]
    [DisplayName("Leg Valuation Rate")]
    [IsoXmlTag("LegValtnRate")]
    public required AgreedRate3 LegValuationRate { get; init; }

    /// <summary>
    /// Specifies the value date of leg spot transaction.
    /// </summary>
    [IsoId("_ZO4uQBF-EeSahYR-dAI4lQ")]
    [DisplayName("Leg Value Date")]
    [IsoXmlTag("LegValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate LegValueDate { get; init; }

    /// <summary>
    /// Currency trade is conducted.
    /// </summary>
    [IsoId("_bhg4MBF-EeSahYR-dAI4lQ")]
    [DisplayName("Leg Currency")]
    [IsoXmlTag("LegCcy")]
    public required CurrencyCode LegCurrency { get; init; }

    /// <summary>
    /// Symbol of the leg trade.
    /// </summary>
    [IsoId("_0OwKYEeqEeSMv54C-KRx9A")]
    [DisplayName("Leg Symbol")]
    [IsoXmlTag("LegSymb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text LegSymbol { get; init; }

    /// <summary>
    /// Security identification of the leg trade.
    /// </summary>
    [IsoId("_Hj3xAID7EeSQoe-8fZQlpA")]
    [DisplayName("Leg Security Identification")]
    [IsoXmlTag("LegSctyId")]
    public required SecurityIdentification18 LegSecurityIdentification { get; init; }
}
