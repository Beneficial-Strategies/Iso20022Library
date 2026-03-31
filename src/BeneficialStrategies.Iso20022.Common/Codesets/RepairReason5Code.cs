// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the securities financing instruction has a repair status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZuT2adp-Ed-ak6NoX_4Aeg_1118630481")]
[Description(@"Specifies the reason why the securities financing instruction has a repair status.")]
[DerivedFrom(typeof(RepairReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RepairReason5Code>))]
#endif
public enum RepairReason5Code
{
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_ZudAUNp-Ed-ak6NoX_4Aeg_-1531069380")]
    [Description(
        @"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch."
    )]
    ProcessingBatch = RepairReasonV2Code.ProcessingBatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ZudAUdp-Ed-ak6NoX_4Aeg_121558128")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateAction = RepairReasonV2Code.CorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZudAUtp-Ed-ak6NoX_4Aeg_-170399610")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RepairReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ZudAU9p-Ed-ak6NoX_4Aeg_7719062")]
    [Description(
        @"Impossible standing arrangements override instruction for the cash settlement system."
    )]
    ImpossibleCashSettlementSystem = RepairReasonV2Code.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZudAVNp-Ed-ak6NoX_4Aeg_1766825563")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate = RepairReasonV2Code.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ZudAVdp-Ed-ak6NoX_4Aeg_-875514225")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RepairReasonV2Code.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZudAVtp-Ed-ak6NoX_4Aeg_-1167471963")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmount = RepairReasonV2Code.SettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZudAV9p-Ed-ak6NoX_4Aeg_-989353291")]
    [Description(@"Unrecognised or invalid settlement quantity.")]
    Quantity = RepairReasonV2Code.Quantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZudAWNp-Ed-ak6NoX_4Aeg_769753210")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    Security = RepairReasonV2Code.Security, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ZudAWdp-Ed-ak6NoX_4Aeg_-1872586578")]
    [Description(@"Unrecognised or invalid trade date.")]
    TradeDate = RepairReasonV2Code.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_ZumxUNp-Ed-ak6NoX_4Aeg_2130422980")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReference = RepairReasonV2Code.CommonReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_ZumxUdp-Ed-ak6NoX_4Aeg_-1986425644")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementQuantity = RepairReasonV2Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_ZumxUtp-Ed-ak6NoX_4Aeg_-227319143")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementQuantity = RepairReasonV2Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ZumxU9p-Ed-ak6NoX_4Aeg_1425308365")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrency = RepairReasonV2Code.SettlementAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZumxVNp-Ed-ak6NoX_4Aeg_1133350627")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RepairReasonV2Code.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ZumxVdp-Ed-ak6NoX_4Aeg_1311469299")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RepairReasonV2Code.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZumxVtp-Ed-ak6NoX_4Aeg_-1224391496")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    Reference = RepairReasonV2Code.Reference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZumxV9p-Ed-ak6NoX_4Aeg_428236012")]
    [Description(@"Impossible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed =
        RepairReasonV2Code.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZumxWNp-Ed-ak6NoX_4Aeg_136278274")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccount = RepairReasonV2Code.SafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ZumxWdp-Ed-ak6NoX_4Aeg_314396946")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransaction = RepairReasonV2Code.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_ZumxWtp-Ed-ak6NoX_4Aeg_2073503447")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethod = RepairReasonV2Code.SettlementSystemMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ZuwiUNp-Ed-ak6NoX_4Aeg_-568836341")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatus = RepairReasonV2Code.TaxStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing Place of Safekeeping.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_ZuwiUdp-Ed-ak6NoX_4Aeg_-860794079")]
    [Description(@"Unrecognised, invalid or missing Place of Safekeeping.")]
    PlaceOfSafekeeping = RepairReasonV2Code.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_ZuwiUtp-Ed-ak6NoX_4Aeg_-682675407")]
    [Description(@"Required stamp duty information is missing.")]
    StampDuty = RepairReasonV2Code.StampDuty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZuwiU9p-Ed-ak6NoX_4Aeg_1076431094")]
    [Description(@"Other. See Narrative.")]
    Other = RepairReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 2 mismatch.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ZuwiVNp-Ed-ak6NoX_4Aeg_-1679747760")]
    [Description(@"Client of delivering or receiving party 2 mismatch.")]
    ReceivingDeliveringParty3 = RepairReasonV2Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant of delivering or receiving depository mismatch.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZuwiVdp-Ed-ak6NoX_4Aeg_1440028511")]
    [Description(@"Participant of delivering or receiving depository mismatch.")]
    ReceivingDeliveringParty1 = RepairReasonV2Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Depository mismatch.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ZuwiVtp-Ed-ak6NoX_4Aeg_734913896")]
    [Description(@"Depository mismatch.")]
    ReceivingDeliveringDepository = RepairReasonV2Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 1 mismatch.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_ZuwiV9p-Ed-ak6NoX_4Aeg_-1914785965")]
    [Description(@"Client of delivering or receiving party 1 mismatch.")]
    ReceivingDeliveringParty2 = RepairReasonV2Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ZuwiWNp-Ed-ak6NoX_4Aeg_851101673")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RepairReasonV2Code.TerminationTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_ZuwiWdp-Ed-ak6NoX_4Aeg_737262607")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RepairReasonV2Code.TransactionCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_Zu5sQNp-Ed-ak6NoX_4Aeg_-145970680")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RepairReasonV2Code.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_Zu5sQdp-Ed-ak6NoX_4Aeg_-259809746")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RepairReasonV2Code.SpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_Zu5sQtp-Ed-ak6NoX_4Aeg_-1143043033")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupport = RepairReasonV2Code.VariableRateSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_Zu5sQ9p-Ed-ak6NoX_4Aeg_-1256882099")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RepairReasonV2Code.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_Zu5sRNp-Ed-ak6NoX_4Aeg_-2140115386")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RepairReasonV2Code.PremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_Zu5sRdp-Ed-ak6NoX_4Aeg_2041012844")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTime = RepairReasonV2Code.ClosingDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_Zu5sRtp-Ed-ak6NoX_4Aeg_1157779557")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RepairReasonV2Code.ForfeitAmount, // same ordinal as derivation source for type conversions
}
