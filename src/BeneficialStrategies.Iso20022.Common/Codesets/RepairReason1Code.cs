// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zsq3pdp-Ed-ak6NoX_4Aeg_-1096933916")]
[Description(@"Specifies the reason why the instruction is in repair.")]
[DerivedFrom(typeof(RepairReasonCode))]
public enum RepairReason1Code
{
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/realtime while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_Zsq3ptp-Ed-ak6NoX_4Aeg_-1096933854")]
    [Description(
        @"Unrecognised or invalid processing batch, that is, daytime/realtime while only possible to settle in overnight batch."
    )]
    ProcessingBatch = RepairReasonCode.ProcessingBatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_Zsq3p9p-Ed-ak6NoX_4Aeg_-1096933824")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RepairReasonCode.TransactionCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_Zsq3qNp-Ed-ak6NoX_4Aeg_-1096933823")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateAction = RepairReasonCode.CorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Zs0BkNp-Ed-ak6NoX_4Aeg_-1096933793")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RepairReasonCode.CashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_Zs0Bkdp-Ed-ak6NoX_4Aeg_-1096933792")]
    [Description(
        @"Impossible standing arrangements override instruction for the cash settlement system."
    )]
    ImpossibleCashSettlementSystem = RepairReasonCode.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Zs0Bktp-Ed-ak6NoX_4Aeg_-1096933791")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate = RepairReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_Zs0Bk9p-Ed-ak6NoX_4Aeg_-1096933763")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RepairReasonCode.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of settlement.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Zs0BlNp-Ed-ak6NoX_4Aeg_-1096933762")]
    [Description(@"Unrecognised or invalid place of settlement.")]
    PlaceOfSettlement = RepairReasonCode.PlaceOfSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_Zs0Bldp-Ed-ak6NoX_4Aeg_-1096933732")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmount = RepairReasonCode.SettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Zs0Bltp-Ed-ak6NoX_4Aeg_-1096933702")]
    [Description(@"Unrecognised or invalid settlement quantity.")]
    Quantity = RepairReasonCode.Quantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Zs0Bl9p-Ed-ak6NoX_4Aeg_-1096933701")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    Security = RepairReasonCode.Security, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Zs0BmNp-Ed-ak6NoX_4Aeg_-1096933671")]
    [Description(@"Unrecognised or invalid trade date.")]
    TradeDate = RepairReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_Zs0Bmdp-Ed-ak6NoX_4Aeg_-1096933670")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RepairReasonCode.ForfeitAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid receiving or delivering agent.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Zs0Bmtp-Ed-ak6NoX_4Aeg_-1096933423")]
    [Description(@"Unrecognised or invalid receiving or delivering agent.")]
    Agent = RepairReasonCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid receiving or delivering custodian.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_Zs9ykNp-Ed-ak6NoX_4Aeg_-1096933422")]
    [Description(@"Unrecognised or invalid receiving or delivering custodian.")]
    ReceivingOrDeliveringCustodian = RepairReasonCode.ReceivingOrDeliveringCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid buyer or seller.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_Zs9ykdp-Ed-ak6NoX_4Aeg_-1096933393")]
    [Description(@"Unrecognised or invalid buyer or seller.")]
    BuyerorSeller = RepairReasonCode.BuyerorSeller, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_Zs9yktp-Ed-ak6NoX_4Aeg_-1096933362")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReference = RepairReasonCode.CommonReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid letter of guarantee indicator instructed.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_Zs9yk9p-Ed-ak6NoX_4Aeg_-1096933331")]
    [Description(@"Unrecognised or invalid letter of guarantee indicator instructed.")]
    LetterOfGuaranteeIndicator = RepairReasonCode.LetterOfGuaranteeIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_Zs9ylNp-Ed-ak6NoX_4Aeg_-1096933330")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementQuantity = RepairReasonCode.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_Zs9yldp-Ed-ak6NoX_4Aeg_-1096933301")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementQuantity = RepairReasonCode.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_Zs9yltp-Ed-ak6NoX_4Aeg_-1096933300")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrency = RepairReasonCode.SettlementAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Zs9yl9p-Ed-ak6NoX_4Aeg_-1096933270")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RepairReasonCode.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Zs9ymNp-Ed-ak6NoX_4Aeg_-1096933269")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RepairReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_Zs9ymdp-Ed-ak6NoX_4Aeg_-1096932992")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    Reference = RepairReasonCode.Reference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ZtHjkNp-Ed-ak6NoX_4Aeg_-1096932991")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RepairReasonCode.TerminationTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_ZtHjkdp-Ed-ak6NoX_4Aeg_-1096932990")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RepairReasonCode.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_ZtHjktp-Ed-ak6NoX_4Aeg_-1096932961")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RepairReasonCode.PremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_ZtHjk9p-Ed-ak6NoX_4Aeg_-1096932930")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RepairReasonCode.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_ZtHjlNp-Ed-ak6NoX_4Aeg_-1096932929")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RepairReasonCode.SpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZtHjldp-Ed-ak6NoX_4Aeg_-1096932928")]
    [Description(@"Impossible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed =
        RepairReasonCode.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZtHjltp-Ed-ak6NoX_4Aeg_-1096932900")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccount = RepairReasonCode.SafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ZtHjl9p-Ed-ak6NoX_4Aeg_-1096932869")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransaction = RepairReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_ZtHjmNp-Ed-ak6NoX_4Aeg_-1096932868")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethod = RepairReasonCode.SettlementSystemMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ZtHjmdp-Ed-ak6NoX_4Aeg_-1096932838")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTime = RepairReasonCode.ClosingDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ZtHjmtp-Ed-ak6NoX_4Aeg_-1096932808")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatus = RepairReasonCode.TaxStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_ZtQtgNp-Ed-ak6NoX_4Aeg_-1096932807")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupport = RepairReasonCode.VariableRateSupport, // same ordinal as derivation source for type conversions
}
