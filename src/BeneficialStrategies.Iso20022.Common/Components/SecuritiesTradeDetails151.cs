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
[IsoId("f28aa0a7-f8ff-493c-aea0-68916476c496")]
[DisplayName("Securities Trade Details151")]
public record SecuritiesTradeDetails151
{
    [IsoId("b8f36680-b7b8-40db-bfbf-474233b531f8")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    [IsoId("2145eae0-06ae-48b1-ba40-0c70018a9af8")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("27c9ae5f-1602-4fcd-b0b9-0f4df5233e55")]
    [DisplayName("Collateral Transaction Identification")]
    [IsoXmlTag("CollTxId")]
    public SimpleValueList<IsoMax35Text> CollateralTransactionIdentification { get; init; } = [];

    [IsoId("06f44ef4-cfb6-44eb-ab37-0052fcbc938c")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public SimpleValueList<IsoMax35Text> AccountOwnerTransactionIdentification { get; init; } = [];

    [IsoId("62d22c3a-9006-42d2-a925-aead90d2c21d")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    [IsoId("5172abad-8e02-4c4c-af17-778a5ad2869e")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    [IsoId("c04ddb75-b1da-4052-a902-777a13628389")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    [IsoId("5f1fb6ea-edb8-424d-b167-9f73778ab9b8")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice? TradeDate { get; init; }

    [IsoId("1afb9c18-fa8e-4743-9a2a-6ad77e4ef507")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate17Choice SettlementDate { get; init; }

    [IsoId("d937587e-bb42-4947-a5c9-8d137813aeb6")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price10? DealPrice { get; init; }

    [IsoId("a3f7ee66-ac41-423a-b626-8ac8f8c4652d")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    [IsoId("11a712d7-ceff-4e0a-98a9-e164d211f696")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition5Choice> TradeTransactionCondition { get; init; } = [];

    [IsoId("91f40eb3-b772-49c1-b8ff-8ed0381e6fc8")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice29Choice? TypeOfPrice { get; init; }
}
