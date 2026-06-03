// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities trade.
/// </summary>
[IsoId("272bd6d0-6be3-42c3-ba65-f11794756d57")]
[DisplayName("Securities Trade Details153")]
public record SecuritiesTradeDetails153
{
    [IsoId("23746c72-dedd-4cf4-a4e3-1dd0eb831564")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    [IsoId("dcd036ea-cc06-479f-b2dc-d11cb0de1385")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("315a8cd9-125e-4f74-9b0e-1d4199e316d6")]
    [DisplayName("Collateral Transaction Identification")]
    [IsoXmlTag("CollTxId")]
    public SimpleValueList<IsoMax35Text> CollateralTransactionIdentification { get; init; } = [];

    [IsoId("0cc3525b-2995-42f5-8518-8c36363e0bea")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    [IsoId("cff5b1fb-0386-47e6-8325-f85cbf9b4b4c")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    [IsoId("d8b0a7e1-1d06-4558-9903-2d281bc19eca")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice? TradeDate { get; init; }

    [IsoId("9f5ec979-e07f-4410-bb6b-6d26f72bf0bf")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate17Choice SettlementDate { get; init; }

    [IsoId("94a327c6-20e2-4347-8c44-1a2a804cbfff")]
    [DisplayName("Late Delivery Date")]
    [IsoXmlTag("LateDlvryDt")]
    public DateAndDateTime2Choice? LateDeliveryDate { get; init; }

    [IsoId("47435c05-bb6b-49c4-971d-9fdcced363bf")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    [IsoId("2274f63e-adc6-43f5-84b2-5c3794d10595")]
    [DisplayName("Matched Status Time Stamp")]
    [IsoXmlTag("MtchdStsTmStmp")]
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; }

    [IsoId("b0d02c23-64bd-4c57-ba6b-988573288f37")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price10? DealPrice { get; init; }

    [IsoId("0cbd9ed1-38fb-4365-8098-c848e5c4bb85")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    [IsoId("5ad05750-bdb3-4790-af5f-f1fe2762331b")]
    [DisplayName("Opening Closing")]
    [IsoXmlTag("OpngClsg")]
    public OpeningClosing3Choice? OpeningClosing { get; init; }

    [IsoId("f983e916-5d13-4977-a1d9-222c48aca5fb")]
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public ValueList<Reporting6Choice> Reporting { get; init; } = [];

    [IsoId("0a60f0ce-3861-4aa8-9847-757a63370367")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition5Choice> TradeTransactionCondition { get; init; } = [];

    [IsoId("3563e54a-71d2-417c-8e87-b42b86015b9e")]
    [DisplayName("Investor Capacity")]
    [IsoXmlTag("InvstrCpcty")]
    public InvestorCapacity4Choice? InvestorCapacity { get; init; }

    [IsoId("367694ae-b128-4cc8-bd88-bdd4cc17827a")]
    [DisplayName("Trade Originator Role")]
    [IsoXmlTag("TradOrgtrRole")]
    public TradeOriginator3Choice? TradeOriginatorRole { get; init; }

    [IsoId("6e2daff2-d59b-403a-b04c-34d1e3d5628b")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice29Choice? TypeOfPrice { get; init; }

    [IsoId("16e27f0d-5c7e-4e41-bdde-365a80f70f7a")]
    [DisplayName("Currency To Buy Or Sell")]
    [IsoXmlTag("CcyToBuyOrSell")]
    public CurrencyToBuyOrSell1Choice? CurrencyToBuyOrSell { get; init; }

    [IsoId("9c4caa17-ab7a-4939-a22b-96dbe5775c51")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus27Choice? MatchingStatus { get; init; }

    [IsoId("b7ff82ab-ae85-4746-b605-2aff408b0e4a")]
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public AffirmationStatus8Choice? AffirmationStatus { get; init; }

    [IsoId("dc4274a0-02f6-4dfd-8ac8-fb1dfd7aee4d")]
    [DisplayName("FX Additional Details")]
    [IsoXmlTag("FxAddtlDtls")]
    public IsoMax350Text? FXAdditionalDetails { get; init; }

    [IsoId("46f558a6-8ba4-4c27-ab2d-eed308c60a42")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }
}
