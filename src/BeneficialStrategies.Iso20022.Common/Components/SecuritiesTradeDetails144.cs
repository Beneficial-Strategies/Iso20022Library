// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities Trade Details144.
/// </summary>
[IsoId("_HtRJ0YYcEe-Pv9KR9bv9IA")]
[DisplayName("Securities Trade Details144")]
public record SecuritiesTradeDetails144
{
    /// <summary>
    /// Account Owner Transaction Identification.
    /// </summary>
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public ValueList<Max35Text> AccountOwnerTransactionIdentification { get; init; } = [];

    /// <summary>
    /// Collateral Transaction Identification.
    /// </summary>
    [DisplayName("Collateral Transaction Identification")]
    [IsoXmlTag("CollTxId")]
    public ValueList<Max35Text> CollateralTransactionIdentification { get; init; } = [];

    /// <summary>
    /// Deal Price.
    /// </summary>
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price10? DealPrice { get; init; }

    /// <summary>
    /// Number Of Days Accrued.
    /// </summary>
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public Max3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Place Of Clearing.
    /// </summary>
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    /// <summary>
    /// Place Of Trade.
    /// </summary>
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    /// <summary>
    /// Processor Transaction Identification.
    /// </summary>
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public Max35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate17Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Trade Date.
    /// </summary>
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    /// <summary>
    /// Trade Identification.
    /// </summary>
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public Max35Text? TradeIdentification { get; init; }

    /// <summary>
    /// Trade Transaction Condition.
    /// </summary>
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition5Choice_> TradeTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Type Of Price.
    /// </summary>
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; }

    /// <summary>
    /// Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public UTIIdentifier? UniqueTransactionIdentifier { get; init; }
}
