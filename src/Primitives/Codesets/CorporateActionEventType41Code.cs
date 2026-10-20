// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vIwXwDr9EfCtSNLP91pXxg")]
[Description(@"Specifies the corporate action event type.")]
[DerivedFrom(typeof(CorporateActionEventTypeV7Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CorporateActionEventType41Code>))]
public enum CorporateActionEventType41Code
{
    /// <summary>
    /// Accumulation.
    /// Encoded/decoded by serializers as &quot;ACCU&quot;.
    /// </summary>
    [EnumMember(Value = "ACCU")]
    [IsoId("f7838deb-a9bf-4fa2-90bd-89c233919358")]
    [Description(@"Accumulation.")]
    Accumulation = CorporateActionEventTypeV7Code.Accumulation,

    /// <summary>
    /// Bonus issue: bonus shares are issued to holders at no cost.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("498a49ef-516a-42b8-87a9-b3b7cefe44e5")]
    [Description(@"Bonus issue: bonus shares are issued to holders at no cost.")]
    BonusIssue = CorporateActionEventTypeV7Code.BonusIssue,

    /// <summary>
    /// Put redemption.
    /// Encoded/decoded by serializers as &quot;BPUT&quot;.
    /// </summary>
    [EnumMember(Value = "BPUT")]
    [IsoId("8abbc0c2-52c7-4c83-80f5-ad01d46895a7")]
    [Description(@"Put redemption.")]
    PutRedemption = CorporateActionEventTypeV7Code.PutRedemption,

    /// <summary>
    /// Repurchase offer.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("72334ebd-2bfa-4f7a-aede-3d26f3673654")]
    [Description(@"Repurchase offer.")]
    RepurchaseOffer = CorporateActionEventTypeV7Code.RepurchaseOffer,

    /// <summary>
    /// Capital distribution.
    /// Encoded/decoded by serializers as &quot;CAPD&quot;.
    /// </summary>
    [EnumMember(Value = "CAPD")]
    [IsoId("59d991dd-95af-4c5e-a01c-2854116a10c1")]
    [Description(@"Capital distribution.")]
    CapitalDistribution = CorporateActionEventTypeV7Code.CapitalDistribution,

    /// <summary>
    /// Capital gains distribution.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("13c9a2e1-3d3c-48d9-8945-8a30aba9c96c")]
    [Description(@"Capital gains distribution.")]
    CapitalGainsDistribution = CorporateActionEventTypeV7Code.CapitalGainsDistribution,

    /// <summary>
    /// Capitalisation.
    /// Encoded/decoded by serializers as &quot;CAPI&quot;.
    /// </summary>
    [EnumMember(Value = "CAPI")]
    [IsoId("37cfcfe0-5022-4443-869b-c358d3506004")]
    [Description(@"Capitalisation.")]
    Capitalisation = CorporateActionEventTypeV7Code.Capitalisation,

    /// <summary>
    /// Consent.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("90379395-5700-4232-bb51-8787a9c52b13")]
    [Description(@"Consent.")]
    Consent = CorporateActionEventTypeV7Code.Consent,

    /// <summary>
    /// Conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("0f48fe93-6ea4-4bd8-ac87-cf40947eee8f")]
    [Description(@"Conversion.")]
    Conversion = CorporateActionEventTypeV7Code.Conversion,

    /// <summary>
    /// Company option.
    /// Encoded/decoded by serializers as &quot;COOP&quot;.
    /// </summary>
    [EnumMember(Value = "COOP")]
    [IsoId("38911c55-4a64-421d-a21b-08d9e3f7f38d")]
    [Description(@"Company option.")]
    CompanyOption = CorporateActionEventTypeV7Code.CompanyOption,

    /// <summary>
    /// Drawing.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("de6ef064-a1ea-43ab-a2ea-40da07ba34f8")]
    [Description(@"Drawing.")]
    Drawing = CorporateActionEventTypeV7Code.Drawing,

    /// <summary>
    /// Dividend reinvestment.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("be18229e-5c91-464e-84ba-98169bc935d4")]
    [Description(@"Dividend reinvestment.")]
    DividendReinvestment = CorporateActionEventTypeV7Code.DividendReinvestment,

    /// <summary>
    /// Cash dividend.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("ffeba475-b8a7-4082-b80a-e151c209531f")]
    [Description(@"Cash dividend.")]
    CashDividend = CorporateActionEventTypeV7Code.CashDividend,

    /// <summary>
    /// Dividend option.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("32de9f8e-cbb1-436b-90bd-ec827c1fcf81")]
    [Description(@"Dividend option.")]
    DividendOption = CorporateActionEventTypeV7Code.DividendOption,

    /// <summary>
    /// Dutch auction.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("24a13933-ec5c-4260-8a2c-2300cca35053")]
    [Description(@"Dutch auction.")]
    DutchAuction = CorporateActionEventTypeV7Code.DutchAuction,

    /// <summary>
    /// Exchange.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("5d17d65a-7523-44ee-bd8e-7e2f00c1afe3")]
    [Description(@"Exchange.")]
    Exchange = CorporateActionEventTypeV7Code.Exchange,

    /// <summary>
    /// Call on intermediate securities.
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("f23723f5-1a6d-4415-8f44-9b488c9d6682")]
    [Description(@"Call on intermediate securities.")]
    CallOnIntermediateSecurities = CorporateActionEventTypeV7Code.CallOnIntermediateSecurities,

    /// <summary>
    /// Maturity extension.
    /// Encoded/decoded by serializers as &quot;EXTM&quot;.
    /// </summary>
    [EnumMember(Value = "EXTM")]
    [IsoId("6110ec6a-4df9-46f2-9d24-3a5d12f92f61")]
    [Description(@"Maturity extension.")]
    MaturityExtension = CorporateActionEventTypeV7Code.MaturityExtension,

    /// <summary>
    /// Interest payment.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("56f4d366-4899-430e-a509-7846c8813568")]
    [Description(@"Interest payment.")]
    InterestPayment = CorporateActionEventTypeV7Code.InterestPayment,

    /// <summary>
    /// Full call.
    /// Encoded/decoded by serializers as &quot;MCAL&quot;.
    /// </summary>
    [EnumMember(Value = "MCAL")]
    [IsoId("fecccbb8-7a7d-4c6d-8ec9-4f477b487370")]
    [Description(@"Full call.")]
    FullCall = CorporateActionEventTypeV7Code.FullCall,

    /// <summary>
    /// Merger.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("12fa7465-e53a-41f3-ae7c-fdaa33924979")]
    [Description(@"Merger.")]
    Merger = CorporateActionEventTypeV7Code.Merger,

    /// <summary>
    /// Odd lot sale/purchase.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("fcbe3bb2-ae9a-42a6-8e1d-8ba7b84f3cd7")]
    [Description(@"Odd lot sale/purchase.")]
    OddLotSalePurchase = CorporateActionEventTypeV7Code.OddLotSalePurchase,

    /// <summary>
    /// Other event.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("410636c1-1ad6-46fd-af6c-dfa294fa0b2f")]
    [Description(@"Other event.")]
    OtherEvent = CorporateActionEventTypeV7Code.OtherEvent,

    /// <summary>
    /// Partial redemption without pool factor reduction.
    /// Encoded/decoded by serializers as &quot;PCAL&quot;.
    /// </summary>
    [EnumMember(Value = "PCAL")]
    [IsoId("ee0288e5-5b2f-4590-bca3-3d01fdc9e593")]
    [Description(@"Partial redemption without pool factor reduction.")]
    PartialRedemptionWithoutPoolFactorReduction = CorporateActionEventTypeV7Code.PartialRedemptionWithoutPoolFactorReduction,

    /// <summary>
    /// Pay in kind.
    /// Encoded/decoded by serializers as &quot;PINK&quot;.
    /// </summary>
    [EnumMember(Value = "PINK")]
    [IsoId("99ebc332-59e4-461b-a198-1e109fc9c82a")]
    [Description(@"Pay in kind.")]
    PayInKind = CorporateActionEventTypeV7Code.PayInKind,

    /// <summary>
    /// Partial redemption with pool factor reduction.
    /// Encoded/decoded by serializers as &quot;PRED&quot;.
    /// </summary>
    [EnumMember(Value = "PRED")]
    [IsoId("419b06cd-b46e-4ad5-bb1b-9b07defcf0c0")]
    [Description(@"Partial redemption with pool factor reduction.")]
    PartialRedemptionWithPoolFactorReduction = CorporateActionEventTypeV7Code.PartialRedemptionWithPoolFactorReduction,

    /// <summary>
    /// Priority issue.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("16e26d96-398d-4fbc-ac44-fd7c1925bf01")]
    [Description(@"Priority issue.")]
    PriorityIssue = CorporateActionEventTypeV7Code.PriorityIssue,

    /// <summary>
    /// Redenomination.
    /// Encoded/decoded by serializers as &quot;REDO&quot;.
    /// </summary>
    [EnumMember(Value = "REDO")]
    [IsoId("86587910-f600-4a19-9925-650b84c23380")]
    [Description(@"Redenomination.")]
    Redenomination = CorporateActionEventTypeV7Code.Redenomination,

    /// <summary>
    /// Final maturity.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("ab7c16e5-a9c8-4995-913d-f6dc241f85a5")]
    [Description(@"Final maturity.")]
    FinalMaturity = CorporateActionEventTypeV7Code.FinalMaturity,

    /// <summary>
    /// Remarketing agreement.
    /// Encoded/decoded by serializers as &quot;REMK&quot;.
    /// </summary>
    [EnumMember(Value = "REMK")]
    [IsoId("9b25f47e-ff67-450a-8558-f0f2063bc347")]
    [Description(@"Remarketing agreement.")]
    RemarketingAgreement = CorporateActionEventTypeV7Code.RemarketingAgreement,

    /// <summary>
    /// Shares premium dividend.
    /// Encoded/decoded by serializers as &quot;SHPR&quot;.
    /// </summary>
    [EnumMember(Value = "SHPR")]
    [IsoId("62c426a5-6fe4-4fac-965c-36483669d584")]
    [Description(@"Shares premium dividend.")]
    SharesPremiumDividend = CorporateActionEventTypeV7Code.SharesPremiumDividend,

    /// <summary>
    /// Spin-off.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("b35a5f5d-0552-4194-9eb1-81ef6a5bd2ce")]
    [Description(@"Spin-off.")]
    SpinOff = CorporateActionEventTypeV7Code.SpinOff,

    /// <summary>
    /// Stock split.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("f3454d1d-b11f-4d37-93d7-3db5424f1e50")]
    [Description(@"Stock split.")]
    StockSplit = CorporateActionEventTypeV7Code.StockSplit,

    /// <summary>
    /// Reverse stock split.
    /// Encoded/decoded by serializers as &quot;SPLR&quot;.
    /// </summary>
    [EnumMember(Value = "SPLR")]
    [IsoId("f8024f0d-475f-4540-9a15-fd10e8937d53")]
    [Description(@"Reverse stock split.")]
    ReverseStockSplit = CorporateActionEventTypeV7Code.ReverseStockSplit,

    /// <summary>
    /// Tender.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("7d9d7d5a-c335-451c-97b9-958c2c436a8c")]
    [Description(@"Tender.")]
    Tender = CorporateActionEventTypeV7Code.Tender,

    /// <summary>
    /// Warrant exercise.
    /// Encoded/decoded by serializers as &quot;EXWA&quot;.
    /// </summary>
    [EnumMember(Value = "EXWA")]
    [IsoId("a2c04eb4-dbfb-4206-b6e4-200d47d8ec26")]
    [Description(@"Warrant exercise.")]
    WarrantExercise = CorporateActionEventTypeV7Code.WarrantExercise,
}
