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
[IsoId("8dd9d4b4-5ee6-42a4-92e7-950791d2b6de")]
[DisplayName("Securities Trade Details149")]
public record SecuritiesTradeDetails149
{
    [IsoId("aa9a05d7-2718-4a91-9d30-ed617a4bdc2b")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    [IsoId("f6f2dd1c-1b12-4710-8c06-91aecba194d9")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("298f63ab-08b7-4a4b-951c-a09a6ae09949")]
    [DisplayName("Collateral Transaction Identification")]
    [IsoXmlTag("CollTxId")]
    public SimpleValueList<IsoMax35Text> CollateralTransactionIdentification { get; init; } = [];

    [IsoId("6d200580-cdef-48c9-9f11-96c0b3dacf20")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    [IsoId("0c3139f7-d954-495d-84e0-6585005a1e95")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    [IsoId("bde1642b-02c9-4837-94cb-beffad14fad2")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice? TradeDate { get; init; }

    [IsoId("1f0fa966-eebe-46f3-818b-8e7baeacd364")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate17Choice SettlementDate { get; init; }

    [IsoId("a79f61e7-d9c4-4c01-ae51-c4d9d3ee048e")]
    [DisplayName("Late Delivery Date")]
    [IsoXmlTag("LateDlvryDt")]
    public DateAndDateTime2Choice? LateDeliveryDate { get; init; }

    [IsoId("c7490ed3-6116-49cf-b1d5-c299bbd30795")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price10? DealPrice { get; init; }

    [IsoId("f983155d-0ed8-472c-9a26-8e3f0eb39c30")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    [IsoId("e65483e9-57a3-4933-84c1-d862f89a5533")]
    [DisplayName("Opening Closing")]
    [IsoXmlTag("OpngClsg")]
    public OpeningClosing3Choice? OpeningClosing { get; init; }

    [IsoId("1e063227-5188-4029-9d1b-9e3b19dbd069")]
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public ValueList<Reporting6Choice> Reporting { get; init; } = [];

    [IsoId("de2e8159-6690-4f49-9337-86ca0eae4542")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition5Choice> TradeTransactionCondition { get; init; } = [];

    [IsoId("1a0030ec-c35b-4133-8b34-fa84a97f7808")]
    [DisplayName("Investor Capacity")]
    [IsoXmlTag("InvstrCpcty")]
    public InvestorCapacity4Choice? InvestorCapacity { get; init; }

    [IsoId("29ae03b9-33df-4b92-acc1-6cd6eaf9bc31")]
    [DisplayName("Trade Originator Role")]
    [IsoXmlTag("TradOrgtrRole")]
    public TradeOriginator3Choice? TradeOriginatorRole { get; init; }

    [IsoId("c79b42b9-eada-4873-ae6e-b2bd551c5d3b")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice29Choice? TypeOfPrice { get; init; }

    [IsoId("6ab8b8a3-e699-4da2-af94-3b8a5660bd9b")]
    [DisplayName("Currency To Buy Or Sell")]
    [IsoXmlTag("CcyToBuyOrSell")]
    public CurrencyToBuyOrSell1Choice? CurrencyToBuyOrSell { get; init; }

    [IsoId("5d5d4d88-18fd-41b7-a445-b298e9b700e8")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus27Choice? MatchingStatus { get; init; }

    [IsoId("6dd816d5-43a7-46be-ab2f-c4dea27d8693")]
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public AffirmationStatus8Choice? AffirmationStatus { get; init; }

    [IsoId("f0011612-ae0e-4a2f-9d51-aaf09c09b9d7")]
    [DisplayName("FX Additional Details")]
    [IsoXmlTag("FxAddtlDtls")]
    public IsoMax350Text? FXAdditionalDetails { get; init; }

    [IsoId("0ad505c4-d883-4787-bda3-1b4cdd6405da")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }
}
