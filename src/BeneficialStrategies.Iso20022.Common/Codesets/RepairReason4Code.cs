// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the settlement instruction has a repair status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZuAUYNp-Ed-ak6NoX_4Aeg_964099822")]
[Description(@"Specifies the reason why the settlement instruction has a repair status.")]
[DerivedFrom(typeof(RepairReasonV2Code))]
public enum RepairReason4Code
{
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_ZuAUYdp-Ed-ak6NoX_4Aeg_-1466784536")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatch = RepairReasonV2Code.ProcessingBatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ZuAUYtp-Ed-ak6NoX_4Aeg_65323071")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateAction = RepairReasonV2Code.CorporateAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZuAUY9p-Ed-ak6NoX_4Aeg_27337028")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RepairReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ZuAUZNp-Ed-ak6NoX_4Aeg_-727412846")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem = RepairReasonV2Code.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZuAUZdp-Ed-ak6NoX_4Aeg_1209812327")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate = RepairReasonV2Code.SettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ZuAUZtp-Ed-ak6NoX_4Aeg_-738511623")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RepairReasonV2Code.DealPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZuAUZ9p-Ed-ak6NoX_4Aeg_-1976604551")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmount = RepairReasonV2Code.SettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZuAUaNp-Ed-ak6NoX_4Aeg_-1987703328")]
    [Description(@"Unrecognised or invalid settlement quantity.")]
    Quantity = RepairReasonV2Code.Quantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZuAUadp-Ed-ak6NoX_4Aeg_-50478155")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    Security = RepairReasonV2Code.Security, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ZuAUatp-Ed-ak6NoX_4Aeg_598296084")]
    [Description(@"Unrecognised or invalid trade date.")]
    TradeDate = RepairReasonV2Code.TradeDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_ZuKFYNp-Ed-ak6NoX_4Aeg_-466368129")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReference = RepairReasonV2Code.CommonReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_ZuKFYdp-Ed-ak6NoX_4Aeg_-1841293141")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity = RepairReasonV2Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_ZuKFYtp-Ed-ak6NoX_4Aeg_95932032")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity = RepairReasonV2Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ZuKFY9p-Ed-ak6NoX_4Aeg_1818642309")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrency = RepairReasonV2Code.SettlementAmountCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZuKFZNp-Ed-ak6NoX_4Aeg_-539099814")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RepairReasonV2Code.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ZuKFZdp-Ed-ak6NoX_4Aeg_-1398304649")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RepairReasonV2Code.PlaceOfTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZuKFZtp-Ed-ak6NoX_4Aeg_538920524")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    Reference = RepairReasonV2Code.Reference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Impossible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZuKFZ9p-Ed-ak6NoX_4Aeg_-1259032683")]
    [Description(@"Impossible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed = RepairReasonV2Code.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZuKFaNp-Ed-ak6NoX_4Aeg_780932779")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccount = RepairReasonV2Code.SafekeepingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ZuKFadp-Ed-ak6NoX_4Aeg_-911247418")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransaction = RepairReasonV2Code.SettlementTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_ZuT2YNp-Ed-ak6NoX_4Aeg_1025977755")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethod = RepairReasonV2Code.SettlementSystemMethod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ZuT2Ydp-Ed-ak6NoX_4Aeg_1014878978")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatus = RepairReasonV2Code.TaxStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing Place of Safekeeping.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_ZuT2Ytp-Ed-ak6NoX_4Aeg_-668193694")]
    [Description(@"Unrecognised, invalid or missing Place of Safekeeping.")]
    PlaceOfSafekeeping = RepairReasonV2Code.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_ZuT2Y9p-Ed-ak6NoX_4Aeg_-309309652")]
    [Description(@"Required stamp duty information is missing.")]
    StampDuty = RepairReasonV2Code.StampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZuT2ZNp-Ed-ak6NoX_4Aeg_1435630589")]
    [Description(@"Other. See Narrative.")]
    Other = RepairReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client of delivering or receiving party 2 mismatch.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ZuT2Zdp-Ed-ak6NoX_4Aeg_1392220821")]
    [Description(@"Client of delivering or receiving party 2 mismatch.")]
    ReceivingDeliveringParty3 = RepairReasonV2Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant of delivering or receiving depository mismatch.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZuT2Ztp-Ed-ak6NoX_4Aeg_103190730")]
    [Description(@"Participant of delivering or receiving depository mismatch.")]
    ReceivingDeliveringParty1 = RepairReasonV2Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Depository mismatch.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ZuT2Z9p-Ed-ak6NoX_4Aeg_-715762951")]
    [Description(@"Depository mismatch.")]
    ReceivingDeliveringDepository = RepairReasonV2Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client of delivering or receiving party 1 mismatch.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_ZuT2aNp-Ed-ak6NoX_4Aeg_46271197")]
    [Description(@"Client of delivering or receiving party 1 mismatch.")]
    ReceivingDeliveringParty2 = RepairReasonV2Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions
    
}
