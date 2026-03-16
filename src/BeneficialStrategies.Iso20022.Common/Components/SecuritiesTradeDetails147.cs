// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities Trade Details147.
/// </summary>
[IsoId("_nwz3cYYfEe-Pv9KR9bv9IA")]
[DisplayName("Securities Trade Details147")]
public record SecuritiesTradeDetails147
{
    /// <summary>
    /// Affirmation Status.
    /// </summary>
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public AffirmationStatus8Choice_? AffirmationStatus { get; init; }

    /// <summary>
    /// Collateral Transaction Identification.
    /// </summary>
    [DisplayName("Collateral Transaction Identification")]
    [IsoXmlTag("CollTxId")]
    public ValueList<IsoMax35Text> CollateralTransactionIdentification { get; init; } = [];

    /// <summary>
    /// Currency To Buy Or Sell.
    /// </summary>
    [DisplayName("Currency To Buy Or Sell")]
    [IsoXmlTag("CcyToBuyOrSell")]
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; }

    /// <summary>
    /// Deal Price.
    /// </summary>
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price10? DealPrice { get; init; }

    /// <summary>
    /// FX Additional Details.
    /// </summary>
    [DisplayName("FX Additional Details")]
    [IsoXmlTag("FxAddtlDtls")]
    public IsoMax350Text? FXAdditionalDetails { get; init; }

    /// <summary>
    /// Investor Capacity.
    /// </summary>
    [DisplayName("Investor Capacity")]
    [IsoXmlTag("InvstrCpcty")]
    public InvestorCapacity4Choice_? InvestorCapacity { get; init; }

    /// <summary>
    /// Late Delivery Date.
    /// </summary>
    [DisplayName("Late Delivery Date")]
    [IsoXmlTag("LateDlvryDt")]
    public DateAndDateTime2Choice_? LateDeliveryDate { get; init; }

    /// <summary>
    /// Matching Status.
    /// </summary>
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus27Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Number Of Days Accrued.
    /// </summary>
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Opening Closing.
    /// </summary>
    [DisplayName("Opening Closing")]
    [IsoXmlTag("OpngClsg")]
    public OpeningClosing3Choice_? OpeningClosing { get; init; }

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
    /// Reporting.
    /// </summary>
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public ValueList<Reporting6Choice_> Reporting { get; init; } = [];

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public SettlementDate17Choice_? SettlementDate { get; init; }

    /// <summary>
    /// Settlement Instruction Processing Additional Details.
    /// </summary>
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }

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
    public IsoMax35Text? TradeIdentification { get; init; }

    /// <summary>
    /// Trade Originator Role.
    /// </summary>
    [DisplayName("Trade Originator Role")]
    [IsoXmlTag("TradOrgtrRole")]
    public TradeOriginator3Choice_? TradeOriginatorRole { get; init; }

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
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }
}
