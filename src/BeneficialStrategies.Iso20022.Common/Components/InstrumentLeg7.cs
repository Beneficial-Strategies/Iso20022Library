// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument Leg7.
/// </summary>
[IsoId("_pUzXoe3uEe6nAu63uIo75Q")]
[DisplayName("Instrument Leg7")]
public partial record InstrumentLeg7
{
    #nullable enable

    /// <summary>
    /// Leg Calculated Counterparty Currency Last Quantity.
    /// </summary>
    [DisplayName("Leg Calculated Counterparty Currency Last Quantity")]
    [IsoXmlTag("LegClctdCtrPtyCcyLastQty")]
    public required ActiveCurrencyAndAmount LegCalculatedCounterpartyCurrencyLastQuantity { get; init; } 

    /// <summary>
    /// Leg Currency.
    /// </summary>
    [DisplayName("Leg Currency")]
    [IsoXmlTag("LegCcy")]
    public required ActiveCurrencyCode LegCurrency { get; init; } 

    /// <summary>
    /// Leg Forward Points.
    /// </summary>
    [DisplayName("Leg Forward Points")]
    [IsoXmlTag("LegFwdPts")]
    public required IsoDecimalNumber LegForwardPoints { get; init; } 

    /// <summary>
    /// Leg Last Price.
    /// </summary>
    [DisplayName("Leg Last Price")]
    [IsoXmlTag("LegLastPric")]
    public required ActiveCurrencyAnd13DecimalAmount LegLastPrice { get; init; } 

    /// <summary>
    /// Leg Order Quantity.
    /// </summary>
    [DisplayName("Leg Order Quantity")]
    [IsoXmlTag("LegOrdrQty")]
    public required ActiveCurrencyAndAmount LegOrderQuantity { get; init; } 

    /// <summary>
    /// Leg Risk Amount.
    /// </summary>
    [DisplayName("Leg Risk Amount")]
    [IsoXmlTag("LegRskAmt")]
    public required ActiveCurrencyAndAmount LegRiskAmount { get; init; } 

    /// <summary>
    /// Leg Security Identification.
    /// </summary>
    [DisplayName("Leg Security Identification")]
    [IsoXmlTag("LegSctyId")]
    public required SecurityIdentification18 LegSecurityIdentification { get; init; } 

    /// <summary>
    /// Leg Settlement Currency.
    /// </summary>
    [DisplayName("Leg Settlement Currency")]
    [IsoXmlTag("LegSttlmCcy")]
    public required ActiveCurrencyCode LegSettlementCurrency { get; init; } 

    /// <summary>
    /// Leg Settlement Date.
    /// </summary>
    [DisplayName("Leg Settlement Date")]
    [IsoXmlTag("LegSttlmDt")]
    public required IsoISODateTime LegSettlementDate { get; init; } 

    /// <summary>
    /// Leg Settlement Type.
    /// </summary>
    [DisplayName("Leg Settlement Type")]
    [IsoXmlTag("LegSttlmTp")]
    public required SettlementDate8Code LegSettlementType { get; init; } 

    /// <summary>
    /// Leg Side.
    /// </summary>
    [DisplayName("Leg Side")]
    [IsoXmlTag("LegSd")]
    public required Side1Code LegSide { get; init; } 

    /// <summary>
    /// Leg Symbol.
    /// </summary>
    [DisplayName("Leg Symbol")]
    [IsoXmlTag("LegSymb")]
    public required IsoMax35Text LegSymbol { get; init; } 

    /// <summary>
    /// Leg Valuation Rate.
    /// </summary>
    [DisplayName("Leg Valuation Rate")]
    [IsoXmlTag("LegValtnRate")]
    public required AgreedRate3 LegValuationRate { get; init; } 

    /// <summary>
    /// Leg Value Date.
    /// </summary>
    [DisplayName("Leg Value Date")]
    [IsoXmlTag("LegValDt")]
    public required IsoISODate LegValueDate { get; init; } 

    
    #nullable disable
    
}
